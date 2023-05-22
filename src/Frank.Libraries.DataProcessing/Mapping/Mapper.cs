using System.Reflection;

namespace Frank.Libraries.DataProcessing.Mapping;

public class Mapper
{
    public TDestination Map<TSource, TDestination>(TSource source) where TDestination : new()
    {
        var destination = new TDestination();
        MapToDestination(source, destination);
        return destination;
    }

    private void MapToDestination<TSource, TDestination>(TSource source, TDestination destination) =>
        destination?.GetType()
                   .GetMembers()
                   .Where(x => x.MemberType == MemberTypes.Property || x.MemberType == MemberTypes.Field)
                   .Select(x => x.Name)
                   .ToList()
                   .ForEach(x => SetValue(source, destination, GetMembers(source, destination, x)));

    private MemberInfo SetValue<TSource, TDestination>(TSource source, TDestination destination, (MemberInfo SourceMember, MemberInfo DestinationMember) members) => SetValue(source, destination, members.SourceMember, members.DestinationMember);

    private MemberInfo SetValue<TSource, TDestination>(TSource source, TDestination destination, MemberInfo sourceMember, MemberInfo destinationMember)
    {
        var sourceValue = GetValue(sourceMember, source);
        SetValue(destination, destinationMember, sourceValue);
        return destinationMember;
    }

    private void SetValue<T>(T destination, MemberInfo member, object? value)
    {
        if (member.MemberType == MemberTypes.Property)
        {
            SetPropertyValue(destination, (PropertyInfo)member, value);
        }
        else if (member.MemberType == MemberTypes.Field)
        {
            SetFieldValue(destination, (FieldInfo)member, value);
        }
    }

    private object? GetValue<T>(MemberInfo member, T source) =>
        member switch
        {
            PropertyInfo propertyInfo => propertyInfo.GetValue(source),
            FieldInfo fieldInfo       => fieldInfo.GetValue(source),
            _                         => null
        };

    private void SetFieldValue<T>(T destination, FieldInfo field, object? value) => field.SetValue(destination, value);

    private void SetPropertyValue<T>(T destination, PropertyInfo property, object? value) => property.SetValue(destination, value);

    private FieldInfo GetFieldInfo<T>(T type, string name) where T : new() =>
        type.GetType()
            .GetField(name);

    private PropertyInfo GetPropertyInfo<T>(T type, string name) where T : new() =>
        type.GetType()
            .GetProperty(name);

    private void MapMembers<TSource, TDestination>(TSource source, TDestination destination) where TDestination : new()
    {
        foreach (var memberInfo in destination.GetType()
                                              .GetMembers())
        {
            MapMember(source, memberInfo, destination);
        }
    }

    private void MapMember<TSource, TDestination>(TSource source, MemberInfo memberInfo, TDestination destination) where TDestination : new()
    {
        var sourceMember = source.GetType()
                                 .GetMember(memberInfo.Name)
                                 .FirstOrDefault();

        var mapped = false;

        if (memberInfo.MemberType == sourceMember?.MemberType && memberInfo.MemberType == MemberTypes.Property)
        {
            mapped = JustDoIt(() => destination.GetType()
                                               .GetProperty(memberInfo.Name)
                                               ?.SetValue(destination, source.GetType()
                                                                             .GetProperty(sourceMember.Name)
                                                                             ?.GetValue(source)));
        }

        if (memberInfo.MemberType == sourceMember?.MemberType && memberInfo.MemberType == MemberTypes.Field)
        {
            mapped = JustDoIt(() => destination.GetType()
                                               .GetField(memberInfo.Name)
                                               ?.SetValue(destination, source.GetType()
                                                                             .GetField(sourceMember.Name)
                                                                             ?.GetValue(source)));
        }

        mapped = memberInfo.MemberType switch
        {
            MemberTypes.Field when sourceMember?.MemberType == MemberTypes.Property => JustDoIt(() => destination.GetType()
                                                                                                                 .GetField(memberInfo.Name)
                                                                                                                 ?.SetValue(destination, source.GetType()
                                                                                                                                               .GetProperty(sourceMember.Name)
                                                                                                                                               ?.GetValue(source))),
            MemberTypes.Property when sourceMember?.MemberType == MemberTypes.Field => JustDoIt(() => destination.GetType()
                                                                                                                 .GetProperty(memberInfo.Name)
                                                                                                                 ?.SetValue(destination, source.GetType()
                                                                                                                                               .GetField(sourceMember.Name)
                                                                                                                                               ?.GetValue(source))),
            _ => mapped
        };

        if (memberInfo.MemberType == MemberTypes.NestedType)
        {
            //MapMembers<TSource, TDestination>(sourceMember., destinationType);
        }
    }

    private (MemberInfo SourceMember, MemberInfo DestinationMember) GetMembers<TSource, TDestination>(TSource source, TDestination destination, string name)
    {
        (MemberInfo SourceMember, MemberInfo DestinationMember) output;
        output.SourceMember = source.GetType()
                                    .GetMember(name)
                                    .FirstOrDefault();
        output.DestinationMember = destination.GetType()
                                              .GetMember(name)
                                              .FirstOrDefault();
        return output;
    }

    private bool JustDoIt(Action action)
    {
        try
        {
            action();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
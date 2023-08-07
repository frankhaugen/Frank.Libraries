using System.Text;
using ConsoleTableExt;
using Markdig;
using Microsoft.Extensions.DependencyInjection;
using Namotion.Reflection;

namespace Frank.Libraries.Tests.TestingInfrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static string DumpServices(this IServiceCollection services)
    {
        var table = new StringBuilder();
        table.AppendLine("| Service Type | Implementation Type |");
        table.AppendLine("|--------------|---------------------|");

        foreach (var service in services)
        {
            var serviceType = service.ServiceType.GetDisplayName();
            var implementationType = service.ImplementationType?.GetDisplayName() ?? "<Unknown>";

            table.AppendLine($"| {serviceType} | {implementationType} |");
        }
        return Markdown.Normalize(table.ToString());
    }

    public static string GetDebugView(this IServiceCollection services)
    {
        var serviceList = new List<ServiceDebugView>();
        serviceList.AddRange(from service in services let serviceType = service.ServiceType.GetDisplayName() let implementationType = service.ImplementationType?.GetDisplayName() ?? "<Unknown>" select new ServiceDebugView(){ServiceType = serviceType,ImplementationType = implementationType});
        // var table = ConsoleTable.From(serviceList);
        var table = ConsoleTableBuilder.From(serviceList)
                                       .WithFormat(ConsoleTableBuilderFormat.Minimal)
                                       .Export()
                                       .ToString();
        return table;
    }
}
public class ServiceDebugView
{
    public string ServiceType { get; set; }
    public string ImplementationType { get; set; }
}
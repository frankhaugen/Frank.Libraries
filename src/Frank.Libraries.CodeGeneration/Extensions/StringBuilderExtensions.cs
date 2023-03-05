using System.Collections.Generic;
using System.Text;
using Frank.Libraries.CodeGeneration.Models;

namespace Frank.Libraries.CodeGeneration.Extensions;

public static class StringBuilderExtensions
{
    public static StringBuilder AppendWithTrailingSpace(this StringBuilder source, string value) =>
        source.Append(value)
              .Append(" ");

    public static StringBuilder AppendSurroundedBy(this StringBuilder source, char prefix, string value, char suffix) =>
        source.Append(prefix)
              .Append(value)
              .Append(suffix);

    public static StringBuilder AppendIndented(this StringBuilder source, string value, int indents = 0) =>
        source.Append(Helpers.Indent(indents))
              .Append(value);

    public static StringBuilder AppendIndents(this StringBuilder source, int indents = 0) => source.Append(Helpers.Indent(indents));

    public static StringBuilder AppendIndentedLine(this StringBuilder source, int indents = 0, string value = "") => source.Append($"\n{Helpers.Indent(indents)}{value}");

    public static StringBuilder AppendIndentedLines(this StringBuilder source, List<string> values, int indents = 0)
    {
        foreach (var value in values)
        {
            source.AppendIndentedLine(indents, value);
        }

        return source;
    }

    public static StringBuilder AppendIf(this StringBuilder source, string value, bool predicate, string fallback = "")
    {
        if (predicate)
        {
            source.Append(value);
        }
        else
        {
            source.Append(fallback);
        }

        return source;
    }

    //public static StringBuilder AppendForeach(this StringBuilder source, string value, bool predicate, string fallback = "")
    //{
    //    if (predicate)
    //    {
    //        source.Append(value);
    //    }
    //    else
    //    {
    //        source.Append(fallback);
    //    }

    //    return source;
    //}
}
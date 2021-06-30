using System.Collections.Generic;
using System.IO;
using CodegenCS;

namespace Frank.Libraries.CodeGeneration.Generators
{
    public class FluentCalculatorGenerator
    {
        public string Generate(string namespaceName, string className, FileInfo? fileInfo = null, bool saveToFile = true)
        {
            var w = new CodegenTextWriter();

            var typesOverride = new List<string>();
            typesOverride.Add("int");
            typesOverride.Add("short");
            typesOverride.Add("long");

            var types = new List<string>();
            types.Add("int");
            //types.Add("uint");
            types.Add("short");
            //types.Add("ushort");
            types.Add("long");
            //types.Add("ulong");
            types.Add("float");
            types.Add("double");
            types.Add("decimal");

            var operators = new Dictionary<Operator, string>();
            operators.Add(Operator.Add, "+");
            operators.Add(Operator.Subtract, "-");
            operators.Add(Operator.Multiply, "*");
            operators.Add(Operator.Divide, "/");


            w.WithCurlyBraces($"namespace {namespaceName}", () =>
            {
                w.WithCurlyBraces($"public static class {className}", () =>
                {
                    foreach (var @operator in operators)
                    //foreach (var type in types)
                    {
                        w.WriteLine(w.NewLine);
                        w.WriteLine($"// {@operator.Key} ");
                        //foreach (var @operator in operators)
                        foreach (var type in types)
                        {
                            var returnType = type;
                            if (@operator.Key == Operator.Divide && typesOverride.Contains(type)) returnType = "decimal";
                            w.WriteLine($"public static {returnType} {@operator.Key}(this {type} source, {type} value) => ({returnType}) (source {@operator.Value} value);");
                        }
                    }
                });
            });

            if(saveToFile) w.SaveToFile(fileInfo!.FullName);

            return w.GetContents();
        }
    }

    public enum Operator
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}
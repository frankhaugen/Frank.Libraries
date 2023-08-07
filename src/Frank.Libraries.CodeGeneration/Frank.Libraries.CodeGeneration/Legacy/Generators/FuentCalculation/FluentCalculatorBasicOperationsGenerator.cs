// using CodegenCS;
//
// namespace Frank.Libraries.CodeGeneration.Generators.FuentCalculation;
//
// public class FluentCalculatorBasicOperationsGenerator : IGenerator
// {
//     private static List<string> Types => new()
//     {
//         "int",
//         //types.Add("uint");
//         "short",
//         //types.Add("ushort");
//         "long",
//         //types.Add("ulong");
//         "float",
//         "double",
//         "decimal"
//     };
//
//     private static Dictionary<Operator, string> Operators => new()
//     {
//         { Operator.Add, "+" },
//         { Operator.Subtract, "-" },
//         { Operator.Multiply, "*" },
//         { Operator.Divide, "/" }
//     };
//
//     public string Generate(string namespaceName, string className)
//     {
//         var writer = new CodegenTextWriter();
//
//         var typesOverride = new List<string>
//         {
//             "int",
//             "short",
//             "long"
//         };
//
//         writer.WriteLine($"namespace {namespaceName};");
//         writer.WriteLine(" ");
//         writer.WithCurlyBraces($"public static class {className}", () =>
//         {
//             foreach (var @operator in Operators)
//             {
//                 writer.WriteLine($"// {@operator.Key} ");
//                 foreach (var type in Types)
//                 {
//                     var returnType = type;
//                     if (@operator.Key == Operator.Divide && typesOverride.Contains(type))
//                     {
//                         returnType = "decimal";
//                     }
//
//                     writer.WriteLine($"public static {returnType} {@operator.Key}(this {type} source, {type} value) => ({returnType}) (source {@operator.Value} value);");
//                 }
//
//                 writer.WriteLine(" ");
//             }
//         });
//
//         return writer.GetContents();
//     }
//
//     private enum Operator
//     {
//         Add,
//         Subtract,
//         Multiply,
//         Divide,
//         PowerOf
//     }
// }
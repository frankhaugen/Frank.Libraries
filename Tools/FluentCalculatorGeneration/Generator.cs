using Frank.Libraries.CodeGeneration.Generators;

namespace Tools.FluentCalculatorGeneration
{
    public class FluentCalculatorTool
    {

        private readonly FluentCalculatorGenerator _generator;

        public FluentCalculatorTool() => _generator = new FluentCalculatorGenerator();

        public void Generate()
        {
            // _generator.Generate();
        }
    }
}
using Frank.Libraries.Calculators.Converters;

namespace Frank.Libraries.Calculators
{
    public class UnitConverter
    {
        public UnitConverter()
        {
            Temperature = new TemperatureConverter();
        }

        public TemperatureConverter Temperature;
    }
}

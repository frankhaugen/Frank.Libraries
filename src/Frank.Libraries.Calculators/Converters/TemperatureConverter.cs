namespace Frank.Libraries.Calculators.Converters
{
    public class TemperatureConverter
    {
        public decimal FahrenheitToCelsius(decimal temperature) => (temperature - 32m) * 5m / 9m;
        public decimal CelsiusToFahrenheit(decimal temperature) => (temperature * 9m / 5m) + 32m;
        public decimal CelsiusToKelvin(decimal temperature) => temperature + 273.15m;
        public decimal KelvinToCelsius(decimal temperature) => temperature - 273.15m;
        public decimal FahrenheitToKelvin(decimal temperature) => (temperature - 32m) * 5m / 9m + 273.15m;
        public decimal KelvinToFahrenheit(decimal temperature) => (temperature - 273.15m) * 9m / 5m + 32m;
    }
}

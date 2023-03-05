namespace Frank.Libraries.Calculators.Converters;

public class TemperatureConverter
{
    public static decimal FahrenheitToCelsius(decimal temperature) => (temperature - 32m) * 5m / 9m;
    public static decimal CelsiusToFahrenheit(decimal temperature) => temperature * 9m / 5m + 32m;
    public static decimal CelsiusToKelvin(decimal temperature) => temperature + 273.15m;
    public static decimal KelvinToCelsius(decimal temperature) => temperature - 273.15m;
    public static decimal FahrenheitToKelvin(decimal temperature) => (temperature - 32m) * 5m / 9m + 273.15m;
    public static decimal KelvinToFahrenheit(decimal temperature) => (temperature - 273.15m) * 9m / 5m + 32m;
}
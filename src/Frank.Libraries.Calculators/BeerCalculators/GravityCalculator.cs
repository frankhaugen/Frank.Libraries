using Frank.Libraries.Calculators.Converters;

namespace Frank.Libraries.Calculators.BeerCalculators
{
    public class GravityCalculator
    {
        public decimal Calculate(decimal specificGravity, decimal temperature, decimal calibrationTemperature = 20.0m)
        {
            var fahrenheitTemperature = TemperatureConverter.CelsiusToFahrenheit(temperature);
            var fahrenheitCalibrationTemperature = TemperatureConverter.CelsiusToFahrenheit(calibrationTemperature);

            return CalculateFahrenheit(specificGravity, fahrenheitTemperature, fahrenheitCalibrationTemperature);
        }

        public decimal CalculateFahrenheit(decimal specificGravity, decimal fahrenheitTemperature, decimal fahrenheitCalibrationTemperature = 68.0m)
        {
            //return specificGravity *
            //       ((1.00130346m - 0.000134722124m * fahrenheitTemperature + 0.00000204052596m * fahrenheitTemperature -
            //         0.00000000232820948m * fahrenheitTemperature) / (1.00130346m -
            //                                                          0.000134722124m *
            //                                                          fahrenheitCalibrationTemperature +
            //                                                          0.00000204052596m *
            //                                                          fahrenheitCalibrationTemperature -
            //                                                          0.00000000232820948m *
            //                                                          fahrenheitCalibrationTemperature));

            return specificGravity
                   * (1.00130346m
                      - (0.000134722124m * fahrenheitTemperature)
                      + (0.00000204052596m * PowerOf(fahrenheitTemperature, 2)))
                   - (0.00000000232820948m * PowerOf(fahrenheitTemperature, 3))
                   / (1.00130346m
                      - (0.000134722124m * fahrenheitCalibrationTemperature)
                      + (0.00000204052596m * PowerOf(fahrenheitCalibrationTemperature, 2))
                      - (0.00000000232820948m * PowerOf(fahrenheitCalibrationTemperature, 3)));
        }

        private static decimal PowerOf(decimal value, int powerOf)
        {
            var result = value;

            for (var i = 1; i < powerOf; i++)
            {
                result *= value;
            }

            return result;
        }

        //CG = corrected gravity
        //MG = measured gravity
        //TR = temperature at time of reading
        //TC = calibration temperature of hydrometer
        //    CG = MG * ((1.00130346 – 0.000134722124 * TR + 0.00000204052596 * TR – 0.00000000232820948 * TR) / (1.00130346 – 0.000134722124 * TC + 0.00000204052596 * TC – 0.00000000232820948 * TC))
    }
}
namespace Frank.Libraries.Calculators.Types
{
    public class PolarCoordinates : IPolarCoordinates
    {
        /// <inheritdoc/>
        public decimal Radius { get; set; }

        /// <inheritdoc/>
        public decimal Inclination { get; set; }

        /// <inheritdoc/>
        public decimal Azimuth { get; set; }
    }
}
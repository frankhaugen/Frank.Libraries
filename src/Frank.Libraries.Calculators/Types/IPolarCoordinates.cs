namespace Frank.Libraries.Calculators.Types
{
    public interface IPolarCoordinates
    {
        /// <summary>
        /// Distance
        /// </summary>
        public decimal Radius { get; set; }

        /// <summary>
        /// Inclination
        /// </summary>
        public decimal Inclination { get; set; }

        /// <summary>
        /// Azimuth
        /// </summary>
        public decimal Azimuth { get; set; }
    }
}
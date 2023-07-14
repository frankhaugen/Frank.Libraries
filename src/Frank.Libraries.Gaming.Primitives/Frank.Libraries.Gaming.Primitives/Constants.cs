using System.Numerics;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Primitives;

public static class Constants
{
    /// <summary>
    /// The TerrestrialConstants class provides constants that are specific to Earth and commonly used in physics and mathematics.
    /// </summary>
    public static class TerrestrialConstants
    {
        /// <summary>
        /// Average radius of Earth in kilometers.
        /// Example usage: double circumference = 2 * UniversalConstants.Pi * TerrestrialConstants.EarthRadius.
        /// </summary>
        public const decimal EarthRadius = 6371M;

        /// <summary>
        /// Earth's surface gravity in m/s^2.
        /// Example usage: double weight = mass * TerrestrialConstants.EarthGravity.
        /// </summary>
        public const float EarthGravity = 9.80665f;

        /// <summary>
        /// Earth's orbital speed in km/s.
        /// Example usage: decimal yearInSeconds = 2 * UniversalConstants.Pi * TerrestrialConstants.EarthRadius / TerrestrialConstants.EarthOrbitalSpeed * 60 * 60 * 24.
        /// </summary>
        public const decimal EarthOrbitalSpeed = 29.78M;
    }

    /// <summary>
    /// The UniversalConstants class provides constants that are universal and commonly used in physics and mathematics.
    /// </summary>
    public static class UniversalConstants
    {
        /// <summary>
        /// Speed of light in meters per second.
        /// Example usage: double distance = UniversalConstants.SpeedOfLight * timeInSeconds.
        /// </summary>
        public const decimal SpeedOfLight = 299792458M;

        /// <summary>
        /// Pi, the ratio of the circumference of a circle to its diameter.
        /// Example usage: double circumference = 2 * UniversalConstants.Pi * radius.
        /// </summary>
        public const decimal Pi = 3.14159265358979323846M;

        /// <summary>
        /// Gravitational Constant in m^3 kg^-1 s^-2.
        /// Example usage: double force = UniversalConstants.GravitationalConstant * (mass1 * mass2 / Math.Pow(distance, 2)).
        /// </summary>
        public const decimal GravitationalConstant = 6.67430e-11M;

        /// <summary>
        /// Planck's Constant in Joule seconds.
        /// Example usage: double energy = UniversalConstants.PlancksConstant * frequency.
        /// </summary>
        public const decimal PlancksConstant = 6.62607015e-34M;
    }

    public static class MathConstants
    {
        public const float PiOver2 = (float)(Math.PI / 2.0);
        public const float PiOver4 = (float)(Math.PI / 4.0);
        public const float TwoPi = (float)(Math.PI * 2.0);

        public const float Epsilon = 1.192092896e-07f;

        public const float Deg2Rad = (float)(Math.PI / 180.0);

        public const float Rad2Deg = (float)(180.0 / Math.PI);

        public const float Infinity = float.PositiveInfinity;

        public const float NegativeInfinity = float.NegativeInfinity;

        public const float Deg2Rad2 = 0.0174532924f;

        public const float Rad2Deg2 = 57.29578f;
    }

    public static class AspectRatioConstants
    {
        public const float Landscape = 1.333f;
        public const float Portrait = 0.75f;
        public const float Letterbox = 1.6f;
        public const float Square = 1f;
        public const float Imax = 1.9f;
        public const float Console = 1.777f;
        public const float Ultrawide = 2.37f;
        public const float Standard = 1.333f;
        public const float Widescreen = 1.6f;
        public const float SuperUltrawide = 3.37f;
    }
}
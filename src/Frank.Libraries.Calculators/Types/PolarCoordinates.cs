namespace Frank.Libraries.Calculators.Types;

public struct PolarCoordinates
{
    public decimal Radius { get; set; }

    public decimal Inclination { get; set; }

    public decimal Azimuth { get; set; }
}

public struct CartesianCoordinates
{
    public decimal X { get; set; }

    public decimal Y { get; set; }

    public decimal Z { get; set; }
}
using Frank.Libraries.Calculators.EuclideanCalculators;

namespace Frank.Libraries.Calculators
{
    public class EuclideanCalculator
    {
        public EuclideanCalculator()
        {
            Distance = new EuclideanDistanceCalculator();
        }

        public EuclideanDistanceCalculator Distance;
    }
}

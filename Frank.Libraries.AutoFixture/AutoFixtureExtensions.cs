using AutoFixture;

namespace Frank.Libraries.AutoFixture
{
    public static class AutoFixtureExtensions
    {
        internal static Fixture OmitRecursion(this Fixture fixture)
        {
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            return fixture;
        }
    }
}

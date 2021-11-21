using AutoFixture;

namespace Frank.Libraries.AutoFixture
{
    /// <summary>
    /// Extensions for autofixture
    /// </summary>
    public static class AutoFixtureExtensions
    {
        /// <summary>
        /// Disables recursive behavior
        /// </summary>
        /// <param name="fixture"></param>
        /// <returns></returns>
        public static Fixture OmitRecursion(this Fixture fixture)
        {
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            return fixture;
        }
    }
}
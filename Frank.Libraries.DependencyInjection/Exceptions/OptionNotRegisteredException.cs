using System;

namespace Frank.Libraries.DependencyInjection.Exceptions
{
    public class OptionNotRegisteredException<T> : Exception
    {
        /// <inheritdoc />
        public OptionNotRegisteredException() : base(CreateMessage())
        {
        }

        private static string CreateMessage()
        {
            return $"The service '{typeof(T).Name}' is not registered";
        }
    }
}

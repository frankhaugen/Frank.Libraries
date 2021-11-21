using System;

namespace Frank.Libraries.DependencyInjection.Exceptions
{
    public class ServiceNotRegisteredException<T> : Exception
    {
        /// <inheritdoc />
        public ServiceNotRegisteredException() : base(CreateMessage())
        {
        }

        private static string CreateMessage()
        {
            return $"The service '{typeof(T).Name}' is not registered";
        }
    }
}
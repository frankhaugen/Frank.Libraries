using System;

namespace Frank.Libraries.DependencyInjection
{
    public class ServiceDescriptor
    {
        public Type? ServiceType { get; set; }
        public Type? ImplementationType { get; set; }
        private object? Instance { get; set; }

        //public T Get<T>()
        //{
        //    T T;
        //    return T;
        //}
    }
}
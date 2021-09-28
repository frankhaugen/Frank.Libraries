using System.Collections.Generic;
using Frank.Libraries.DependencyInjection.Exceptions;
using Frank.Libraries.DependencyInjection.Interfaces;

namespace Frank.Libraries.DependencyInjection.Statics
{
    public static class IocContainer
    {
        private static Dictionary<string, IService> _services = new Dictionary<string, IService>();
        private static Dictionary<string, IOption> _options = new Dictionary<string, IOption>();

        public static void AddService<T>(T service) where T : IService
        {
            if (_services.ContainsKey(service.GetType().Name))
                return;
            _services.Add(service.GetType().Name, service);
        }

        public static T GetService<T>() where T : IService
        {
            if (!_services.ContainsKey(typeof(T).Name))
                throw new ServiceNotRegisteredException<T>();

            return (T)_services[typeof(T).Name];
        }

        public static void AddOption<T>(string key, T option) where T : IOption
        {
            if (_options.ContainsKey(key))
                return;
            _options.Add(key, option);
        }

        public static T GetOption<T>(string key) where T : IOption
        {
            if (!_options.ContainsKey(key))
                throw new OptionNotRegisteredException<T>();

            return (T)_options[key];
        }
    }
}

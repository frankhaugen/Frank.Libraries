using System;
using System.Linq;
using Frank.Libraries.Enums.Attributes;

namespace Frank.Libraries.Enums.Extensions
{
    /// <summary>
    /// </summary>
    public static class EnumAttributesExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string GetName<T>(this T value) where T : Enum
        {
            var field = value.GetType().GetField(value.ToString());
            var attributes = field?.GetCustomAttributes(typeof(NameAttribute), false);
            return !(attributes?.SingleOrDefault() is NameAttribute attribute) ? value.ToString() : attribute.GetName();
        }

        /// <summary>
        /// </summary>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string GetLocalName<T>(this T value) where T : Enum
        {
            var field = value.GetType().GetField(value.ToString());
            var attributes = field?.GetCustomAttributes(typeof(LocalNameAttribute), false);
            return !(attributes?.SingleOrDefault() is LocalNameAttribute attribute) ? value.ToString() : attribute.GetName();
        }
    }
}

using System;

namespace Frank.Libraries.Enums.Attributes
{
    /// <summary>
    /// Attribute to store an alternative name
    /// </summary>
    public class LocalNameAttribute : Attribute
    {
        private readonly string _name;

        /// <inheritdoc />
        public LocalNameAttribute(string name)
        {
            _name = name;
        }

        /// <summary>
        /// </summary>
        /// <returns><see cref="string"/></returns>
        public string GetName() => _name;
    }
}
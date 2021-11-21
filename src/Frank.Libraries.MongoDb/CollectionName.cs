using System;

namespace Frank.Libraries.MongoDb
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CollectionName : Attribute
    {
        public string? Name { get; set; }

        public CollectionName(string name = null!)
        {
            Name = name;
        }
    }
}
using System;

namespace Frank.Extensions.MongoDb
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CollectionName : Attribute
    {
        public string? Name { get; set; }

        public CollectionName(string name = null)
        {
            Name = name;
        }
    }
}

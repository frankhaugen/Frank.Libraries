using System;

namespace Frank.Libraries.MongoDb
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CollectionName : Attribute
    {
        public string? Name { get; set; }

        public CollectionName(string name = null!)
        {
            Name = name;
        }
    }
}
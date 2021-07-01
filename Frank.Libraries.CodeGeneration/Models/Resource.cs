namespace Frank.Libraries.CodeGeneration.Models
{
    public class Resource
    {
        public Resource(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; init; }
        public string Value { get; init; }
    }
}
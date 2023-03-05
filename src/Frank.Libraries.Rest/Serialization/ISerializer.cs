namespace Frank.Libraries.Rest.Serialization;

public interface ISerializer
{
    string Serialize<T>(T content);
    T Deserialize<T>(string content);
}
using System.Text;

namespace Frank.Libraries.IRC.Common;

public class RawMessage
{    public string? Prefix { get; }
     public string Command { get; }
     public List<string> Parameters { get; }

     public RawMessage(byte[] data)
     {
         var message = Encoding.UTF8.GetString(data);
         var parts = message.Split(' ');

         if (parts[0].StartsWith(":"))
         {
             Prefix = parts[0].Substring(1);
             Command = parts[1];
         }
         else
         {
             Command = parts[0];
         }

         Parameters = new List<string>();
         for (int i = Prefix != null ? 2 : 1; i < parts.Length; i++)
         {
             if (parts[i].StartsWith(":"))
             {
                 Parameters.Add(":" + string.Join(" ", parts.Skip(i)).Substring(1));
                 break;
             }
             else
             {
                 Parameters.Add(parts[i]);
             }
         }
     }

     public override string ToString()
     {
         var parts = new List<string>();
         if (Prefix != null)
         {
             parts.Add($":{Prefix}");
         }

         parts.Add(Command);

         if (Parameters.Count > 0)
         {
             var lastParameter = Parameters.Last();
             if (lastParameter.StartsWith(" "))
             {
                 lastParameter = $":{lastParameter}";
             }
             else if (lastParameter.StartsWith(":"))
             {
                 lastParameter = $":{lastParameter.Substring(1)}";
             }

             parts.AddRange(Parameters.Take(Parameters.Count - 1));
             parts.Add(lastParameter);
         }

         return string.Join(" ", parts);
     }

}
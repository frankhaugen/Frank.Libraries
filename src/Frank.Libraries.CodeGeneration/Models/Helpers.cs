﻿namespace Frank.Libraries.CodeGeneration.Models
{
    public static class Helpers
    {
        public static string Indent(int count = 1)
        {
            var output = "";
            for (int i = 0; i < count; i++)
            {
                output += "    ";
            }

            return output;
        }
    }
}
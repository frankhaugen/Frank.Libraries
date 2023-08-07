﻿namespace Frank.Libraries.CodeGeneration.Legacy.Models;

public class Resource
{
    public Resource(string key, string value)
    {
        Key = key;
        Value = value;
    }

    public string Key { get; }
    public string Value { get; }
}
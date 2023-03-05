using System;

namespace Frank.Libraries.CodeGeneration.Models;

public class IntegrationPair
{
    public IntegrationPair(Type source, Type destination)
    {
        Source = source;
        Destination = destination;
    }

    public Type Source { get; set; }
    public Type Destination { get; set; }
}
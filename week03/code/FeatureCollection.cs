using System.Reflection.Metadata.Ecma335;
using System.Runtime.Versioning;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public Features[] Features { get; set; }
}

public class Features
{
    public Properties Properties { get; set; }
}

public class Properties
{
    public float Mag { get; set; }
    public string Title { get; set; }
}
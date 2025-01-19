using Vektorel.Inheritance.Providers;

namespace Vektorel.Inheritance.Models.Mobility;

internal abstract class Vehicle : Identity
{
    protected Vehicle()
    {
        Prefix = "ARC";
    }
    public string Brand { get; set; }
    public int ModelYear { get; set; }
}
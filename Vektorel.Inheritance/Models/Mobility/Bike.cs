using Vektorel.Inheritance.Enums;

namespace Vektorel.Inheritance.Models.Mobility;

internal class Bike : Vehicle
{
    public SeatCount SeatCount { get; set; }
    public byte TransmissionCount { get; set; }
    public bool HasBattery { get; set; }
}

using System;

namespace NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport
{
    public abstract class Transport
    {
        public string Deliver(Cargo cargo) => $"Delivering {cargo.Content}";

        public double Speed { get; set; }
        public double ElevatingCapacity { get; set; }
        public string Brand { get; set; }
        public int StaffCount { get; set; }
        public int PassengerCount { get; set; }
        
        public override string ToString()
            => $"Speed: {Speed}{Environment.NewLine}Capacity: {ElevatingCapacity}{Environment.NewLine}Brand: {Brand}{Environment.NewLine}Staff count: {StaffCount}{Environment.NewLine}Passenger count: {PassengerCount}";

    }
}

using NETPractice.Polymorphism.TransportCompany.Entities;

namespace NETPractice.Polymorphism.TransportCompany.AbstractTransport
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
            => $"Speed: {Speed}\n"
               + $"Capacity: {ElevatingCapacity}\n"
               + $"Brand: {Brand}\n"
               + $"Staff count: {StaffCount}\n"
               + $"Passenger count: {PassengerCount}";

    }
}

using System;
using NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.Entities.InheritedTransport
{
    public class Tanker : WaterTransport
    {
        public Tanker() { }

        public Tanker(double speed, double elevatingCapacity, string brand, int staffCount, int passengerCount)
        {
            Speed = speed;
            ElevatingCapacity = elevatingCapacity;
            Brand = brand;
            StaffCount = staffCount;
            PassengerCount = passengerCount;
        }
        
        public override string ToString()
            => "Category: tanker" + Environment.NewLine + base.ToString();
    }
    
}

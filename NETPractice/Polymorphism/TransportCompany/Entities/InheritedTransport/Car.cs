using System;
using NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.Entities.InheritedTransport
{
    public class Car : SurfaceTransport
    {
        public Car() { }

        public Car(double speed, double elevatingCapacity, string brand, int staffCount, int passengerCount)
        {
            Speed = speed;
            ElevatingCapacity = elevatingCapacity;
            Brand = brand;
            StaffCount = staffCount;
            PassengerCount = passengerCount;
        }
        
        public override string ToString()
            => "Category: car" + Environment.NewLine + base.ToString();
    }
    
}

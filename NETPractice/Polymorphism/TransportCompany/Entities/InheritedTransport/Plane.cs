using System;
using NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.Entities.InheritedTransport
{
    public class Plane : AirTransport
    {
        public override string ToString()
            => "Type: plane" + Environment.NewLine + base.ToString();
    }
    
}

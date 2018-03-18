using System;
using NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.Entities.InheritedTransport
{
    public class Helicopter : AirTransport
    {
        public override string ToString()
            => "Type: helicopter" + Environment.NewLine + base.ToString();
    }
    
}

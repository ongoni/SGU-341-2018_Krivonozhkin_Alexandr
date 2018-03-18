using System;
using NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.Entities.InheritedTransport
{
    public class Car : SurfaceTransport
    {
        public override string ToString()
            => "Type: car" + Environment.NewLine + base.ToString();
    }
    
}

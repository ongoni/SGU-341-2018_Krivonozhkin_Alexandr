using System;
using NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.Entities.InheritedTransport
{
    public class Tanker : WaterTransport
    {
        public override string ToString()
            => "Category: tanker" + Environment.NewLine + base.ToString();
    }
    
}

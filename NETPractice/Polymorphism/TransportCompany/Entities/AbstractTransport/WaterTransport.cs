using System;

namespace NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport
{
    public class WaterTransport : Transport
    {
        public override string ToString()
            => "Type: Water transport" + Environment.NewLine + base.ToString();
    }
    
}

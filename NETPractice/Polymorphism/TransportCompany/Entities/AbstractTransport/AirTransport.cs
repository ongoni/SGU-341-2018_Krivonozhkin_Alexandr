using System;

namespace NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport
{
    public class AirTransport : Transport
    {
        public override string ToString()
            => "Type: Air transport" + Environment.NewLine + base.ToString();
    }
    
}

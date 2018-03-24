using System;

namespace NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport
{
    public class SurfaceTransport : Transport
    {
        public override string ToString()
            => "Type: Surface transport" + Environment.NewLine + base.ToString();
    }
    
}

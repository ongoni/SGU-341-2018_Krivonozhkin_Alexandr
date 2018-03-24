using System;

namespace NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport
{
    public abstract class SurfaceTransport : Transport
    {
        public override string ToString()
            => "Type: Surface transport" + Environment.NewLine + base.ToString();
    }
    
}

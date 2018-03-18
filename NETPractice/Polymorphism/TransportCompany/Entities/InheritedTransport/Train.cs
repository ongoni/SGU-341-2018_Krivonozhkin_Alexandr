using NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.Entities.InheritedTransport
{
    public class Train : SurfaceTransport
    {
        public override string ToString()
            => "Type: train" + base.ToString();
    }
    
}

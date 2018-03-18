using NETPractice.Polymorphism.TransportCompany.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.InheritedTransport
{
    public class Train : SurfaceTransport
    {
        public override string ToString()
            => "Type: train" + base.ToString();
    }
    
}

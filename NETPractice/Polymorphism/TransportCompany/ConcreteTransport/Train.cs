using NETPractice.Polymorphism.TransportCompany.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.ConcreteTransport
{
    public class Train : SurfaceTransport
    {
        public override string ToString()
            => "Type: train" + base.ToString();
    }
    
}

using NETPractice.Polymorphism.TransportCompany.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.ConcreteTransport
{
    public class Car : SurfaceTransport
    {
        public override string ToString()
            => "Type: car\n" + base.ToString();
    }
    
}

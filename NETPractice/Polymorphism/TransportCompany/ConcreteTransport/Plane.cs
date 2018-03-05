using NETPractice.Polymorphism.TransportCompany.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.ConcreteTransport
{
    public class Plane : AirTransport
    {
        public override string ToString()
            => "Type: plane" + base.ToString();
    }
    
}

using NETPractice.Polymorphism.TransportCompany.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.ConcreteTransport
{
    public class Tanker : WaterTransport
    {
        public override string ToString()
            => "Type: tanker" + base.ToString();
    }
    
}

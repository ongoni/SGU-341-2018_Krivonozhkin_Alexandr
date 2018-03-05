using NETPractice.Polymorphism.TransportCompany.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.ConcreteTransport
{
    public class Liner : WaterTransport
    {
        public override string ToString()
            => "Type: liner" + base.ToString();
    }
    
}

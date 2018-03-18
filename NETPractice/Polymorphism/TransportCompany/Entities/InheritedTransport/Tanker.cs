using NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.Entities.InheritedTransport
{
    public class Tanker : WaterTransport
    {
        public override string ToString()
            => "Type: tanker" + base.ToString();
    }
    
}

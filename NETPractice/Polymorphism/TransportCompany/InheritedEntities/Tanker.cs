using NETPractice.Polymorphism.TransportCompany.AbstractEntities;

namespace NETPractice.Polymorphism.TransportCompany.InheritedEntities
{
    public class Tanker : WaterTransport
    {
        public override string ToString()
            => "Type: tanker" + base.ToString();
    }
    
}

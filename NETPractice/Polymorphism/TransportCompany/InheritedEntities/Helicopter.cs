using NETPractice.Polymorphism.TransportCompany.AbstractEntities;

namespace NETPractice.Polymorphism.TransportCompany.InheritedEntities
{
    public class Helicopter : AirTransport
    {
        public override string ToString()
            => "Type: helicopter" + base.ToString();
    }
    
}

using NETPractice.Polymorphism.TransportCompany.AbstractEntities;

namespace NETPractice.Polymorphism.TransportCompany.InheritedEntities
{
    public class Plane : AirTransport
    {
        public override string ToString()
            => "Type: plane" + base.ToString();
    }
    
}

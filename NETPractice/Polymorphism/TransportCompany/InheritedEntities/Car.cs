using NETPractice.Polymorphism.TransportCompany.AbstractEntities;

namespace NETPractice.Polymorphism.TransportCompany.InheritedEntities
{
    public class Car : SurfaceTransport
    {
        public override string ToString()
            => "Type: car\n" + base.ToString();
    }
    
}

using NETPractice.Polymorphism.TransportCompany.AbstractEntities;

namespace NETPractice.Polymorphism.TransportCompany.InheritedEntities
{
    public class Train : SurfaceTransport
    {
        public override string ToString()
            => "Type: train" + base.ToString();
    }
    
}

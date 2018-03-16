using NETPractice.Polymorphism.TransportCompany.AbstractEntities;

namespace NETPractice.Polymorphism.TransportCompany.InheritedEntities
{
    public class Liner : WaterTransport
    {
        public override string ToString()
            => "Type: liner" + base.ToString();
    }
    
}

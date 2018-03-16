using NETPractice.Polymorphism.ITCompany.Entities;

namespace NETPractice.Polymorphism.ITCompany.AbstractEntities
{
    public class Tester : Employee
    {
        public Code findBugs(Code code)
        {
            return new Code();
        }
        
    }
    
}

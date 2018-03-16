using NETPractice.Polymorphism.ITCompany.Entities;

namespace NETPractice.Polymorphism.ITCompany.AbstractEntities
{
    public class Developer : Employee
    {
        public Code writeCode()
        {
            return new Code();
        }

        public Code fix(Code code)
        {
            return new Code();
        }

        private void fixBug(Bug bug)
        {
            
        }
        
    }
    
}

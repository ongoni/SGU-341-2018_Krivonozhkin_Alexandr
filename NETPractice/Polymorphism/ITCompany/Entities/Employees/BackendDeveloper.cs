using NETPractice.Polymorphism.ITCompany.Entities.Code;

namespace NETPractice.Polymorphism.ITCompany.Entities.Employees
{
    public class BackendDeveloper : Developer
    {
        public override ProgrammingCode WriteCode()
        {
            return new BackendProgrammingCode();
        }
        
    }
    
}

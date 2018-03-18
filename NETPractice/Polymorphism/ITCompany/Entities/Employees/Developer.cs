using NETPractice.Polymorphism.ITCompany.Entities.Bugs;
using NETPractice.Polymorphism.ITCompany.Entities.Code;

namespace NETPractice.Polymorphism.ITCompany.Entities.Employees
{
    public abstract class Developer : Employee
    {
        public abstract ProgrammingCode WriteCode();

        public void Fix(ProgrammingCode code)
        {
            foreach (Bug bug in code.Bugs)
            {
                bug.IsFixed = true;
            }
        }

    }
    
}

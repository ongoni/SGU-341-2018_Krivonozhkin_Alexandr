using NETPractice.Polymorphism.ITCompany.Entities.Bugs;
using NETPractice.Polymorphism.ITCompany.Entities.Code;

namespace NETPractice.Polymorphism.ITCompany.Entities.Employees
{
    public abstract class Tester : Employee
    {
        public void FindBugs(ProgrammingCode сode)
        {
            сode.Bugs.Add(new CriticalBug());
            сode.Bugs.Add(new MajorBug());
            сode.Bugs.Add(new MinorBug());
        }

    }
    
}

using System;
using NETPractice.Polymorphism.ITCompany.Entities.Code;

namespace NETPractice.Polymorphism.ITCompany.Entities.Employees
{
    public class FrontendDeveloper : Developer
    {
        public FrontendDeveloper() { }

        public FrontendDeveloper(string name, string level, DateTime startWorkingDate)
        {
            Name = name;
            Level = level;
            StartWorkingDate = startWorkingDate;
        }
        
        public override ProgrammingCode WriteCode()
        {
            return new FrontendProgrammingCode();
        }
        
    }
    
}

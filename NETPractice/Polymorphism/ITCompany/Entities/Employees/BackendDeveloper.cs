using System;
using NETPractice.Polymorphism.ITCompany.Entities.Code;

namespace NETPractice.Polymorphism.ITCompany.Entities.Employees
{
    public class BackendDeveloper : Developer
    {
        public BackendDeveloper() { }

        public BackendDeveloper(string name, string level, DateTime startWorkingDate)
        {
            Name = name;
            Level = level;
            StartWorkingDate = startWorkingDate;
        }
        
        public override ProgrammingCode WriteCode()
        {
            return new BackendProgrammingCode();
        }
        
    }
    
}

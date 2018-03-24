using System;

namespace NETPractice.Polymorphism.ITCompany.Entities.Employees
{
    public class AutomatedTestingTester : Tester
    {
        public AutomatedTestingTester() { }

        public AutomatedTestingTester(string name, string level, DateTime startWorkingDate)
        {
            Name = name;
            Level = level;
            StartWorkingDate = startWorkingDate;
        }
    }
    
}

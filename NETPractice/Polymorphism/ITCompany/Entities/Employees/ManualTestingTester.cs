using System;

namespace NETPractice.Polymorphism.ITCompany.Entities.Employees
{
    public class ManualTestingTester : Tester
    {
        public ManualTestingTester() { }

        public ManualTestingTester(string name, string level, DateTime startWorkingDate)
        {
            Name = name;
            Level = level;
            StartWorkingDate = startWorkingDate;
        }
    }
    
}

using System;
using NETPractice.Polymorphism.ITCompany.Entities;

namespace NETPractice.Polymorphism.ITCompany.AbstractEntities
{
    public abstract class Employee
    {
        protected string[] AllowedLevels = {
            "junior", 
            "developer", 
            "senior", 
            "lead",
        };
        
        public TimeSpan Experience { get; set; }
        public string Level { get; set; }

        public void doJob()
        {
            
        }

        public void getPaid(Salary salary)
        {
            
        }
        
    }
    
}

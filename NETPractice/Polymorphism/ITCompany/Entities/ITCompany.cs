using System.Collections.Generic;
using NETPractice.Polymorphism.ITCompany.AbstractEntities;

namespace NETPractice.Polymorphism.ITCompany.Entities
{
    public class ITCompany
    {
//        private List<Employee> _employees;
//        private List<Project> _projects;
        
        public List<Employee> Employees { get; set; }
        public List<Project> Projects { get; set; }

        private void payTo(Employee employee)
        {
            
        }
        
    }
    
}

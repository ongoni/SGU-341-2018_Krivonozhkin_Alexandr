using System.Collections.Generic;
using NETPractice.Polymorphism.ITCompany.AbstractEntities;

namespace NETPractice.Polymorphism.ITCompany.Entities
{
    public class Project
    {
//        private List<Employee> _employees;
        
        public string Name { get; set; }
        public Customer Customer { get; set; }
        public List<Employee> Employees { get; set; }
    }
    
}

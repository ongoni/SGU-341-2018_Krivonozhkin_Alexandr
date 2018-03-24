using System.Collections.Generic;
using System.IO;
using System.Linq;
using NETPractice.Polymorphism.ITCompany.Entities;
using NETPractice.Polymorphism.ITCompany.Entities.Employees;

namespace NETPractice.Polymorphism.ITCompany.Logic
{
    public static class ITCompanyDataHolder
    {
        private static List<Employee> _employees;
        private static List<Project> _projects;

        static ITCompanyDataHolder()
        {
            Employees = new List<Employee>();
            Projects = new List<Project>();
        }
        
        public static List<Employee> Employees
        {
            get => _employees;
            private set
            {
                if (value == null || value.Any(x => x == null))
                {
                    throw new InvalidDataException("list must contain employees");
                }

                _employees = value;
            }
        }

        public static List<Project> Projects
        {
            get => _projects;
            private set
            {
                if (value == null || value.Any(x => x == null))
                {
                    throw new InvalidDataException("list must contain projects");
                }

                _projects = value;
            }
        }
        
    }
    
}

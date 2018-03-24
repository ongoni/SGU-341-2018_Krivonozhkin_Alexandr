using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NETPractice.Polymorphism.ITCompany.Entities.Code;
using NETPractice.Polymorphism.ITCompany.Entities.Employees;

namespace NETPractice.Polymorphism.ITCompany.Entities
{
    public class Project
    {
        private List<Developer> _developers;
        private List<Tester> _testers;
        private List<ProgrammingCode> _code;
        private string _name;
        private Customer _customer;

        public Project()
        {
            Developers = new List<Developer>();
            Testers = new List<Tester>();
            Code = new List<ProgrammingCode>();
        }

        public Project(string name, Customer customer)
        {
            Developers = new List<Developer>();
            Testers = new List<Tester>();
            Code = new List<ProgrammingCode>();
            Name = name;
            Customer = customer;
        }
        
        public Project(string name, Customer customer, List<Developer> developers, List<Tester> testers)
        {
            Code = new List<ProgrammingCode>();
            Name = name;
            Customer = customer;
            Developers = developers;
            Testers = testers;
        }

        #region Properties

        public string Name
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("name can't be null or empty");
                }

                _name = value;
            }
        }

        public Customer Customer
        {
            get => _customer;
            set
            {
                if (value == null)
                {
                    throw new InvalidDataException("customer can't be null");
                }

                _customer = value;
            }
        }

        public List<Developer> Developers
        {
            get => _developers;
            set
            {
                if (value == null || value.Any(x => x == null))
                {
                    throw new InvalidDataException("list must contain developers");
                }

                _developers = value;
            }
        }
        
        public List<Tester> Testers
        {
            get => _testers;
            private set
            {
                if (value == null || value.Any(x => x == null))
                {
                    throw new InvalidDataException("list must contain testers");
                }

                _testers = value;
            }
        }
        
        public List<ProgrammingCode> Code
        {
            get => _code;
            set
            {
                if (value == null || value.Any(x => x == null))
                {
                    throw new InvalidDataException("list must contain code");
                }

                _code = value;
            }
        }

        #endregion
        
    }
    
}

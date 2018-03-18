using System;
using System.IO;

namespace NETPractice.Polymorphism.ITCompany.Entities.Employees
{
    public abstract class Employee
    {
        private string _name;
        private string _level;

        public Employee() { }

        public Employee(string name, string level, DateTime startWorkingDate)
        {
            Name = name;
            Level = level;
            StartWorkingDate = startWorkingDate;
        }
        
        public DateTime StartWorkingDate { get; }
        
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

        public string Level
        {
            get => _level;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("level can't be null or empty");
                }

                _level = value;
            }
        }

        public TimeSpan GetExperience()
        {
            return DateTime.Now - StartWorkingDate;
        }
        
        public void GetPaid(Salary salary)
        {
            Console.WriteLine($"{Name} got his salary - {salary.Wage}");
        }

    }
    
}

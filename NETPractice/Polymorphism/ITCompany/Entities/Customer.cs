using System;
using System.IO;

namespace NETPractice.Polymorphism.ITCompany.Entities
{
    public class Customer
    {
        private string _name;

        public Customer() { }

        public Customer(string name)
        {
            Name = name;
        }
        
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
    }
    
}

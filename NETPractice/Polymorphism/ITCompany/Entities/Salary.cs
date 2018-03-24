using System.IO;

namespace NETPractice.Polymorphism.ITCompany.Entities
{
    public class Salary
    {
        private double _wage;
        
        public Salary() { }
        
        public Salary(double wage)
        {
            Wage = wage;
        }
        
        public double Wage
        {
            get => _wage;
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("wage can't be negative or zero");
                }

                _wage = value;
            }
        }
        
    }
    
}

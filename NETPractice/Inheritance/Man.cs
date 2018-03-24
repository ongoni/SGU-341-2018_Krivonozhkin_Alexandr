using System;
using System.IO;

namespace NETPractice.Inheritance
{
    public class Man
    {
        private string _name;
        private int _age;
        private double _weight;
        private double _height;
        
        public Man() { }

        public Man(string name, int age, double weight, double height, DateTime birthDate)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            BirthDate = birthDate;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("empty string given");
                }

                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("age can't be negative or 0");
                }

                _age = value;
            }
        }
        
        public double Weight
        {
            get => _weight;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("weight can't be negative or 0");
                }

                _weight = value;
            }
        }

        public double Height
        {
            get => _height;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("height can't be negative or 0");
                }

                _height = value;
            }
        }

        public DateTime BirthDate { get; set; }
        
    }
    
}

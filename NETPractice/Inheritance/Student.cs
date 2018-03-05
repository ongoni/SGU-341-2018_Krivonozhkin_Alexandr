using System;
using System.IO;

namespace NETPractice.Inheritance
{
    public sealed class Student : Man
    {
        private DateTime _educationStartDate;
        private int _courseNumber;
        private string _groupNumber;

        public Student() { }

        public Student(string name, int age, double weight, double height, DateTime birthDate) 
            : base(name, age, weight, height, birthDate)
        { }
        
        public Student(string name, int age, double weight, double height, DateTime birthDate, 
            DateTime educationStartDate, int courseNumber, string groupNumber) 
            : base(name, age, weight, height, birthDate)
        {
            EducationStartDate = educationStartDate;
            CourseNumber = courseNumber;
            GroupNumber = groupNumber;
        }

        public DateTime EducationStartDate
        {
            get => _educationStartDate;
            set
            {
                if (value.Date >= BirthDate.Date)
                {
                    throw new InvalidDataException("education start date can't be before the birth date");
                }

                _educationStartDate = value;
            }
        }

        public int CourseNumber
        {
            get => _courseNumber;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("course number can't be negative or 0");
                }

                _courseNumber = value;
            }
        }

        public string GroupNumber
        {
            get => _groupNumber;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("empty string given");
                }

                _groupNumber = value;
            }
        }

    }
    
}

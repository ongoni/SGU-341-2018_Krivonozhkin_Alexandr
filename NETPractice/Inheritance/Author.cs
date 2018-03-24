using System;
using System.IO;

namespace NETPractice.Inheritance
{
    public class Author
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;

        public Author() { }

        public Author(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("empty string given");
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("empty string given");
                }

                _lastName = value;
            }
        }

        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (value.Date >= DateTime.Now.Date)
                {
                    throw new InvalidDataException("birth date can't be in future ");
                }

                _birthDate = value;
            }
        }
        
    }
    
}

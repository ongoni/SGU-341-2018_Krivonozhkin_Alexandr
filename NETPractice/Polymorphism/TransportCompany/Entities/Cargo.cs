using System;
using System.IO;

namespace NETPractice.Polymorphism.TransportCompany.Entities
{
    public class Cargo
    {
        private string _content;
        private double _weight;

        #region Properties
        
        public bool IsDelivered { get; set; }
        
        public string Content
        {
            get => _content;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("content can't be null or empty");
                }

                _content = value;
            }
        }

        public double Weight
        {
            get => _weight;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("weight can't be negative or zero");
                }

                _weight = value;
            }
        }

        #endregion
    }
    
}

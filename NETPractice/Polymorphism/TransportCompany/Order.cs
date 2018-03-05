using System;
using System.IO;

namespace NETPractice.Polymorphism.TransportCompany
{
    public class Order
    {
        private Cargo _cargo;
        private string _destinationAddress;

        public Order() { }

        public Order(Cargo cargo, string destinationAddress)
        {
            Cargo = cargo;
            DestinationAddress = destinationAddress;
        }

        public Cargo Cargo
        {
            get => _cargo;
            set
            {
                if (value == null)
                {
                    throw new InvalidDataException("cargo can't be null");
                }

                _cargo = value;
            }
        }
        
        public string DestinationAddress
        {
            get => _destinationAddress;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("empty string given");
                }

                _destinationAddress = value;
            }
        }
        
        public bool IsDelivered { get; set; }
        
    }
    
}

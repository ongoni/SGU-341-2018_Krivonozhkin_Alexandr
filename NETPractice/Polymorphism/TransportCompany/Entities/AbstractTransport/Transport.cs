using System;
using System.IO;

namespace NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport
{
    public abstract class Transport
    {
        private double _speed;
        private double _elevatingCapacity;
        private string _brand;
        private int _staffCount;
        private int _passengerCount;

        #region Properties
        
        public double Speed
        {
            get => _speed;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("speed can't be negative or zero");
                }

                _speed = value;
            }
        }

        public double ElevatingCapacity
        {
            get => _elevatingCapacity;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("elevating capacity can't be negative or zero");
                }

                _elevatingCapacity = value;
            }
        }

        public string Brand
        {
            get => _brand;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("brand can't be null or empty");
                }

                _brand = value;
            }
        }

        public int StaffCount
        {
            get => _staffCount;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("staff count can't be negative or zero");
                }

                _staffCount = value;
            }
        }

        public int PassengerCount
        {
            get => _passengerCount;
            set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("passenger count can't be negative or zero");
                }

                _passengerCount = value;
            }
        }
        
        #endregion
        
        public string Deliver(Cargo cargo) => "Delivering " + cargo.Content;
        
        public override string ToString()
            => "Speed: " + Speed + Environment.NewLine 
               + "Capacity: "+ ElevatingCapacity + Environment.NewLine 
               + "Brand: " + Brand + Environment.NewLine 
               + "Staff count: " + StaffCount + Environment.NewLine 
               + "Passenger count: " + PassengerCount;

    }
}

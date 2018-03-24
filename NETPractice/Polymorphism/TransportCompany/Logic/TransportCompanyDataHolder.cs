using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using NETPractice.Polymorphism.TransportCompany.Entities;
using NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.Logic
{
    public static class TransportCompanyDataHolder
    {
        private static List<Transport> _companyTransport;
        private static List<Order> _orders;
        
        static TransportCompanyDataHolder()
        {
            _companyTransport = new List<Transport>();
            _orders = new List<Order>();
        }
        
        public static List<Transport> CompanyTransport
        {
            get => _companyTransport; 
            set
            {
                if (value == null || value.Any(x => x == null))
                {
                    throw new InvalidDataException("list must contain points");
                }

                _companyTransport = value;
            }
        }

        public static List<Order> Orders
        {
            get => _orders;
            private set
            {
                if (value == null || value.Any(x => x == null))
                {
                    throw new InvalidDataException("list must contain points");
                }

                _orders = value;
            }
        }

        public static void Add(Transport transport)
        {
            if (transport == null)
            {
                throw new InvalidDataException("transport can't be null");
            }
            
            CompanyTransport.Add(transport);
            
            CompanyTransport.Sort(
                (x, y) => x.ElevatingCapacity.CompareTo(y.ElevatingCapacity)
            );
        }

        public static void Add(Order order)
        {
            if (order == null)
            {
                throw new InvalidDataException("order can't be null");
            }
            
            Orders.Add(order);
        }
        
    }
    
}

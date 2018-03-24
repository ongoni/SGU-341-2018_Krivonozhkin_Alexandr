using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            private set
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
        
    }
    
}

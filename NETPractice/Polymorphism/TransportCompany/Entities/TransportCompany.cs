using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NETPractice.Polymorphism.TransportCompany.AbstractEntities;
using NETPractice.Polymorphism.TransportCompany.Exceptions;

namespace NETPractice.Polymorphism.TransportCompany.Entities
{
    public class TransportCompany
    {
        private List<Transport> _companyTransport;
        private List<Order> _orders;

        public TransportCompany()
        {
            _companyTransport = new List<Transport>();
            _orders = new List<Order>();
        }

        public List<Transport> CompanyTransport
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

        public List<Order> Orders
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

        public TransportCompany(List<Transport> transportList)
        {
            CompanyTransport = transportList;
        }

        public void Add(Transport transport)
        {
            if (transport == null)
            {
                throw new InvalidDataException("transport can't be null");
            }

            _companyTransport.Add(transport);
        }

        public string Accept(Order order)
        {
            if (order == null)
            {
                throw new InvalidDataException("order can't be null");
            }
            
            _orders.Add(order);

            Transport transport;
            try
            {
                transport = _companyTransport
                    .First(x => x.ElevatingCapacity >= order.Cargo.Weight);
            }
            catch (Exception e)
            {
                throw new NoSuitableTransportFoundException();
            }

            return transport.Deliver(order.Cargo);
        }

    }
    
}

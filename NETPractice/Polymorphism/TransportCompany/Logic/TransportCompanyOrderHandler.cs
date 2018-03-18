using System;
using System.IO;
using System.Linq;
using NETPractice.Polymorphism.TransportCompany.Entities;
using NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport;
using NETPractice.Polymorphism.TransportCompany.Exceptions;

namespace NETPractice.Polymorphism.TransportCompany.Logic
{
    public class TransportCompanyOrderHandler
    {
        public string Accept(Order order)
        {
            if (order == null)
            {
                throw new InvalidDataException("order can't be null");
            }
            
            TransportCompanyDataHolder.Orders.Add(order);

            Transport transport;
            try
            {
                transport = TransportCompanyDataHolder.CompanyTransport
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

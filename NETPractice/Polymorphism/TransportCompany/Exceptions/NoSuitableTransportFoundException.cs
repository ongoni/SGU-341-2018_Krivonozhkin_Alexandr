using System;

namespace NETPractice.Polymorphism.TransportCompany.Exceptions
{
    public class NoSuitableTransportFoundException : Exception
    {
        public NoSuitableTransportFoundException() { }
        
        public NoSuitableTransportFoundException(string message) : base(message) { }
    }
    
}

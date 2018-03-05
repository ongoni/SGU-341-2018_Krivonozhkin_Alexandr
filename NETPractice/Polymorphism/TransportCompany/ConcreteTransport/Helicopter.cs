﻿using NETPractice.Polymorphism.TransportCompany.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.ConcreteTransport
{
    public class Helicopter : AirTransport
    {
        public override string ToString()
            => "Type: helicopter" + base.ToString();
    }
    
}

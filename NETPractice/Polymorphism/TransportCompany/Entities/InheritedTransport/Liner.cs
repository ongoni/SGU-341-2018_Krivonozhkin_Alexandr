﻿using System;
using NETPractice.Polymorphism.TransportCompany.Entities.AbstractTransport;

namespace NETPractice.Polymorphism.TransportCompany.Entities.InheritedTransport
{
    public class Liner : WaterTransport
    {
        public override string ToString()
            => "Type: liner" + Environment.NewLine + base.ToString();
    }
    
}

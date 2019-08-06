﻿using OpenClosedPrinciple_Museum_TemplateMethod_Penta.Logic.Strategies;

namespace OpenClosedPrinciple_Museum_TemplateMethod_Penta.Logic
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public ITicketStrategy TicketStrategy { get; private set; }

        public Person(string name, int age, ITicketStrategy ticketStrategy)
        {
            Name = name;
            Age = age;
            TicketStrategy = ticketStrategy;
        }
    }
}

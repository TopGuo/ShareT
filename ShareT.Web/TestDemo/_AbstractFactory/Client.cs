using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareT.Web.TestDemo._AbstractFactory
{
    public class Client
    {
        public AbstractProductA abstractProductA;
        public AbstractProductB abstractProductB;

        public Client(AbstractFactory abstractFactory)
        {
            abstractProductA = abstractFactory.CreateProductA();
            abstractProductB = abstractFactory.CreateProductB();
        }

        public void Run()
        {
            abstractProductA.Interact(abstractProductB);
            abstractProductB.Interact(abstractProductA);
        }
    }
}

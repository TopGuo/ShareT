using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareT.Web.TestDemo._AbstractFactory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB();
        }
    }
}

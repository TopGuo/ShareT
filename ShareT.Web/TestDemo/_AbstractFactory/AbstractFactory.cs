using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareT.Web.TestDemo._AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}

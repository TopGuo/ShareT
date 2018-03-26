using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareT.Web.TestDemo._AbstractFactory
{
    public class ProductA : AbstractProductA
    {
        public override void Interact(AbstractProductB b)
        {
            Console.WriteLine(this.GetType().Name + "interact with" + b.GetType().Name);
        }
    }
}

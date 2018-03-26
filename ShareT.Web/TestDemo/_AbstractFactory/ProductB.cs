using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareT.Web.TestDemo._AbstractFactory
{
    public class ProductB : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + "interact with" + a.GetType().Name);
        }
    }
}

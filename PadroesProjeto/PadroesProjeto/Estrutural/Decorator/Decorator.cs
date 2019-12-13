using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Decorator
{
    public class Decorator : Pizza
    {
        protected Pizza _pizza;


        public Decorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override void ValorTotal()
        {
            _pizza.ValorTotal();
        }
    }
}

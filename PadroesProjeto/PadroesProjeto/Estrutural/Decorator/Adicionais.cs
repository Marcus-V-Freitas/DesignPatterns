using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Decorator
{
    public class Adicionais : Decorator
    {
        public Adicionais(Pizza pizza) : base(pizza)
        {
        }

        public override void ValorTotal()
        {
            base.ValorTotal();
        }

        public void Chocolate()
        {
            _pizza.Attach("Chocolate 15,00");
        }

        public void Calabresa()
        {
            _pizza.Attach("Calabresa 10,00");
        }
    }
}

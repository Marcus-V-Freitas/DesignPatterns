using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Decorator
{
    public class PizzaQueijo : Pizza
    {
       
        public PizzaQueijo()
        {
            _nome = "Queijo";
            _preco = 15.0;
        }

        public override void ValorTotal()
        {
            if (_adicionais.Count > 0)
            {
                Console.WriteLine("Adicionais:");
                Console.WriteLine("--------------");
                foreach (var item in _adicionais)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("--------------");
            }
            Console.WriteLine($"Pizza: {_nome} Preço: {_preco.ToString("C")}"); 
        }
    }
}

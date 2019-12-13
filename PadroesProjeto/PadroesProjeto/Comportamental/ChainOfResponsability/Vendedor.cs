using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.ChainOfResponsability
{
    public class Vendedor : Aprovador
    {
        public override bool Desconto(double valor)
        {
            if (valor < 5)
            {
                Console.WriteLine($"Vendedor conseguiu: {valor}");
                return true;
            }
            else
            {
                Console.WriteLine($"Vendedor não conseguiu: {valor}");
                if (_aprovador != null)
                {
                    _aprovador.Desconto(valor);
                }

               
                return false;
               
            }
        }
    }
}

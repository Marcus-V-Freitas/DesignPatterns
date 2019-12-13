using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.ChainOfResponsability
{
    public class Gerente : Aprovador
    {
        public override bool Desconto(double valor)
        {
            if (valor < 10)
            {
                Console.WriteLine($"Gerente conseguiu: {valor}");
                return true;
            }
            else
            {
                Console.WriteLine($"Gerente não conseguiu: {valor}");
                if (_aprovador != null)
                {
                    _aprovador.Desconto(valor);
                }
                
                return false;
            }
        }
    }
}

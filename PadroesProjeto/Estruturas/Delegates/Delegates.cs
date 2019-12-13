using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Estruturas.Delegates
{
    public class Delegates
    {

        public delegate double FecharNotify(double valor, double juros);

        public class Pedido
        {
            public event FecharNotify Fechar;

            public void Pagar(double valor, double juros)
            {
                
                Console.WriteLine($"Total: {Fechar(valor, juros)}");
            }
        }

        public static double Fechamento(double valor, double juros)
        {
            return (valor+=(valor*juros));
        }

       
    }
}

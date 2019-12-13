using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.AbstractFactory
{
    public class SqlCommand : Command
    {
        public override void Executar()
        {
            Console.WriteLine("Execução SQL");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.AbstractFactory
{
    public class SqlConnection : Connection
    {
        public override void Conectar()
        {
            Console.WriteLine("Conexao SQL");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.FactoryMethod
{
    public class GoogleAutenticacao : Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Google Autenticacao");
        }
    }
}

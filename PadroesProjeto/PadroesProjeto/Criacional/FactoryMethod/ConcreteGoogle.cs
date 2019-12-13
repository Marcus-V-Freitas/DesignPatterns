using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.FactoryMethod
{
    public class ConcreteGoogle : AbstractFactoryMethod
    {
        public override Autenticacao GetAutenticacao()
        {
            return new GoogleAutenticacao();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.AbstractFactory
{
   public abstract class AbstractFactory
    {
        public abstract Connection GetConnection();
        public abstract Command GetCommand();
    }
}

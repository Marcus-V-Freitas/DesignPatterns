using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Strategy
{
    public abstract class AbstractStrategy
    {
        public abstract void Method(ref List<string> Nomes);
    }
}

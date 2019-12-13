using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Strategy
{
    public class StrategyReverse : AbstractStrategy
    {
        public override void Method(ref List<string> Nomes)
        {
            Nomes.Reverse();
        }
    }
}

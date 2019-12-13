using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Proxy
{
    public class CalcSoma : ICalc
    {
        public override int Calc(int x, int y)
        {
           return x + y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Proxy
{
    public class CalcProxy : ICalc
    {

        private ICalc _calc;

            public void setCalcProxy(ICalc calc)
        {
            _calc = calc;
        }

        public override int Calc(int x, int y)
        {
            if (x < 0 || y < 0)
                return 0;
            return _calc.Calc(x, y);
        }
       
    }
}

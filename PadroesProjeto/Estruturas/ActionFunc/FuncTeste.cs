using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Estruturas.ActionFunc
{
   public class FuncTeste
    {
        public Func<int, int, int> func = Soma; 


        static int Soma(int x, int y)
        {
            return x + y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Estruturas.ActionFunc
{
    public class ActionTeste
    {
        public Action<int, int> action = Soma;


        static void Soma(int x,int y)
        {
            Console.WriteLine(x+y);
        }
    }
}

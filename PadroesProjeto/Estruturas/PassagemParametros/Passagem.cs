using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Estruturas.PassagemParametros
{
    public class Passagem
    {
        public int Out(out int x) {
            x=1;
            x += 3;
            return x;
        }

        public int Ref(ref int x)
        {
            x += 3;
            return x;
        }

        public int In(in int x)
        {
            return x+10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Estruturas.MetodoExtensao
{
    public static class MetodoExtensao
    {
        public static void URL(this string url)
        {
            Console.WriteLine("Http:"+url);
        }
    }
}

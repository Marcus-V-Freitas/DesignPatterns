using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Adapter
{
    public class Target
    {
        public virtual void Request(string path)
        {
            Console.WriteLine("Tomada Simples"+ path);  
        }
    }
}

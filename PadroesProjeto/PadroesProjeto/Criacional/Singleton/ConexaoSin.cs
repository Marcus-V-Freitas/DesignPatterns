using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.Singleton
{
    public class ConexaoSin
    {
        private static readonly ConexaoSin _instance=new ConexaoSin();
        private int count=0;

        public static ConexaoSin Instance
        {

            get { return _instance; }
        }

        private ConexaoSin() {  }
        
        public void Count()
        {
            ++count;
            Console.WriteLine($"Conexao:"+ count); 
        }
    }
}

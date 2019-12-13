using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Estruturas.WriterReader
{
    public class WriterReader
    {
        public void Executar() {
            var sw = new StringWriter();
            
                     

            sw.WriteLine("Linha um");
            sw.WriteLine("Linha dois");
            

            string linha = null;
            string msg = null;

            var sr = new StringReader(sw.ToString());

            while (true)
            {
                linha = sr.ReadLine();
                if (linha == null)
                {
                    break;
                }
                else
                {
                    msg =msg+ linha + Environment.NewLine;
                }
            }

            Console.WriteLine(msg);


            }
        
        
        
    }
}

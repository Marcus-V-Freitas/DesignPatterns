using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Estruturas.Arquivos
{
    public class Arquivos
    {
        public void LerArquivo(string filename)
        {
            StreamReader sr = new StreamReader(filename);

            StringBuilder sb = new StringBuilder();

            string str = "";

            while ((str = sr.ReadLine()) != null){

                sb.AppendLine(str);

            }

            Console.WriteLine(sb.ToString());
        }

        public void SalvarArquivo(string filename,string texto)
        {
            StreamWriter sw = null;
            try
            {
                if (!File.Exists(filename))
                {
                    sw = File.CreateText(filename);
                    sw.Write(texto);

                }
                else
                {
                    sw = File.AppendText(filename);
                    sw.WriteLine(texto);

                }
            } catch(IOException e)
            {
                TextWriterTraceListener txt = new TextWriterTraceListener("log.txt");
                Debug.Listeners.Add(txt);
                Debug.WriteLine(" "+e.Message);
                Debug.Flush();
            }
            finally
            {
                sw.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Adapter
{
    public class Adaptee
    {
        public void SpecificRequest(string path)
        {
            if (!File.Exists(path))
            {
                StreamWriter writer = File.CreateText(path);
                writer.Close();
            }

            TextWriterTraceListener txt = new TextWriterTraceListener(path);
            Debug.Listeners.Add(txt);
            Debug.WriteLine("Ola Mundo");
            Debug.Flush();
            Console.WriteLine("Tomada completa"+path);
        }
    }
}

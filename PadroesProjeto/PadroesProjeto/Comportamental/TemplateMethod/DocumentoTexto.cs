using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.TemplateMethod
{
    public class DocumentoTexto : AbtractTemplate
    {
        public override void Documentar()
        {
            Console.WriteLine("Documentando...");
        }

        public override void Finalizar()
        {
            Console.WriteLine("Finalizando...");
        }

        public override void Iniciar()
        {
            Console.WriteLine("Iniciando...");
        }
    }
}

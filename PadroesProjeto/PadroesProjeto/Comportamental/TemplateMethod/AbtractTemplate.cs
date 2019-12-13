using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.TemplateMethod
{
    public abstract class AbtractTemplate
    {
        public void TemplateMethod()
        {
            Iniciar();
            Documentar();
            Finalizar();
        }

        public abstract void Iniciar();
        public abstract void Documentar();
        public abstract void Finalizar();
    }
}

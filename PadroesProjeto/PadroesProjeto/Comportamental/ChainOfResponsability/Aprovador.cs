using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.ChainOfResponsability
{
    public abstract class Aprovador
    {
        protected Aprovador _aprovador;

        public void setAprovador(Aprovador aprovador)
        {
            _aprovador = aprovador;
        }

        public abstract bool Desconto(double valor);
    }
}

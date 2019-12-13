using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.State
{
   public abstract class AbstractConnection
    {
        public abstract bool Handler(ContextState contextState, bool state);
    }
}

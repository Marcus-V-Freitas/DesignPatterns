using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.State
{
    public class CloseConnection : AbstractConnection
    {
        public override bool Handler(ContextState contextState, bool state)
        {
            if (!state)
            {
                contextState.setConnection(new OpenConnection());
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.State
{
    public class OpenConnection : AbstractConnection
    {
        public override bool Handler(ContextState contextState, bool state)
        {
            if (state)
            {
                contextState.setConnection(new CloseConnection());
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

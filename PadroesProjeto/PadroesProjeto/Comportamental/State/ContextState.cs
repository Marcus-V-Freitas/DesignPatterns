using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.State
{
    public class ContextState
    {
        private bool IsConnected = false;
        private AbstractConnection _connection;

        public void setConnection(AbstractConnection connection)
        {
            _connection = connection;
            Request();
        }
        
        public void Request()
        {
            IsConnected = _connection.Handler(this, IsConnected);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"State Type: {_connection.GetType().Name}");
            sb.AppendLine($"IsConnection: {IsConnected}");
            return sb.ToString();
        }

    }
}

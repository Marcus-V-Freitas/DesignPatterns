using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Command
{
    public class ConcreteCommand : Command
    {
        private Server _server;

        public ConcreteCommand(Server server)
        {
            _server = server;
        }


        public override void Execute()
        {
            _server.Entrar();
        }
    }
}

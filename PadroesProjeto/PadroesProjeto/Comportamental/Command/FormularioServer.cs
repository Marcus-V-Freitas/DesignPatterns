using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Command
{
   public class FormularioServer
    {
        private Command _command;

        public void setCommand(Command command)
        {
            _command = command;
        }

        public void ClickEntrar()
        {
            _command.Execute();
        }
    }
}

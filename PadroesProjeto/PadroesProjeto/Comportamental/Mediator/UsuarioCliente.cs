using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Mediator
{
    public class UsuarioCliente : Colleague
    {
        public UsuarioCliente(AbstractMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Usuario recebeu: "+message);
        }

        public override void Send(string message)
        {
            _mediator.Send(message, this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Mediator
{
    public class Suporte : Colleague
    {
        public Suporte(AbstractMediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Suporte recebeu: "+message);
        }

        public override void Send(string message)
        {
            _mediator.Send(message, this);
        }
    }
}

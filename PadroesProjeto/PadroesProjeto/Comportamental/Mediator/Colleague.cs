using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Mediator
{
    public abstract class Colleague
    {
        protected AbstractMediator _mediator;

        public Colleague(AbstractMediator mediator)
        {
            _mediator = mediator;
        }


        public abstract void Send(string message);

        public abstract void Notify(string message);
    }
}

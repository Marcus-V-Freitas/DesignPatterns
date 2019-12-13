using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Mediator
{
    public abstract class AbstractMediator
    {
        protected List<Colleague> _colleagues = new List<Colleague>();

        public void Attach(Colleague colleague)
        {
            _colleagues.Add(colleague);
        }

        public void Dettach(Colleague colleague)
        {
            _colleagues.Remove(colleague);
        }

        public abstract void Send(string message, Colleague colleague);
    }
}

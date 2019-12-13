using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Mediator
{
    public class ConcreteMediator : AbstractMediator
    {
        
        public override void Send(string message, Colleague colleague)
        {
            foreach (var item in _colleagues)
            {
                if (!colleague.Equals(item))
                {
                    item.Notify(message);
                }
            }
        }
    }
}

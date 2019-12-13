using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Visitor
{
    public class ObjectGuard
    {
        private List<AbstractElement> elements = new List<AbstractElement>();

        public void Attach(AbstractElement element)
        {
            elements.Add(element);
        }

        public void Dettach(AbstractElement element)
        {
            elements.Remove(element);
        }

        public void Notify(AbstractVisitor visitor)
        {
            elements.ForEach(element => element.Accept(visitor));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Visitor
{
    public class ConcreteElement1 : AbstractElement
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.VisitConcreteElement1(this);
        }
    }
}

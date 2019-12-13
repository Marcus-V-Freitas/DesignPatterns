using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Visitor
{
    public abstract class AbstractVisitor
    {
        public abstract void VisitConcreteElement1(ConcreteElement1 concreteElement1);
        public abstract void VisitConcreteElement2(ConcreteElement2 concreteElement2);
    }
}

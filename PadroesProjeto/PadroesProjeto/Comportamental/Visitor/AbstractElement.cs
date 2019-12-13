using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Visitor
{
    public abstract class AbstractElement
    {
        public abstract void Accept(AbstractVisitor visitor);
    }
}

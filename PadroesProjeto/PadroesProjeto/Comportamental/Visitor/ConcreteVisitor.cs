using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Visitor
{
    public class ConcreteVisitor : AbstractVisitor
    {
        public override void VisitConcreteElement1(ConcreteElement1 concreteElement1)
        {
            Console.WriteLine($"{concreteElement1.GetType().Name} visitado por {GetType().Name}");
        }

        public override void VisitConcreteElement2(ConcreteElement2 concreteElement2)
        {
            Console.WriteLine($"{concreteElement2.GetType().Name} visitado por {GetType().Name}");
        }
    }
}

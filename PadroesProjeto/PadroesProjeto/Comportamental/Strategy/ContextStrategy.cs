using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Strategy
{
    public class ContextStrategy
    {
        private AbstractStrategy _abstractStrategy;

        public void setStrategy(AbstractStrategy abstractStrategy)
        {
            _abstractStrategy = abstractStrategy;
        }

        public void Ordernar(List<string> lista)
        {
            _abstractStrategy.Method(ref lista);
        }
    }
}

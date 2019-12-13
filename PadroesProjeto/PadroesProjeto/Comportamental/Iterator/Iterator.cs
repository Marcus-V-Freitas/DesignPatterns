using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Iterator
{
    public abstract class Iterator
    {
        public abstract object CurrentItem();
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
    }
}

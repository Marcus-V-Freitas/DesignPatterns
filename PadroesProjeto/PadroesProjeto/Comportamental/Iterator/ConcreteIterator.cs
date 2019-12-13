using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Iterator
{
   public class ConcreteIterator:Iterator
    {

        private Empresa _subject;
        private int index = 0;

        public ConcreteIterator(Empresa subject)
        {
            _subject = subject;
            _subject[0] = new Funcionario(1, "Maria");
            _subject[1] = new Funcionario(2, "Jorge");

        }

        public override object CurrentItem()
        {
            return _subject[index];

        }

        public override object First()
        {
            return _subject[0];
        }

        public override bool IsDone()
        {
            return (index >= _subject.Count()) ? true : false;
        }

        public override object Next()
        {
            index += 1;
            if (!IsDone())
            {
              
                return _subject[index];
            }
            else
            {
                return null;
            }
        }
    }
}

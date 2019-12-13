using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Iterator
{
    public class Empresa : Subject
    {

        private List<Funcionario> _funcionarios = new List<Funcionario>();


        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get { return _funcionarios[index]; }
            set { _funcionarios.Insert(index, value as Funcionario); }
        }

        public int Count()
        {
            return _funcionarios.Count;
        }

        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Memento
{
    public class CareTaker
    {
        List<Memento> _mementos = new List<Memento>();

        public void Add(Pessoa pessoa)
        {
            _mementos.Add(pessoa.CreateMemento());
        }

        public void Recovery(Pessoa pessoa, int index)
        {
            pessoa.Restore(_mementos[index]);

        }
    }
}

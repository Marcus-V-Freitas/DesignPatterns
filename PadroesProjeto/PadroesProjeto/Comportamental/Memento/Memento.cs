using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Memento
{
    public class Memento
    {
        public Memento(Pessoa pessoa)
        {
            Pessoa = pessoa;
        }

        public Pessoa Pessoa { get; set; }
    }
}

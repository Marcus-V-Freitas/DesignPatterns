using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Composite
{
    public abstract class Component
    {
        protected string _nome;

        public Component(string nome)
        {
            _nome = nome;
        }

        public abstract void Show();

    
    }
}

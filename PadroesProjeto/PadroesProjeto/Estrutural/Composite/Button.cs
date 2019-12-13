using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Composite
{
    public class Button : Component
    {
        public Button(string nome) : base(nome)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"Nome: {_nome}");
        }
    }
}

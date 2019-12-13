using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Bridger
{
    public class Retangulo : Forma
    {
        public Retangulo(string nome) : base(nome)
        {
        }

        public override void DesenharForma()
        {
            Console.WriteLine($"Nome: {_nome} Cor: {Cor.Colorir()}");
        }
    }
}

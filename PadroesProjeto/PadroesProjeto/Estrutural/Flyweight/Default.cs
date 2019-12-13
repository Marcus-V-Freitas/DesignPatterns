using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Flyweight
{
    public class Default : Character
    {
        public Default(string nome, double saude) : base(nome, saude)
        {
        }

        public override void Golpe(int dano)
        {
            Console.WriteLine($"Saude total de {_nome}: {_saude-dano}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Flyweight
{
    public class Boss : Character
    {
        private double bonusSaude = 1000;

        public Boss(string nome, double saude):base(nome,saude)
        {
           
        }

        public override void Golpe(int dano)
        {
            Console.WriteLine($"Saude total de {_nome}: {((_saude+bonusSaude) - dano)}");
        }
    }
}

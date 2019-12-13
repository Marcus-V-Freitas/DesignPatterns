using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Flyweight
{
    public abstract class Character
    {
        protected string _nome;
        //protected string _dano;
        protected double _saude;

        public Character(string nome, double saude)
        {
            _nome = nome;
            _saude = saude;
        }

        public abstract void Golpe(int dano);
    }
}

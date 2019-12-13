using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Bridger
{
   public abstract class Forma
    {
        protected string _nome;
        private Cor _cor;


        public Forma(string nome)
        {
            _nome = nome;
        }

        public abstract void DesenharForma();

        public Cor Cor
        {
            get { return _cor; }
            set { _cor = value; }
        }



    }
}

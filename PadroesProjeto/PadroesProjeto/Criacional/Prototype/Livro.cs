using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.Prototype
{
    public class Livro : Item
    {
        public Livro(string nome, double preco) : base(nome, preco)
        {
        }

        public override Item Clone()
        {
            return (Item)this.MemberwiseClone();
        }
    }
}

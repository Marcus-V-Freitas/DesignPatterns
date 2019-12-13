using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.Prototype
{
    public abstract class Item
    {
        private string _nome;
        private double _preco;

        public Item(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }

        public abstract Item Clone();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {_nome} Preco: {_preco}");
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Decorator
{
    public abstract class Pizza
    {
        protected string _nome = _nomePadrao;
        protected double _preco = _precoPadrao;
        protected List<string> _adicionais =new List<string>();

        private static string _nomePadrao = "Comum";
        private static double _precoPadrao = 10.0;


        public void Attach(string adicional)
        {
            string[] valores =adicional.Split(' ');
            _adicionais.Add(adicional);
            _preco += double.Parse(valores[1]);

        }

        public abstract void ValorTotal();
    }
}

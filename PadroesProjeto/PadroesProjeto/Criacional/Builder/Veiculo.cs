using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.Builder
{
   public class Veiculo
    {
        private string _nome;

        private Dictionary<string, string> _partes = new Dictionary<string, string>();

        public Veiculo(string nome)
        {
            _nome = nome;
        }

        public void Add(string parte, string descricao)
        {
            _partes.Add(parte, descricao);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {_nome}");
            foreach (var parte in _partes.Keys)
            {
                sb.AppendLine($"Parte: {parte} Descrição: {_partes[parte]}");
            }
          return sb.ToString();
        }
    }
}

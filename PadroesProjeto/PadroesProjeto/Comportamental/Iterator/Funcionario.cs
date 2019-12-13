using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Iterator
{
    public class Funcionario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }


        public Funcionario(int codigo,string nome)
        {
            Codigo = codigo;
            Nome = nome;
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-----------------");
            sb.AppendLine($"Codigo: {Codigo}");
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine("-----------------");

            return sb.ToString();

        }
    }
}

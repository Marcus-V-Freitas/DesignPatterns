using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Comportamental.Memento
{
    public class Pessoa
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }


        public Pessoa(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void setPessoa(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public Memento CreateMemento()
        {
            return new Memento(new Pessoa(codigo: Codigo, nome: Nome));
        }

        public void Restore(Memento memento)
        {
            Codigo = memento.Pessoa.Codigo;
            Nome = memento.Pessoa.Nome;

        }

        public override string ToString()
        {
            StringWriter writer = new StringWriter();
           writer.WriteLine($"Id: {Codigo} Nome: {Nome}");
            return writer.ToString();
        }
    }
}

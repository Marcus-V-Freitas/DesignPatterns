using PadroesProjeto.PadroesProjeto.Estrutural.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar=null;
            var facade = new Facade();
            do
            {
                Console.Clear();
                facade.Show(typeof(Facade));
                Console.WriteLine("\nSelecione pelo número o método: \n");
                int.TryParse(Console.ReadLine(), out int resposta);
                facade.Metodo(resposta);



                Console.WriteLine("Deseja continuar? (S/N)");
             continuar= Console.ReadLine();
            } while (continuar != "S");
        }
    }
}

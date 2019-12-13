using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Composite
{
    public class Formulario : Component,IComponent
    {
        private List<Component> _components = new List<Component>();

        public Formulario(string nome):base(nome)
        {
          
        }

        public void Attach(Component component)
        {
            _components.Add(component);
        }

        public void Detach(Component component)
        {
            _components.Remove(component);
        }

        public override void Show()
        {
            Console.WriteLine($"Nome {_nome}");

            foreach (var item in _components)
            {
                item.Show();
            }
        }
    }
}

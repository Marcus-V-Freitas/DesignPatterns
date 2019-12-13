using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Composite
{
    public interface IComponent
    {
        void Attach(Component component);
        void Detach(Component component);
        void Show();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Adapter
{
    public class Adapter:Target
    {
        private Adaptee _adaptee=new Adaptee();


        public override void Request(string path)
        {
            _adaptee.SpecificRequest(path);
        }
    }
}

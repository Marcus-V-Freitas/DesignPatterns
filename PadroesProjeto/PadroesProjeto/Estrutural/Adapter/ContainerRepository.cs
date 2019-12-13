using PadroesProjeto.PadroesProjeto.Estrutural.Proxy;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PadroesProjeto.PadroesProjeto.Estrutural.Adapter
{
    public static class ContainerRepository
    {
        public static void UseRepository(this Container container)
        {
            

            container.Register<ICalc, CalcProxy>(Lifestyle.Singleton);

           

        }
     
    }
}

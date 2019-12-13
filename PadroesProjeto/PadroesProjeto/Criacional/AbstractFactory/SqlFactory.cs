using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.AbstractFactory
{
    public class SqlFactory : AbstractFactory
    {
        public override Command GetCommand()
        {
            return new SqlCommand();
        }

        public override Connection GetConnection()
        {
            return new SqlConnection();
        }
    }
}

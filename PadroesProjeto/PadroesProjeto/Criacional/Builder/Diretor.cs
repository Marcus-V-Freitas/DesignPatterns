using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.Builder
{
    public class Diretor
    {
        public Veiculo Construtor(Builder builder)
        {
            builder.BuildMotor();
            builder.BuildPneu();
            builder.BuildPorta();
          return  builder.GetVeiculo();
        }
    }
}

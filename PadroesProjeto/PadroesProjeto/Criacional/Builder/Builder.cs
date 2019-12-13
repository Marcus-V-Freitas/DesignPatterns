using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.Builder
{
    public abstract class Builder
    {
        protected Veiculo _veiculo;

        public abstract void BuildMotor();
        public abstract void BuildPorta();
        public abstract void BuildPneu();
        public abstract Veiculo GetVeiculo();
    }
}

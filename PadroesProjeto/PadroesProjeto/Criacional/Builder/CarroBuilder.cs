using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.PadroesProjeto.Criacional.Builder
{
    public class CarroBuilder : Builder
    {
        public CarroBuilder(string nome)
        {
            _veiculo = new Veiculo(nome);
        }


        public override void BuildMotor()
        {
            _veiculo.Add("Motor", "Flex");
        }

        public override void BuildPneu()
        {
            _veiculo.Add("Pneu", "4");
        }

        public override void BuildPorta()
        {
            _veiculo.Add("Porta", "4");
        }

        public override Veiculo GetVeiculo()
        {
            return _veiculo;
        }
    }
}

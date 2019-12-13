using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Estruturas.Testes
{
    public class Conta : IDisposable
    {
        private double _saldo = 0;

        private static readonly Conta _instance = new Conta();

        public static Conta Instance
        {
            get { return _instance; }
        }


        public void Sacar(double valor)
        {
            if (valor <= _saldo)
            {
                _saldo -= valor;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public double getSaldo
        {
            get{ return _saldo; }
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PadroesProjeto.Estruturas.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Estruturas.Testes.Tests
{
    [TestClass()]
    public class ContaTests
    {

        [TestMethod()]
        public void DepositarTest()
        {
            var conta = new Conta();
            double esperado = 1000;
            double atual = 0;
            conta.Depositar(1000);
            atual = conta.getSaldo;
            Assert.AreEqual(esperado, atual,"Falha ao depositar");
        }

        [TestMethod()]
        public void Falha()
        {
            var conta = new Conta();

            Assert.IsFalse(conta.getSaldo > 1);
        }

        [TestMethod]
        public void InstanciaTipo()
        {
            var conta = new Conta();
            Assert.IsInstanceOfType(conta, typeof(IDisposable));
        }

        [TestMethod]
        public void MesmaInstancia()
        {
            var conta1 = Conta.Instance;
            var conta2 = Conta.Instance;
            Assert.AreSame(conta1, conta2, "Não são iguais");
        }



    }
}
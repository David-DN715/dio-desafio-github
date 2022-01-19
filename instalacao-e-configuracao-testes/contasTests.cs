using Microsoft.VisualStudio.TestTools.UnitTesting;
using contas;
using System;
using System.Collections.Generic;
using System.Text;

namespace contas.Tests
{
    [TestClass()]
    public class contasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 10;
            var contas = new contas();

            var result = contas.Soma(a, b);
            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void subtracaoTest()
        {

            var a = 5;
            var b = 5;
            var esperado = 0;
            var contas = new contas();

            var result = contas.subtracao(a, b);
            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void divisaoTest()
        {

            var a = 5;
            var b = 5;
            var esperado = 1;
            var contas = new contas();

            var result = contas.divisao(a, b);
            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void multiplicacaoTest()
        {

            var a = 5;
            var b = 5;
            var esperado = 25;
            var contas = new contas();

            var result = contas.multiplicacao(a, b);
            Assert.AreEqual(esperado, result);
        }
    }
}
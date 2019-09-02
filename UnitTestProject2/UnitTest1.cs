using System;
using DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestQueComeHamurguesa()
        {
            IAlimento alimento = new Hamburguesa();
            Elefante elefante = new Elefante("trompita");
            var result=elefante.Comer(alimento);
            Assert.IsTrue(result);
        }
    }
}

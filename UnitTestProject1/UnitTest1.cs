using System;
using DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodQueFallaExitosamente()
        {
            IAlimento _iAlimento = new Mani();
            Elefante elefante = new Elefante("Dumbo");
            bool result = elefante.Comer(_iAlimento);
            Assert.IsTrue(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapacitacionBackend;
using CapacitacionBackend.Controllers;

namespace CapacitacionBackend.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Robots()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Robots() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestClass]
        public class CalculatorTestsTDD
        {
            [TestMethod]
            public void Adding_4_And_3_Should_Return_7()
            {
                // Arrange
                var calculator = new Calculator();
                // Act
                int result = calculator.GetSum(4, 3);
                // Assert
                Assert.AreEqual(7, result);
            }
        }

        [TestClass]
        public class CalculatorTestsBDD
        {
            [TestMethod]
            public void Given_Parametros_Con_Valores_Positivos_When_Sumar_Se_Llama_Then_Debe_Devolver_Valor_De_la_Suma                ()
            {
                // Arrange
                var calculator = new Calculator();
                // Act
                int result = calculator.GetSum(4, 3);
                // Assert
                Assert.AreEqual(7, result);
            }
        }
    }
}

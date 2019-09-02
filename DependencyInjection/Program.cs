using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DependencyInjection
{
	// El inyector
	class MainClass
	{
		public static void Main(string[] args)
		{
		    IAlimento _iAlimento = new Mani();
            Elefante elefante= new Elefante("Dumbo");
		    elefante.Comer(_iAlimento);
		    List<int> numeros = new List<int>();

            

















            Console.WriteLine("Press enter to close...");
		    Console.ReadLine();





















            //IAlimento alimento = null;

            //alimento = new Pizza("Jamon y Morrones");
            ////alimento = new Hamburguesa() { Tipo = "Sencilla" };

            //// Inyectamos la dependencia a través del constructor
            //var persona = new Persona(alimento);
            //   var persona2 = new Persona();

            //         // Persona usa 
            //         persona.Comer();

            //         //pausar la consola
            //   Console.WriteLine("Press enter to close...");
            //   Console.ReadLine();
        }
	}
}

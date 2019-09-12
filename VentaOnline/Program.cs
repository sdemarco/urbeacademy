using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace VentaOnline
{
    public class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero del uno al 10");
            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    {
                        Console.WriteLine("Tu numero elegido representa: Amor");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tu numero elegido representa: Amistad");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Tu numero elegido representa: Compañia");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Tu numero elegido representa: Fraternidad");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Tu numero elegido representa: Pureza");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Tu numero elegido representa: Tranquilidad");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Tu numero elegido representa: Eternidad");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Tu numero elegido representa: Tenasidad");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Tu numero elegido representa: Furia");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Tu numero elegido representa: Paciencia");
                        break;
                    }
                default:
                    Console.WriteLine("El numero no es valido");
                    break;
            }

            Console.ReadKey();
        }

     }
}

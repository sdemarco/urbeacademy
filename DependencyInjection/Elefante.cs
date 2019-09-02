using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Elefante : ISerVivo
    {
        private string name;
        public Elefante(string name)
        {
            this.name = name;
        }

        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Comer(IAlimento alimento)
        {
            Console.WriteLine(name + " Esta comiendo " + alimento.Nombre);

            return alimento == null ? false : true;

        }
    }
}

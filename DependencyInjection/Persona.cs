using System;
namespace DependencyInjection
{
	// Cliente que consume el servicio
	public class Persona
	{
	    public IAlimento _alimento;
	    private string nombre;

        public Persona(IAlimento alimento)
		{
			_alimento = alimento;
		}

		public void Comer()
		{
			Console.WriteLine("Comiendo " + _alimento.Nombre);
		}

	    public Persona()
	    {
	            
	    }
	}
}


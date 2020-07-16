using System;

namespace Proyecto_5_Herencias
{
	public class Persona
	{
		public string Nombre { get; set; }
		public int Edad { get; set; }

		public Persona() { }
		public Persona(string nombre, int edad)
		{
			Nombre = nombre;
			Edad = edad;
		}

		public virtual void Saludar()
		{
			Console.WriteLine("Hola, mi nombre es {0}", Nombre);
		}

        public override string ToString()
        {
			return string.Format("{0}, {1}", Nombre, Edad);
        }
    }
}

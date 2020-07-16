using System;

namespace Proyecto_5_Herencias
{
	public abstract class Trabajador
	{
        public string Nombre { get; set; }
        public string Puesto { get; set; }

        public abstract decimal Salario { get; }

        public Trabajador(string nombre, string puesto)
        {
            Nombre = nombre;
            Puesto = puesto;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, mi nombre es: {0}", Nombre);
        }

        public abstract void Trabajar();

    }
}

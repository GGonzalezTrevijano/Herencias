using System;

namespace Proyecto_5_Herencias
{
	public class Estudiante : Empleado
	{
        public double Promedio { get; set; }
        public string Grado { get; set; }

        public Estudiante(string nombre, int edad, string puesto, decimal sueldo, double promedio, string grado) : base(nombre, edad, puesto, sueldo)
        {
            Promedio = promedio;
            Grado = grado;
        }

        public void Estudiar()
        {
            Console.WriteLine("Hola, mi nombre es {0} y curso la materia de {1}", Nombre, Grado);
        }

        public void Escuela()
        {
            Console.WriteLine("Voy al grado de {0} y mi promedio de notas es de {1}", Grado, Promedio);
        }

        public override void Saludar()
        {
            Console.WriteLine("Saludos, me llamo {0}, trabajo en {1} y gano {2} Euros.", Nombre, Puesto, Sueldo);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}", Nombre, Edad, Puesto, Sueldo, Grado, Promedio);
        }
    }
}

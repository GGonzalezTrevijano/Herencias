using System;

namespace Proyecto_5_Herencias
{
    class Program
    {
        static void Main(string[] args)
        {

            //HERENCIAS ENTRE CLASES

            Persona p = new Persona("Guillermo", 38);
            p.Saludar();

            Console.WriteLine();

            Empleado e = new Empleado("Jonh", 29, "Ventas", 10000);
            e.Saludar();
            e.Trabajar();

            Console.WriteLine();

            Console.WriteLine(e);

            Estudiante es = new Estudiante("Pepon", 25, "Programador", 15000, 8.5, "ADE");
            es.Saludar();
            es.Escuela();
            es.Estudiar();

            Console.WriteLine();

            //HERENCIAS ABSTRACTAS

            TrabajadorHonorarios th = new TrabajadorHonorarios("Pedro", "Ventas", 12000);
            th.Trabajar();
            Console.WriteLine("Salario por honorarios: {0}", th.Salario);


            TrabajadorNomina tn = new TrabajadorNomina("Laura", "Sistemas", 14000);
            tn.Trabajar();
            Console.WriteLine();
            Console.WriteLine("Salario por Nomina: {0}", tn.Salario);

            Console.WriteLine();

            //CLASE OBJECT

            User p1 = new User("Pepa Pig", 30);
            User p2 = new User("Pepa Pig", 30);
            User p3 = p1;

            //Compracación por referencia

            Console.WriteLine("Referencia p1 y p2 son iguales");
            Console.WriteLine(p1 == p2);

            Console.WriteLine("Referencia p2 y p3 son iguales");
            Console.WriteLine(p2 == p3);

            Console.WriteLine("Referencia p1 y p3 son iguales");
            Console.WriteLine(p1 == p3);


            Console.WriteLine();

            //Comparación de objetos
            Console.WriteLine("Referencia p1 y p2 son iguales");
            Console.WriteLine(p1.Equals(p2));


        }
    }
}

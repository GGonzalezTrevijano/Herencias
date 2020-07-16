using System;

namespace Proyecto_5_Herencias
{
	public class TrabajadorNomina : Trabajador
	{
        public decimal SueldoBase { get; set; }
        public override decimal Salario
        {
            get
            {
                return SueldoBase;
            }
        }

        public TrabajadorNomina(string nombre, string puesto, decimal sueldoBase) : base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }

        public override void Trabajar()
        {
            Console.Write("Trabajando por mi Nomina");
        }
    }
}

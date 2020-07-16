using System;

namespace Proyecto_5_Herencias
{
	public class TrabajadorHonorarios : Trabajador
	{
        public decimal SueldoBase { get; set; }
        public override decimal Salario
        {
            get
            {
                return SueldoBase * 0.84m;
            }
        }

        public TrabajadorHonorarios(string nombre, string puesto, decimal sueldoBase) : base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }

        public override void Trabajar()
        {
            Console.WriteLine("Trabajando por mis honorarios");
        }
    }
}

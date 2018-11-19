using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
	class Program
	{
		static void Main(string[] args)
		{
			int opc = 1;
			double cantidad;
			Console.Write("Cajero automatico, escriba su numero de cuenta: ");
			int cuentaB = Convert.ToInt32(Console.ReadLine());
			Console.Write("Escribe tu DNI para verificar tu identidad: ");
			string dni = Console.ReadLine();

			Random rnd = new Random();
			double ingresos = rnd.Next(0, 9999999);

			Cuenta cuenta = new Cuenta(dni, ingresos, 0.05);
			cuenta.setnumCuenta(cuentaB);

			do
			{
				Console.WriteLine("0. Salir");
				Console.WriteLine("1. Sacar Dinero");
				Console.WriteLine("2. Ingresar Dinero");
				Console.WriteLine("3. Información de la cuenta");
				opc = Convert.ToInt32(Console.ReadLine());

				switch (opc)
				{
					case 0:
						break;
					case 1:
						Console.Write("Inserte cantidad a retirar: ");
						cantidad = Convert.ToDouble(Console.ReadLine());
						cuenta.Retirar(cantidad);
						break;
					case 2:
						Console.Write("Inserte cantidad a ingresar: ");
						cantidad = Convert.ToDouble(Console.ReadLine());
						cuenta.Ingresar(cantidad);
						break;
					case 3:
						cuenta.MostrarDatos();
						break;
				}
			} while (opc != 0);
		}
	}
}

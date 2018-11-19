using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Dime el nombre del teatro: ");
			string nombreTeatro = Console.ReadLine();

			Console.Write("Dime la direccion del teatro: ");
			string direccionTeatro = Console.ReadLine();

			Teatro teatro = new Teatro();
			teatro.setNombre(nombreTeatro);
			teatro.setDireccion(direccionTeatro);

			string nombreFuncion;
			double precioFuncion;
			Funcion[] funcion = new Funcion[4];
			for(int i = 0; i < 4; i++)
			{
				Console.Write("Dime el nombre de la funcion: ");
				nombreFuncion = Console.ReadLine();
				Console.Write("Dime el precio de la funcion: ");
				precioFuncion = Convert.ToDouble(Console.ReadLine());
				funcion[i] = new Funcion();
				funcion[i].setNombre(nombreFuncion);
				funcion[i].setPrecio(precioFuncion);
			}

			teatro.mostrarDatos();

			for(int i = 0; i < 4; i++)
			{
				funcion[i].mostrarDatos();
			}

			Console.ReadKey();
		}
	}
}

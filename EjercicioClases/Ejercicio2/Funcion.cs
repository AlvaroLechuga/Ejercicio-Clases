using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
	class Funcion
	{
		private string nombre;
		private double precio;

		public void setNombre(string nombre)
		{
			this.nombre = nombre;
		}

		public void setPrecio(double precio)
		{
			this.precio = precio;
		}

		public string getNombre()
		{
			return nombre;
		}

		public double getPrecio()
		{
			return precio;
		}

		public void mostrarDatos()
		{
			Console.WriteLine("El nombre de la funcion es: "+nombre +"la entrada cuesta "+precio +"euros");
		}
	}
}

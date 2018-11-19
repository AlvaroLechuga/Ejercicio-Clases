using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
	class Teatro
	{
		private string nombre;
		private string direccion;

		public void setNombre(string nombre)
		{
			this.nombre = nombre;
		}

		public void setDireccion(string direccion)
		{
			this.direccion = direccion;
		}

		public string getNombre()
		{
			return nombre;
		}

		public string getDireccion()
		{
			return direccion;
		}

		public void mostrarDatos()
		{
			Console.WriteLine("El nombre del teatro es: {0} y la direccion es: {1}", nombre, direccion);
		}
	}
}

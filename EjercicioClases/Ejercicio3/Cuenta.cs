using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
	class Cuenta
	{
		private int numCuenta;
		private string dni;
		private double saldoActual;
		private double interes;

		public Cuenta(string dni, double saldoActual, double interes)
		{
			this.dni = dni;
			this.saldoActual = saldoActual;
			this.interes = interes;
		}

		public void setnumCuenta(int numCuenta)
		{
			this.numCuenta = numCuenta;
		}

		public void ActualizarSaldo()
		{
			saldoActual = (saldoActual * interes) / 365;
		}

		public void Ingresar(double cantidad)
		{
			saldoActual += cantidad;
		}

		public void Retirar(double retirar)
		{
			if (retirar > saldoActual)
			{
				Console.WriteLine("No puedes sacar esa cantidad de dinero ya que no lo tienes");
			}
			else
			{
				saldoActual -= retirar;
			}
		}
		public void MostrarDatos()
		{
			Console.WriteLine("Su numero de cuenta es: {0}", numCuenta);
			Console.WriteLine("Su DNI es: {0}", dni);
			Console.WriteLine("Su sueldo en cuenta actual es: " +saldoActual);
			Console.WriteLine("Su interes actual es: "+interes);
		}
	}
}

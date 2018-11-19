using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
	class Triangulo
	{
		//Triangulo isoceles
		private double lIgual;
		private double lDiferente;
		private double altura;

		public void setlIgual(double lado)
		{
			this.lIgual = lado;
		}
		public void setlDiferente(double lado)
		{
			this.lDiferente = lado;
		}

		public void setAltura(double altura)
		{
			this.altura = altura;
		}

		public double getlIgual()
		{
			return lIgual;
		}
		public double getlDiferente()
		{
			return lDiferente;
		}

		public double getAltura()
		{
			return altura;
		}

		public void perimetro()
		{
			double perimetro = lDiferente + lIgual + lIgual;
			Console.WriteLine("El perimetro del triangulo es: {0}", perimetro);
		}

		public void area()
		{
			double area = (lDiferente * altura) / 2;
			Console.WriteLine("El area del triangulo es: {0}", area);
		}
	}
}

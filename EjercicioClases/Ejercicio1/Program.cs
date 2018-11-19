using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
	class Program
	{
		static void Main(string[] args)
		{
			Triangulo triangulo = new Triangulo();
			Console.WriteLine("Voy a calcular el perimetro y el area de un triangulo isoceles");
			Console.Write("Dime la longitud de los lados iguales: ");
			double iguales = Convert.ToDouble(Console.ReadLine());
			Console.Write("Dime la longitud del lado diferente: ");
			double diferente = Convert.ToDouble(Console.ReadLine());
			Console.Write("Dime la altura del triangulo: ");
			double altura = Convert.ToDouble(Console.ReadLine());

			triangulo.setlIgual(iguales);
			triangulo.setlDiferente(diferente);
			triangulo.setAltura(altura);

			triangulo.perimetro();
			triangulo.area();

			Console.ReadKey();
		}
	}
}

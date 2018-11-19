using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
	class Program
	{
		static void Main(string[] args)
		{
            double costeExtra = 0;
            double costeBruto = 0;
            int opc = 0;
            Empleado empleado = new Empleado();

            Console.Write("Dime el NIF del empleado: ");
            string nif = Console.ReadLine();
            empleado.setNif(nif);
            Console.Write("Dime el sueldo base del empleado: ");
            double sueldoBase = Convert.ToDouble(Console.ReadLine());
            empleado.setSueldoBase(sueldoBase);
            Console.Write("Dime cuanto le pagas al empleado por hora extra: ");
            double pExtra = Convert.ToDouble(Console.ReadLine());
            empleado.setPExtras(pExtra);
            Console.Write("Dime la cantidad de horas extras que ha realizado el empleado: ");
            int nHoras = Convert.ToInt32(Console.ReadLine());
            empleado.setHExtras(nHoras);
            Console.Write("Dime el tipo de IRPF que tiene el empleado: ");
            double irpf = Convert.ToDouble(Console.ReadLine());
            empleado.setIrpf(irpf);
            Console.Write("Dime si el empleado se encuentra casado: ");
            bool casado = Convert.ToBoolean(Console.ReadLine());
            empleado.setCasado(casado);
            Console.Write("Dime el numero de hijos que tiene el empleado: ");
            int nHijos = Convert.ToInt32(Console.ReadLine());
            empleado.setNHijos(nHijos);

            do
            {
                Console.WriteLine("1. Calculo y devolucion del complemento correspondiente a las horas extra realizadas.");
                Console.WriteLine("2. Calculo y devolucion del sueldo bruto.");
                Console.WriteLine("3. Visualiza informacion del empleado.");
                Console.WriteLine("0. Salir.");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 0:
                        break;
                    case 1:
                        costeExtra = empleado.calcularExtras();
                        break;
                    case 2:
                        costeBruto = empleado.calcularBruto(costeExtra);
                        break;
                    case 3:
                        empleado.mostrarInfo(costeBruto);
                        break;
                    default:
                        Console.WriteLine("Has introducido un numero no valido");
                        break;
                    
                }

            } while (opc != 0);
            Console.ReadKey();
        }
	}
}

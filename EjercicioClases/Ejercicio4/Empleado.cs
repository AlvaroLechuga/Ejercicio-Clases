using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Empleado
    {
        //NIF, sueldo base, pago por hora extra, horas extra realizadas en el mes, tipo (porcentaje) de IRPF, casado o no y número de hijos
        private string nif;
        private double sueldoBase;
        private double pExtras;
        private int hExtras;
        private double irpf;
        private bool casado;
        private int nHijos;

        public void setNif(string nif)
        {
            this.nif = nif;
        }

        public void setSueldoBase(double sueldoBase)
        {
            this.sueldoBase = sueldoBase;
        }

        public void setPExtras(double pExtras)
        {
            this.pExtras = pExtras;
        }

        public void setHExtras(int hExtras)
        {
            this.hExtras = hExtras;
        }

        public void setIrpf(double irpf)
        {
            this.irpf = irpf;
        }

        public void setCasado(bool casado)
        {
            this.casado = casado;
        }

        public void setNHijos(int nHijos)
        {
            this.nHijos = nHijos;
        }

        public string getNif()
        {
            return nif;
        }

        public double getSueldoBase()
        {
            return sueldoBase;
        }

        public double getPExtras()
        {
            return pExtras;
        }

        public int getHExtras()
        {
            return hExtras;
        }

        public double getIrpf()
        {
            return irpf;
        }

        public bool getCasado()
        {
            return casado;
        }

        public int getNHijos()
        {
            return nHijos;
        }

        public double calcularExtras()
        {
            double costeExtra = hExtras * pExtras;
            return costeExtra;
        }

        public double calcularBruto(double costoExtra)
        {
            double bruto = sueldoBase + costoExtra;
            return bruto;
        }

        public void mostrarInfo(double costeBruto)
        {
            Console.WriteLine("El NIF del trabajador es: {0}", nif);
            Console.WriteLine("El sueldo base del trabajador es: "+ sueldoBase);
            Console.WriteLine("El pago que se realiza al empleado por hora extra es: "+pExtras);
            Console.WriteLine("La cantidad de horas extras son: {0}", hExtras);
            Console.WriteLine("El tipo de IRPF es: "+irpf);
            Console.WriteLine("El empleado se encuentra casado: {0}", casado);
            Console.WriteLine("El empleado tiene un total de {0} hijos", nHijos);
            Console.WriteLine("El empleado tiene un sueldo bruto de "+costeBruto);

        }
    }
}

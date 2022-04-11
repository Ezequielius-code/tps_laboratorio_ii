using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero; 

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        private double ValidarOperando(string strNumero)
        {
            double numeroValidado = 0;

            if(!string.IsNullOrEmpty(strNumero) && double.TryParse(strNumero, out numeroValidado))
            {
                return numeroValidado;
            }
            return numeroValidado;
        }

        //TODO
        public string BinarioDecimal(string binario)
        {
            return "lalala";
        }

        //TODO
        public string DecimalBinario(double numero)
        {
            return "lalala";
        }

        //TODO
        public string DecimalBinario(string numero)
        {
            return "lalala";
        }

        //TODO
        private bool EsBinario(string binario)
        {
            return true;
        }

        //TODO
        public static double operator +(Operando n1, Operando n2)
        {
            return n1 + n2;
        }

        //TODO
        public static double operator -(Operando n1, Operando n2)
        {
            return n1 - n2;
        }

        //TODO
        public static double operator *(Operando n1, Operando n2)
        {
            return n1 * n2;
        }

        //TODO
        public static double operator /(Operando n1, Operando n2)
        {
            return n1 / n2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        //TODO : Documentar
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

            if(double.TryParse(strNumero, out numeroValidado))
            {
                return numeroValidado;
            }
            return numeroValidado;
        }

        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido.";

            if(!string.IsNullOrEmpty(binario) && EsBinario(binario))
            {
                char[] binarioA_Decimal = binario.ToCharArray();
                double potencia = 0;
                double numeroConvertido = 0;

                for(int i = binarioA_Decimal.Length; i >= 0; i--)
                {
                    if(binarioA_Decimal[i] == '1')
                    {
                        numeroConvertido = numeroConvertido + Math.Pow(2, potencia);
                    }
                    potencia++;
                }
                retorno = numeroConvertido.ToString();
                return retorno;
            }
            return retorno;
        }

        //TODO
        public string DecimalBinario(double numero)
        {
            string retorno = "Valor inválido.";
            string numeroBinario = "";
            if (numero >= 0)
            {
                int numeroABinario = (int)Math.Truncate(numero);
                while (numeroABinario > 0)
                {
                    numeroBinario = numeroABinario % 2 + numeroBinario;
                    numeroABinario = numeroABinario / 2;
                }

                return numeroBinario;
            }

            return retorno;
        }

        public string DecimalBinario(string numero)
        {
            string retorno = "Valor inválido.";
            double numeroAux;

            if (double.TryParse(numero, out numeroAux))
            {
                string numeroBinario = DecimalBinario(numeroAux);

                return numeroBinario;
            }

            return retorno;
        }

        private static bool EsBinario(string binario)
        {
            if (string.IsNullOrEmpty(binario))
            {
                return false;
            }
            else
            {
                char[] binarioA_Array = binario.ToCharArray();

                for (int i = 0; i < binarioA_Array.Length; i++)
                {
                    if (binarioA_Array[i] != '0' && binarioA_Array[i] != '1')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static double operator +(Operando n1, Operando n2)
        {
            double retorno = n1.numero + n2.numero;
            return retorno;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            double retorno = n1.numero - n2.numero;
            return retorno;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            double retorno = n1.numero * n2.numero;
            return retorno;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            double retorno = double.MinValue;
            if (n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
                return retorno;
            }
            return retorno;
        }
    }
}

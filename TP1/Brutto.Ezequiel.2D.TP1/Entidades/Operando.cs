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

        /// <summary>
        /// Constructor que se utiliza en el caso de no recibir un argumento.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que con un parámetro que recibe como argumento un valor de tipo
        /// double que iniciará el atributo de la clase con el valor pasado como argumento.
        /// </summary>
        /// <param name="numero">Recibe el argumento que inicializará al atributo de la clase con el valor provisto</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que recibe un valor de tipo string como argumento e inicializa el atributo de 
        /// la clase utilizando la propiedad Numero de la misma.
        /// </summary>
        /// <param name="strNumero">Recibe el atributo que inicializará como atributo de la clase</param>
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        /// <summary>
        /// Propiedad con sólo un descriptor de acceso set que asigna un valor al atributo de clase
        /// utilizando el método ValidarOperando(); de esta misma clase.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Toma un argumento de tipo string y lo convierte en un valor de tipo double.
        /// </summary>
        /// <param name="strNumero">Toma el argumento al que intentará convertir a un valor de tipo double</param>
        /// <returns>En caso de éxito, devuelve el valor convertido en un número de tipo double. Si no puede 
        /// realizar la conversión, devuelve un 0(cero)</returns>
        private double ValidarOperando(string strNumero)
        {
            double numeroValidado = 0;

            if(double.TryParse(strNumero, out numeroValidado))
            {
                return numeroValidado;
            }
            return numeroValidado;
        }

        /// <summary>
        /// Recibe una cadena de texto, valida que corresponda con el formato de un número binario mediante
        /// el método EsBinario de esta clase y opera para convertir este número binario en un número del
        /// sistema decimal con formato string.
        /// </summary>
        /// <param name="binario">Cadena de texto a evaluar y, en caso positivo, con la cual operar.</param>
        /// <returns>En caso de éxito un número del sistema decimal en formato string. Si fracasa, la 
        /// leyenda "Valor inválido."</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido.";

            if(!string.IsNullOrEmpty(binario) && EsBinario(binario))
            {
                char[] binarioA_Decimal = binario.ToCharArray();
                double potencia = 0;
                double numeroConvertido = 0;

                for(int i = binarioA_Decimal.Length - 1; i >= 0; i--)
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

        /// <summary>
        /// Convierte un número de tipo double en un número binario equivalente en formato string.
        /// Si el número tiene decimales, los trunca y sólo convierte en binario la parte entera.
        /// </summary>
        /// <param name="numero">Número que recibe para convertir</param>
        /// <returns>Si puede convertir el número, devuelve un número binario como un valor de tipo string. 
        /// Caso contrario, devuelve la leyenda "Valor inválido."</returns>
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

        /// <summary>
        /// Recibe un número decimal en formato string, lo convierte en un valor de tipo double
        /// y reutilizando el método de la clase con el mismo nombre lo convierte en binario.
        /// </summary>
        /// <param name="numero">Recibe el argumento que intentará convertir</param>
        /// <returns>En caso de éxito, un número binario equivalente en formato string.
        /// Si fracasa, la leyenda "Valor inválido."</returns>
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

        /// <summary>
        /// Método que valida que un número binario recibido como string coincida con el formato de un número binario.
        /// Para hacerlo, convierte el string en un array de caracteres y evalúa uno por uno para que no hay valores 
        /// distintos a ceros y unos.
        /// </summary>
        /// <param name="binario">Recibe el argumento que será evaluado</param>
        /// <returns>En caso de que se corresponda con un número binario 'true', de lo contrario 'false'.</returns>
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

        /// <summary>
        /// Sobrecarga del operador '+' para sumar dos objetos de tipo Operando.
        /// </summary>
        /// <param name="n1">1er objeto de tipo Operando</param>
        /// <param name="n2">2do objeto de tipo Operando</param>
        /// <returns>El resultado de la suma entre ambos objetos</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            double retorno = n1.numero + n2.numero;
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador '-' para restar dos objetos de tipo Operando.
        /// </summary>
        /// <param name="n1">1er objeto de tipo Operando</param>
        /// <param name="n2">2do objeto de tipo Operando</param>
        /// <returns>El resultado de la resta entre ambos objetos</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            double retorno = n1.numero - n2.numero;
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador '*' para multiplicar dos objetos de tipo Operando.
        /// </summary>
        /// <param name="n1">1er objeto de tipo Operando</param>
        /// <param name="n2">2do objeto de tipo Operando</param>
        /// <returns>El resultado de la multiplicación entre ambos objetos</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            double retorno = n1.numero * n2.numero;
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador '/' para dividir dos objetos de tipo Operando.
        /// </summary>
        /// <param name="n1">1er objeto de tipo Operando</param>
        /// <param name="n2">2do objeto de tipo Operando</param>
        /// <returns>El resultado de la división entre ambos objetos. 
        /// Si el divisor es 0(cero), double.MinValue</returns>
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

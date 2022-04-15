using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza una operación aritmética acorde a los valores que recibe en sus parámetros.
        /// Utiliza el método de clase ValidarOperador() para validar el carcter que recibe como 
        /// argumento.
        /// </summary>
        /// <param name="num1">1er operando con el que realizará la operación</param>
        /// <param name="num2">2do operando con el que realizará la operación</param>
        /// <param name="operador">Operador con el cual realizará la operación</param>
        /// <returns>El resultado de la operación que realiza</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            char operadorValidado = ValidarOperador(operador);

            switch (operadorValidado)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                default:
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Recibe un caracter y lo valida como operador aritmético.
        /// </summary>
        /// <param name="operador">Caracter a evaluar</param>
        /// <returns>Si el caracter es válido, devuelve el operador matemático que corresponda.
        /// Si el caracter es distinto de los válidos ('+','-','*','/'), devuelve por defecto
        /// el operador de suma</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }
            return '+';
        }
    }
}

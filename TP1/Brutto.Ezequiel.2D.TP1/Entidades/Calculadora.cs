using System;

namespace Entidades
{
    public static class Calculadora
    {
        //TODO : Documentar
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

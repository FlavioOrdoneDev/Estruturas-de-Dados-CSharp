using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Recursao
{
    public static class Fibonacci
    {

        public static int SequenciaDeFibonacci(int n)
        {
            int num1 = 0;
            int num2 = 1;
            int aux;

            for (int i = 0; i < n; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
            }
            return num2;
        }


        public static int SequenciaDeFibonacciRecursiva(int n)
        {
            int resultado = 0;

            // Caso indutivo
            if (n > 1)
                resultado = SequenciaDeFibonacciRecursiva(n - 1) + SequenciaDeFibonacciRecursiva(n - 2);

            // Caso base
            if (n <= 1)
                resultado = 1;

            return resultado;
            
        }
    }
}

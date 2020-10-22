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
            int resultado = 0;

            // Caso indutivo
            if (n > 1)
                resultado = SequenciaDeFibonacci(n - 1) + SequenciaDeFibonacci(n - 2);

            // Caso base
            if (n <= 1)
                resultado = 1;

            return resultado;
            
        }
    }
}

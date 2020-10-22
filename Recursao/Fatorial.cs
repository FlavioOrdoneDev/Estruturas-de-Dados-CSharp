using System;
using System.Collections.Generic;
using System.Text;

namespace Recursao
{
    public static class Fatorial
    {
        public static int CalculaFatorial(int n)
        {
            int resultado = 0;

            // Caso indutivo
            if (n > 1)
                resultado = n * CalculaFatorial(n - 1);

            // Caso base
            if (n == 1)
                resultado = 1;

            return resultado;
        }
    }
}

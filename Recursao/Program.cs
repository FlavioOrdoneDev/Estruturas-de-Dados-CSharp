using System;

namespace Recursao
{
    class Program
    {
        static void Main(string[] args)
        {


            /*******   Calcular Fatorial ********/

            // 5! = 5*4*3*2*1
            int fatorial = Fatorial.CalculaFatorial(5);

            Console.WriteLine(fatorial);
            Console.WriteLine();


            /******* Sequência de Fibonacci ********/

            // 1, 1, 2, 3, 5, 8, 13
            // 0, 1, 2, 3, 4, 5, 6

            int fib = Fibonacci.SequenciaDeFibonacci(4);

            Console.WriteLine(fib);

            Console.ReadKey();
        }        
    }
}

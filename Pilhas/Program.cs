using System;

namespace Pilhas
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack pilha = new CStack();

            pilha.Push(5);
            pilha.Push(3);
            pilha.Push(8);
            pilha.Push(10);
            pilha.Push(12);

            pilha.PrintStack();

            pilha.Pop();

            pilha.PrintStack();
            Console.WriteLine();

            Console.WriteLine(pilha.Peek());
            Console.WriteLine(pilha.Peek());
            pilha.PrintStack();

            Console.ReadKey();
        }
    }
}

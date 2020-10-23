using System;

namespace Filas
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(7);
            queue.Enqueue(1);

            queue.PrintQueue();
            Console.WriteLine();

            Console.WriteLine("Valor retirado: " + queue.Dequeue());

            queue.PrintQueue();
            Console.WriteLine();

            queue.Enqueue(8);
            queue.PrintQueue();
            Console.WriteLine();


            Console.WriteLine("O primeiro da fila é: " + queue.Peek());

            Console.ReadKey();
        }
    }
}

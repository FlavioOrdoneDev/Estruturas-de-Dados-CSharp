using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Vetor vetor = new Vetor(10);

            
            vetor.Adiciona("B");
            vetor.Adiciona("C");
            vetor.Adiciona("E");
            vetor.Adiciona("F");
            vetor.Adiciona("G");


            Console.WriteLine(vetor);

            vetor.Adiciona(0, "A");

            Console.WriteLine(vetor);

            vetor.Adiciona(3, "D");

            Console.WriteLine(vetor);

            vetor.Adiciona(6, "X");

            Console.WriteLine(vetor);

            Console.ReadKey();

        }
    }
}

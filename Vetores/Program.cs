using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Vetor vetor = new Vetor(10);

            vetor.Adiciona("elemento 1");
            vetor.Adiciona("elemento 2");
            vetor.Adiciona("elemento 3");
            vetor.Adiciona("elemento 4");

            Console.WriteLine(vetor.Busca(3));
            
            Console.WriteLine(vetor.BuscarElemento("elemento 1"));

            vetor.MostraValores();

            Console.ReadKey();

        }
    }
}

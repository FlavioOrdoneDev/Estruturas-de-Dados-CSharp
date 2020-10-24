using System;
using System.Collections;
using System.Collections.Generic;

namespace VetoresGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            VetorGenerico<Contato> vetor = new VetorGenerico<Contato>(3);

            Contato contato1 = new Contato() { Nome = "Flávio", Telefone = "9999-8877", Email = "flavio@gmail.com" };
            Contato contato2 = new Contato() { Nome = "Roberto", Telefone = "5285-8853", Email = "roberto@gmail.com" };
            Contato contato3 = new Contato() { Nome = "Warley", Telefone = "68536-8860", Email = "warley@gmail.com" };

            Contato contato4 = new Contato() { Nome = "Warley", Telefone = "68536-8860", Email = "warley@gmail.com" };

            vetor.Adiciona(contato1);
            vetor.Adiciona(contato2);
            vetor.Adiciona(contato3);

            Console.WriteLine(vetor.Busca(1));

            //Console.WriteLine("Tamanho = " + vetor.Tamanho());
            //Console.WriteLine(vetor.Busca(0));
            //Console.WriteLine(vetor.BuscaElemento(contato4));
            //Console.WriteLine(vetor);

            List<Contato> list = new List<Contato>() ;

            list.Add(contato1);
            list.Add(contato2);
            list.Add(contato3);

            Console.WriteLine(list.Contains(contato1));
            Console.WriteLine(list.Contains(contato4));

            Console.WriteLine(list.IndexOf(contato1));
            Console.WriteLine(list.GetRange(0, 1));

            Console.WriteLine(list.Count);
            list.RemoveAt(2);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            Console.WriteLine(list.LastIndexOf(contato2));

            Console.ReadKey();
        }
    }
}

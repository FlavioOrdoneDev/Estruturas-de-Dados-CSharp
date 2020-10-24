using System;

namespace VetoresDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            VetorObjeto vetor = new VetorObjeto(3);

            Contato contato1 = new Contato() { Nome = "Flávio", Telefone = "9999-8877", Email = "flavio@gmail.com" };
            Contato contato2 = new Contato() { Nome = "Roberto", Telefone = "5285-8853", Email = "roberto@gmail.com" };
            Contato contato3 = new Contato() { Nome = "Warley", Telefone = "68536-8860", Email = "warley@gmail.com" };

            vetor.Adiciona(contato1);
            vetor.Adiciona(contato2);
            vetor.Adiciona(contato3);

            Console.WriteLine("Tamanho = " + vetor.Tamanho());
            Console.WriteLine(vetor.Busca(0));
            Console.WriteLine(vetor.BuscaElemento(contato1));

            Console.ReadKey();
        }
    }
}

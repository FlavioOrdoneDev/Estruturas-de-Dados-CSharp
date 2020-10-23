using System;
using System.Collections.Generic;
using System.Text;

namespace Filas
{
    public class Queue
    {
        CNo ancora;
        CNo trabalho;
        public Queue()
        {
            ancora = new CNo();
            ancora.Proximo = null;
        }

        public void PrintQueue()
        {
            trabalho = ancora;

            while (trabalho.Proximo != null)
            {
                trabalho = trabalho.Proximo;
                int dado = trabalho.Dado;
                Console.Write(" {0}<-", dado);
            }

            Console.WriteLine();
        }

        public void Enqueue(int dado)
        {
            trabalho = ancora;

            while (trabalho.Proximo != null)
            {
                trabalho = trabalho.Proximo;
            }

            CNo temp = new CNo();

            temp.Dado = dado;
            temp.Proximo = null;

            trabalho.Proximo = temp;
        }

        public int Dequeue()
        {
            int valor = 0;

            if (ancora.Proximo != null)
            {
                trabalho = ancora.Proximo;
                valor = trabalho.Dado;

                ancora.Proximo = trabalho.Proximo;
                trabalho.Proximo = null;
            }

            return valor;
        }

        public int Peek()
        {
            int valor = 0;

            if (ancora.Proximo != null)
            {
                trabalho = ancora.Proximo;
                valor = trabalho.Dado;                
            }

            return valor;
        }
    }
}

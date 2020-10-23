using System;
using System.Collections.Generic;
using System.Text;

namespace Pilhas
{
    public class CStack
    {
        private CNo ancora;

        private CNo trabalho;

        public CStack()
        {
            ancora = new CNo();

            ancora.Proximo = null;
        }

        public void Push(int pDado)
        {
            CNo temp = new CNo();
            temp.Dado = pDado;

            temp.Proximo = ancora.Proximo;
            ancora.Proximo = temp;
        }

        public int Pop()
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

        public void PrintStack()
        {
            trabalho = ancora;

            while (trabalho.Proximo != null)
            {
                trabalho = trabalho.Proximo;
                Console.WriteLine("[{0}]", trabalho.Dado);
            }
        }
    }
}

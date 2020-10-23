using System;
using System.Collections.Generic;
using System.Text;

namespace BalancoDeSinais
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

        public void Push(char pDado)
        {
            CNo temp = new CNo();
            temp.Dado = pDado;

            temp.Proximo = ancora.Proximo;
            ancora.Proximo = temp;
        }

        public char Pop()
        {
            char valor = ' ';

            if (ancora.Proximo != null)
            {
                trabalho = ancora.Proximo;
                valor = trabalho.Dado;

                ancora.Proximo = trabalho.Proximo;
                trabalho.Proximo = null;
            }

            return valor;
        }

        public char Peek()
        {
            char valor = ' ';

            if (ancora.Proximo != null)
            {
                trabalho = ancora.Proximo;
                valor = trabalho.Dado;
            }

            return valor;
        }

        public bool EmptyStack()
        {
            if (ancora.Proximo == null)
                return true;
            else
                return false;
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

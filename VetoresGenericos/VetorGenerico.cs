using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace VetoresGenericos
{
    public class VetorGenerico
    {
        public VetorGenerico(int capacidade)
        {
            this.elementos = new Object[capacidade];
            this.tamanho = 0;
        }

        private Object[] elementos;

        private int tamanho;

        public Object Busca(int posicao)
        {
            if (posicao >= 0 && posicao < tamanho)
                return this.elementos[posicao];
            else
                return "Posicao inválida";
        }        

        public int BuscaElemento(Object elemento)
        {
            for (int i = 0; i < this.tamanho; i++)
            {
                if (this.elementos[i].Equals(elemento))
                    return i;
            }
            return -1;
        }

        public bool BuscarElementoContains(string elemento)
        {
            return this.elementos.Contains(elemento);
        }

        public bool Adiciona(Object elemento)
        {
            this.AumentaCapacidade();

            if (this.tamanho < this.elementos.Length)
            {
                this.elementos[this.tamanho] = elemento;
                this.tamanho++;
                return true;
            }

            return false;
        }

        public bool Adiciona(int posicao, Object elemento)
        {
            this.AumentaCapacidade();

            if (posicao < 0 && posicao > tamanho)
                throw new Exception("Posição inválida");
            else
            {
                for (int i = this.tamanho - 1; i >= posicao; i--)
                {
                    this.elementos[i + 1] = this.elementos[i];
                }
                this.elementos[posicao] = elemento;
                this.tamanho++;
            }
            return true;
        }

        public Object Remove(int posicao)
        {
            Object deletado = this.elementos[posicao];

            if (posicao < 0 && posicao > tamanho)
                throw new Exception("Posição inválida");
            else
            {
                for (int i = posicao; i < this.tamanho - 1; i++)
                {
                    this.elementos[i] = this.elementos[i + 1];                    
                }

                this.tamanho--;
            }

            return deletado;
        }

        public Object RemovePorElemento(string elemento)
        {
            int posicao = this.BuscaElemento(elemento);
            if (posicao < 0)
                return "Elemento não encontrado";
            return this.Remove(posicao);
        }

        public int QuantidadeElementos()
        {
            int total = 0;
            foreach (var item in this.elementos)
            {
                if (item != null)
                    total++;
            }

            return total;
        }

        public int Tamanho()
        {
            return this.tamanho;
        }

        public void MostraValores()
        {
            foreach (var item in this.elementos)
            {
                Console.WriteLine(item);
            }
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("[");

            for (int i = 0; i < this.tamanho -1; i++)
            {
                s.Append(this.elementos[i]);
                s.Append(", ");
            }

            if (this.tamanho > 0)
            {
                s.Append(this.elementos[this.tamanho - 1]);
            }

            s.Append("]");
            return s.ToString();
        }

        private void AumentaCapacidade()
        {
            if (this.tamanho == this.elementos.Length)
            {
                Object[] elementosNovos = new Object[this.elementos.Length * 2];
                for (int i = 0; i < this.elementos.Length; i++)
                {
                    elementosNovos[i] = elementos[i];
                }
                this.elementos = elementosNovos;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VetoresDeObjetos
{
    public class Contato
    {
        public string Nome;
        public string Telefone;
        public string Email;

        public override string ToString()
        {
            return "Contato [ nome = " + Nome + ", telefone = " + Telefone + ", Email = " + Email + " ]";
        }
    }
}

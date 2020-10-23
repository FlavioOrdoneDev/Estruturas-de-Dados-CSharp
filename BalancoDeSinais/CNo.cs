using System;
using System.Collections.Generic;
using System.Text;

namespace BalancoDeSinais
{
    public class CNo
    {
        private char dado;
        public char Dado { get => dado; set => dado = value; }

        private CNo proximo = null;
        internal CNo Proximo { get => proximo; set => proximo = value; }

        public override string ToString()
        {
            return string.Format("[{0}]", dado);
        }
    }
}

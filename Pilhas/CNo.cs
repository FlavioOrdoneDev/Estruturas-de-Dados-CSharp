using System;
using System.Collections.Generic;
using System.Text;

namespace Pilhas
{
    public class CNo
    {
        private int dado;
        public int Dado { get => dado; set => dado = value; }

        private CNo proximo = null;
        internal CNo Proximo { get => proximo; set => proximo = value; }

        public override string ToString()
        {
            return string.Format("[{0}]", dado);
        }
    }
}

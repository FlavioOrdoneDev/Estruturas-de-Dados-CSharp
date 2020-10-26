using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_01
{
    public static class Sort_Descending
    {
        public static int[] SortDesc(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);           

            return array;
        }
    }
}

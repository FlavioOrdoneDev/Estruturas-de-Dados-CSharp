using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_01
{
    public static class Rotate_Array_Given_Pivot
    {
        public static int[] Rotate(int[] x, int pivot )
        {
            pivot = pivot % x.Length;

            // Rotate first half
            x = RotateSub(x, 0, pivot - 1);

            // Rotate second half
            x = RotateSub(x, pivot, x.Length - 1);

            // Rotate all
            x = RotateSub(x, 0, x.Length - 1);

            return x;            
        }

        public static int[] RotateSub(int[] array, int start, int end)
        {
            while (start < end)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }

            return array;
        }
    }
}

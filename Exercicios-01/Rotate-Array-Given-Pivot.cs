using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_01
{
    public static class Rotate_Array_Given_Pivot
    {
        public static string Rotate(int[] array, int pivot )
        {
            string result = "";
            pivot = pivot % array.Length;

            // Rotate first half
            array = RotateSub(array, 0, pivot - 1);

            // Rotate second half
            array = RotateSub(array, pivot, array.Length - 1);

            // Rotate all
            array = RotateSub(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }

            return result;
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

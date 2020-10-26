using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios_01
{
    public static class MergeSortedArrays
    {
        //public static string MergeArrays(int[] x, int[] y, int lastX )
        //{
        //    string result = "";
        //    int xIndex = lastX;
        //    int yIndex = y.Length - 1;
        //    int mergeIndex = x.Length - 1;

        //    while (yIndex >= 0)
        //    {
        //        if (y[yIndex] > x[xIndex])
        //        {
        //            x[mergeIndex] = y[yIndex];
        //            yIndex--;
        //        }
        //        else if (y[yIndex] < x[xIndex])
        //        {
        //            x[mergeIndex] = x[xIndex];
        //            xIndex--;
        //        }
        //        mergeIndex--;
        //    }

        //    for (int i = 0; i < x.Length; i++)
        //    {
        //        result += x[i] + " "; 
        //    }

        //    return result;
        //}

        public static int[] MergeArrays(int[] first, int[] second)
        {            
            return first.Concat(second).OrderBy(x => x).ToArray();
        }
        
    }
}

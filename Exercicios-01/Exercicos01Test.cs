using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios_01
{
    [TestClass]
    public class Exercicos01Test
    {
        
        [TestMethod]
        public void CouldBeReverseArray()
        {            
            int[] array = {1,2,3,4,5,6,7,8,9,10};

            var result = Reverse_array.ReverseArray(array);

            string numbers = "10, 9, 8, 7, 6, 5, 4, 3, 2, 1";
            string sResult = String.Join(", ", result);

            Assert.AreEqual(numbers, sResult);
        }
                
        [TestMethod]
        public void CouldBeRotateArrayGivenPivotTest1()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = Rotate_Array_Given_Pivot.Rotate(array, 3);

            string numbers1 = "4, 5, 6, 7, 8, 9, 10, 1, 2, 3";

            string sResult = String.Join(", ", result);

            Assert.AreEqual(numbers1, sResult);
        }

        [TestMethod]
        public void CouldBeRotateArrayGivenPivotTest2()
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var result2 = Rotate_Array_Given_Pivot.Rotate(array, 6);

            string numbers2 = "7, 8, 9, 10, 1, 2, 3, 4, 5, 6";

            string sResult2 = String.Join(", ", result2);

            Assert.AreEqual(numbers2, sResult2);
        }

        [TestMethod]
        public void CouldBeArraySortDescending()
        {
            int[] array = { 12, 90, 31, 24, 35 };

            var result = Sort_Descending.SortDesc(array);

            string numbers = "90, 35, 31, 24, 12";
            string sResult = String.Join(", ", result);

            Assert.AreEqual(numbers, sResult);
        }
        
        [TestMethod]
        public void CouldBeMergeSortedArrays()
        {
            int[] first = new int[] { 3, 5, 6, 9, 12, 14, 18, 20, 25, 28 };
            int[] second = new int[] { 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };

            var result = MergeSortedArrays.MergeArrays(first, second);

            string numbers = "3, 5, 6, 9, 12, 14, 18, 20, 25, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48";
            string sResult = String.Join(", ", result);
            Assert.AreEqual(numbers, sResult);
        }
    }
}

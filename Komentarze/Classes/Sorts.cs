using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komentarze.Classes
{
    /// <summary>
    /// Klasa z metodami sortującymi tablice
    /// </summary>
    internal class Sorts
    {
        /// <summary>
        /// QuickSort
        /// </summary>
        /// <param name="array"></param>
        /// <param name="leftIndex"></param>
        /// <param name="rightIndex"></param>
        /// <returns>Posortowana tablica int[]</returns>
        public int[] QuickSortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSortArray(array, leftIndex, j);

            if (i < rightIndex)
                QuickSortArray(array, i, rightIndex);

            return array;
        }
    }
}

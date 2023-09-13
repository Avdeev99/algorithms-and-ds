using System.Linq;

namespace ConsoleApp1.SortingAlgorithms
{
    public class MergeSortAlgorithm
    {
        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }
		
            var middle = arr.Length / 2;
            var left = arr.Take(middle).ToArray();
            var right = arr.Skip(middle).ToArray();
		
            return Merge(
                MergeSort(left),
                MergeSort(right));
        }
	
        private static int[] Merge(int[] left, int[] right)
        {
            var length = left.Length + right.Length;
            var result = new int[length];
            var leftIndex = 0;
            var rightIndex = 0;
            var resultIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    result[resultIndex] = left[leftIndex];
                    leftIndex++;
                    resultIndex++;
                }
                else
                {
                    result[resultIndex] = right[rightIndex];
                    rightIndex++;
                    resultIndex++;
                }
            }

            while (leftIndex < left.Length)
            {
                result[resultIndex] = left[leftIndex];
                leftIndex++;
                resultIndex++;
            }
            
            while (rightIndex < right.Length)
            {
                result[resultIndex] = right[rightIndex];
                rightIndex++;
                resultIndex++;
            }

            return result;
        }
    }
}
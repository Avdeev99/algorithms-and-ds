namespace AlgorithmsAndDS.SortingAlgorithms;

public class QuickSortAlgorithm
{
    // Time complexity: O(nlog(n)); Space complexity: O(log(n))
    public static int[] QuickSort(int[] arr, int leftIndex, int rightIndex)
    {
        if (leftIndex < rightIndex)
        {
            var partitionIndex = Partition(arr, leftIndex, rightIndex);
            
            QuickSort(arr, leftIndex, partitionIndex - 1);
            QuickSort(arr, partitionIndex + 1, rightIndex);
        }

        return arr;
    }

    private static int Partition(
        int[] arr,
        int leftIndex,
        int rightIndex)
    {
        var pivotIndex = rightIndex;
        var pivot = arr[pivotIndex];
        var partitionIndex = leftIndex;

        for (var i = leftIndex; i < rightIndex; i++)
        {
            if (arr[i] < pivot)
            {
                (arr[i], arr[partitionIndex]) = (arr[partitionIndex], arr[i]);
                partitionIndex++;
            }
        }

        (arr[pivotIndex], arr[partitionIndex]) = (arr[partitionIndex], arr[pivotIndex]);

        return partitionIndex;
    }
}
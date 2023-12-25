using System;

namespace ConsoleApp1.ArraysAndHashing.Easy;

// 1299. Replace Elements with Greatest Element on Right Side
public class ReplaceElementsWithGreatestElementOnRightSide
{
    // Time complexity: O(n); Space complexity: O(n).
    public int[] ReplaceElements(int[] arr)
    {
        var greatestElements = new int[arr.Length];
        greatestElements[arr.Length - 1] = -1;
        var max = arr[^1];

        for (var i = arr.Length - 2; i >= 0; i--)
        {
            greatestElements[i] = max;
            max = Math.Max(max, arr[i]);
        }

        return greatestElements;
    }
}
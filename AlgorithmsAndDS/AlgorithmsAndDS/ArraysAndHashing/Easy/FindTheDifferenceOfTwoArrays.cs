using System.Linq;

namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 2215. Find the Difference of Two Arrays
public class FindTheDifferenceOfTwoArrays
{
    // Time complexity: O(n+m); Space complexity: O(n+m).
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var nums1Set = new HashSet<int>(nums1);
        var nums2Set = new HashSet<int>(nums2);

        var answer1 = new HashSet<int>();

        foreach (var num in nums1)
        {
            if (!nums2Set.Contains(num))
                answer1.Add(num);
        }

        var answer2 = new HashSet<int>();

        foreach (var num in nums2)
        {
            if (!nums1Set.Contains(num))
                answer2.Add(num);
        }

        return new List<IList<int>>
        {
            answer1.ToList(),
            answer2.ToList()
        };
    }
}
namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 28. Find the Index of the First Occurrence in a String
public class FindTheIndexOfTheFirstOccurrenceInString
{
    // Time complexity: O(nm); Space complexity: O(1).
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length) return -1;

        var leftIndex = 0;
        var rightIndex = needle.Length - 1;

        while(rightIndex < haystack.Length)
        {
            var subStr = haystack.Substring(leftIndex, needle.Length);

            if (subStr == needle)
            {
                return leftIndex;
            }

            leftIndex++;
            rightIndex++;
        }

        return -1;
    }
}
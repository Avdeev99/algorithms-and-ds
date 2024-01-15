using System;

namespace ConsoleApp1.TwoPointers.Medium;

// 881. Boats to Save People
public class BoatsToSavePeople
{
    // Time complexity: O(nlog(n)); Space complexity: O(n).
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);

        var counter = 0;
        var left = 0;
        var right = people.Length - 1;

        while (left <= right)
        {
            var sum = people[left] + people[right];

            if (sum <= limit)
                left++;

            right--;
            counter++;
        }
        
        return counter;
    }
}
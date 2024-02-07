using System;
using System.Collections.Generic;

namespace ConsoleApp1.PriorityQueue.Medium;

// 973. K Closest Points to Origin
public class KClosestPointsToOrigin
{
    // Time complexity: O(n*log(n)); Space complexity: O(n).
    public int[][] KClosest(int[][] points, int k)
    {
        var priorityQueue = new PriorityQueue<int[], double>();

        foreach (var point in points)
        {
            double distance = Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
            priorityQueue.Enqueue(point, distance);
        }

        var result = new int[k][];
        for (var i = 0; i < k; i++)
            result[i] = priorityQueue.Dequeue();

        return result; 
    }
}
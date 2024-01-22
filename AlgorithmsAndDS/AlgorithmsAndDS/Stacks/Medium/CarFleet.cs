using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Stacks.Medium;

// 853. Car Fleet
public class CarFleet
{
    // Time complexity: O(nlog(n)); Space complexity: O(n).
    public int GetCarFleet(int target, int[] position, int[] speed)
    {
        if (position.Length < 2) return position.Length;

        var cars = new SortedList<int, double>(Comparer<int>.Create((x, y) => y - x));

        for (var i = 0; i < position.Length; i++)
        {
            cars.Add(position[i], ((double)target - position[i]) / speed[i]);
        }

        var result = 0;
        double curr = 0;

        foreach (var (_, hoursToFinish) in cars)
        {
            if (hoursToFinish > curr)
            {
                curr = hoursToFinish;
                result++;
            }
        }

        return result;
    }

    public int CarFleetWithStack(int target, int[] position, int[] speed)
    {
        if (position.Length < 2) return position.Length;

        var cars = new SortedList<int, int>(Comparer<int>.Create((x, y) => y - x));
        var hoursToFinish = new Stack<double>();

        for (var i = 0; i < position.Length; i++)
        {
            cars.Add(position[i], speed[i]);
        }

        foreach (var (pos, sp) in cars)
        {
            var previousCarHours = ((double)target - pos) / sp;
            var isPrevCarHoursGreater = !hoursToFinish.Any() ||
                                        (hoursToFinish.Any() && previousCarHours > hoursToFinish.Peek());

            if (isPrevCarHoursGreater)
                hoursToFinish.Push(previousCarHours);
        }

        return hoursToFinish.Count;
    }
}
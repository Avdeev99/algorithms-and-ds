using System.Linq;

namespace AlgorithmsAndDS.BlindSpot75;

public static class CourseSchedule2
{
    private static Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
    private static HashSet<int> visited = new HashSet<int>();
    private static HashSet<int> result = new HashSet<int>();

    public static int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        for (var i = 0; i < numCourses; i++)
        {
            map[i] = new List<int>();
        }

        foreach (var arr in prerequisites)
        {
            var courseToTake = arr[0];
            var courseDependOn = arr[1];

            map[courseToTake].Add(courseDependOn);
        }

        for (var i = 0; i < numCourses; i++)
        {
            var canComplete = Dfs(i);

            if (!canComplete) return new int[] {};
        }

        return result.Count == numCourses
            ? result.ToArray()
            : new int[] {};
    }

    private static bool Dfs(int course)
    {
        if (visited.Contains(course)) return false;

        if (!map[course].Any())
        {
            return true;
        }

        visited.Add(course);

        foreach (var item in map[course])
        {
            var canComplete = Dfs(item);

            if (!canComplete) return false;
        }

        visited.Remove(course);
        result.UnionWith(map[course]);
        result.Add(course);
        map[course] = new List<int>();

        return true;
    }
}
using System.Linq;

namespace AlgorithmsAndDS.Graphs.Medium;

// 207. Course Schedule
public class CourseSchedule
{
    private Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
    private HashSet<int> visited = new HashSet<int>();

    // Time complexity: O(n + p); Space complexity: O(n + p).
    public bool CanFinish(int numCourses, int[][] prerequisites)
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
            var result = Dfs(i);

            if (!result) return false;
        }

        return true;
    }

    private bool Dfs(int course)
    {
        if (visited.Contains(course))
        {
            return false;
        }

        if (!map[course].Any()) return true;

        visited.Add(course);

        foreach (var item in map[course])
        {
            var result = Dfs(item);

            if (!result) return result;
        }

        visited.Remove(course);
        map[course] = new List<int>();

        return true;
    }
}
namespace AlgorithmsAndDS.BlindSpot75;

public static class CarFleet
{
    public static int GetCarFleet(int target, int[] position, int[] speed) {
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

            if (hoursToFinish.Count > 0)
            {
                var firstCarHours = hoursToFinish.Peek();

                if (previousCarHours > firstCarHours)
                    hoursToFinish.Push(previousCarHours);
            }
            else
                hoursToFinish.Push(previousCarHours);
        }

        return hoursToFinish.Count;
    }
}
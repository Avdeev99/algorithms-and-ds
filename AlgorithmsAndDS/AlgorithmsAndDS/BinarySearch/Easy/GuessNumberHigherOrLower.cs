namespace ConsoleApp1.BinarySearch.Easy;

public class GuessNumberHigherOrLower
{
    // Time complexity: O(log(n)); Space complexity: O(1).
    public int GuessNumber(int n)
    {
        var left = 1;
        var right = n;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            var guessResult = Guess(mid);

            if (guessResult == 0)
                return mid;

            if (guessResult == -1)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1;
    }

    private int Guess(int num) => 0;
}
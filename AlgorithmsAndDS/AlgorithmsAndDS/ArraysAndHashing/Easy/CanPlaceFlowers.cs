namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 605. Can Place Flowers
public class CanPlaceFlowers
{
    // Time complexity: O(n); Space complexity: O(1).
    public bool CanPlace(int[] flowerbed, int n)
    {
        var i = 0;

        while (n != 0 && i < flowerbed.Length)
        {
            if (flowerbed[i] == 1)
            {
                i++;
                continue;
            }

            var leftPlace = i > 0 ? flowerbed[i-1] : 0;
            var rightPlace = i < flowerbed.Length - 1 ? flowerbed[i+1] : 0;

            if (leftPlace == 0 && rightPlace == 0)
            {
                flowerbed[i] = 1;
                n--;
            }

            i++;
        }

        return n == 0;
    }
}
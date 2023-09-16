namespace ConsoleApp1.ArraysAndHashing.Easy;

public class ParkingSystem
{
    private readonly int[] parkingSpace;

    // Space complexity: O(n).
    public ParkingSystem(int big, int medium, int small)
    {
        parkingSpace = new[] { big, medium, small };
    }
    
    // Time complexity: O(1);
    public bool AddCar(int carType)
    {
        var index = carType - 1;

        return parkingSpace[index]-- > 0;
    }
}
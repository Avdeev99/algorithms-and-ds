namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 1603. Design Parking System
public class ParkingSystem
{
    private readonly int[] parking;

    // Space complexity: O(n).
    public ParkingSystem(int big, int medium, int small)
    {
        parking = new int[] { big, medium, small };
    }
    
    // Time complexity: O(1);
    public bool AddCar(int carType)
    {
        var parkingPlace = carType - 1;

        if (parking[parkingPlace] == 0)
            return false;

        parking[parkingPlace] -= 1;

        return true;
    }
}
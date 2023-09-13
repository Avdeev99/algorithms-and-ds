using System;

namespace ConsoleApp1.BlindSpot75;

public static class DivideTwoIntegers
{
    public static int Divide(int dividend, int divisor)
    {
        if (dividend < int.MinValue || dividend > int.MaxValue) return 0;
        
        var number = Math.Abs(dividend);
        var posDivisor = Math.Abs(divisor);
        var counter = 0;

        while(number >= posDivisor)
        {
            if (int.MaxValue - posDivisor <= counter) return 0;

            number -= posDivisor;
            counter++;
        }

        var isNegative = (dividend <= 0 && divisor > 0) ||
                         (dividend >= 0 && divisor < 0);

        return isNegative ? counter * -1 : counter;
    }
}
using System;

namespace ConsoleApp1.BlindSpot75
{
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            var l = 0;
            var r = height.Length - 1;
            var maxArea = 0;

            while (l < r)
            {
                var heightValue = Math.Min(height[l], height[r]);
                var widthValue = r - l;

                var area = heightValue * widthValue;
                maxArea = Math.Max(maxArea, area);

                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return maxArea;
        }
        
        public static int MaxArea2(int[] height)
        {
            var maxArea = 0;
            
            for (var i = 0; i < height.Length - 1; i++)
            {
                for (var j = i + 1; j < height.Length; j++)
                {
                    var heightValue = Math.Min(height[i], height[j]);
                    var widthValue = j - i;

                    var area = heightValue * widthValue;

                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }

            return maxArea;
        }
    }
}
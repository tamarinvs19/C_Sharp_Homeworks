using Xunit;

namespace RainWater;

public static class RainWaterTest
{
    public static void DoTest()
    {
        var rainWater = new RainWater(
            new List<int>(12) { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }
        );
        Assert.Equal(6, rainWater.CalculateCapacity());
    }
    
}
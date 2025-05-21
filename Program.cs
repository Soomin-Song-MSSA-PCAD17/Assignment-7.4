/// Leetcode 1603
/// https://leetcode.com/problems/design-parking-system
/// 
/// Design a parking system for a parking lot.
/// The parking lot has three kinds of parking spaces:
/// big, medium, and small,
/// with a fixed number of slots for each size.

Demo(["ParkingSystem", "addCar", "addCar", "addCar", "addCar"], [[1, 1, 0], [1], [2], [3], [1]]);
Console.ReadKey();

void Demo(string[] commands, int[][] values)
{
    #region display input
    string input1 = $"[{string.Join(", ", commands)}]";
    Console.WriteLine($"Commands: {input1}");

    string[] valueArrays = new string[values.Length];
    for(int i=0; i<values.Length; i++)
    {
        valueArrays[i] = $"[{string.Join(", ", values[i])}]";
    }
    string input2 = $"[{string.Join(", ", valueArrays)}]";
    Console.WriteLine($"Values: {input2}");
    #endregion

    #region display output
    ParkingSystem obj = null;
    string[] output = new string[commands.Length];
    for(int i=0; i<commands.Length; i++)
    {
        switch (commands[i])
        {
            case "ParkingSystem":
                obj = new ParkingSystem(values[i][0], values[i][1], values[i][2]);
                output[i] = "null";
                break;
            case "addCar":
                output[i] = $"{obj.AddCar(values[i][0])}";
                break;
        }
    }
    Console.WriteLine($"Output: [{string.Join(", ",output)}]");
    #endregion
}

public class ParkingSystem
{
    int[] spaces = [0, 0, 0];
    public ParkingSystem(int big, int medium, int small)
    {
        spaces = [big, medium, small];
    }

    public bool AddCar(int carType)
    {
        if (spaces[carType - 1] > 0)
        {
            spaces[carType - 1] -= 1;
            return true;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
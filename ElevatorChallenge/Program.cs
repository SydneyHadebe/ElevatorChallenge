namespace ElevatorChallenge;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Weight Limit for elevators");
        var weightLimit = int.Parse(Console.ReadLine());

        Console.WriteLine("Number of elevators in the building");
        var building = new Building(int.Parse(Console.ReadLine()), weightLimit);

        Console.WriteLine("Number of floors in the building");      // We will pass 3
        building.NoOfFloors = int.Parse(Console.ReadLine());

        building.CallElevator(3, 0, 2);
        Console.WriteLine($"The building {building}");

        building.CallElevator(2, 0, 3);

        building.CallElevator(3, 9, 1);

        building.CallElevator(1, 11, 3);
    }
}
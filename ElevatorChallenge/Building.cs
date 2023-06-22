using ElevatorChallenge.Interfaces;

namespace ElevatorChallenge;

public class Building : IBuilding
{
    public int NoOfFloors { get; set; }
    public Building(int noOfElevators, int weightLimit)
    {
        Elevators = new List<Elevator>(noOfElevators);

        var elevatorNames = Helper.ElevatorHelper(Elevators.Capacity);

        for (var i = 0; i < Elevators.Capacity; i++)
        {
            var newElevator = new Elevator(weightLimit, elevatorNames[i]);
            newElevator.Status = new ElevatorStatus();
            Elevators.Add(newElevator);
        }
    }
    public List<Elevator> Elevators;

    public void CallElevator(int destinationFloorNumber, int noOfPeople = 1, int initialFloorNumber = 0)
    {
        var magicNumber = initialFloorNumber;

        foreach (var elevatorS in Elevators)
        {
            var difference = elevatorS.Status.FloorNumber - initialFloorNumber;
            if (difference < magicNumber)
            {
                magicNumber = difference;
            }
        }
        var elevator = Elevators.Where(a => a.Status.FloorNumber - initialFloorNumber == magicNumber).First();

        elevator.GetTheElevator(elevator, initialFloorNumber, noOfPeople);
        elevator = elevator.MovePeople(elevator, initialFloorNumber, destinationFloorNumber, noOfPeople);

        for (int i = 0; i < Elevators.Count; i++)
        {
            if (!Elevators[i].Name.Equals(elevator.Name)) continue;
            Elevators[i].Status = elevator.Status;
            break;
        }
    }
}
using ElevatorChallenge.Enums;
using ElevatorChallenge.Interfaces;

namespace ElevatorChallenge;

public class Elevator : IElevator
{
    public int WeightLimit { get; set; }
    public int NewDestinationFloor { get; set; }
    public int CurrentDestinationFloor { get; set; }
    public ElevatorStatus Status { get; set; }
    public char Name { get; set; }

    public Elevator(int weightLimit, char name)
    {
        WeightLimit = weightLimit;
        Name = name;
    }

    public Elevator GetTheElevator(Elevator elevator, int initialFloor, int noOfPeople = 1)
    {
        if (elevator.Status.IsMoving)
        {
            if (initialFloor == NewDestinationFloor)
                return elevator;

            elevator.StopAt(elevator, CurrentDestinationFloor);
            elevator.MoveTo(elevator, noOfPeople);
        }

        if (initialFloor != elevator.Status.FloorNumber)
            elevator.MoveTo(elevator, noOfPeople);

        return elevator;
    }

    public Elevator StopAt(Elevator elevator, int currentDestinationFloor)
    {
        elevator.Status.FloorNumber = currentDestinationFloor;
        elevator.Status.Direction = Direction.Stopped;
        return elevator;
    }

    public Elevator MoveTo(Elevator elevator, int noOfPeople = 1)
    {
        if (noOfPeople < WeightLimit)
            elevator.Status.IsMoving = true;
        return elevator;
    }

    public Elevator MovePeople(Elevator elevator, int initialFloorNumber, int destinationFloorNumber, int noOfPeople)
    {
        elevator.Status.Direction = elevator.Status.FloorNumber > initialFloorNumber ? Direction.Down : Direction.Up;
        elevator.Status.FloorNumber = destinationFloorNumber;
        elevator.Status.NoOfPeople = noOfPeople;
        elevator.MoveTo(elevator, noOfPeople);

        return elevator;
    }
}
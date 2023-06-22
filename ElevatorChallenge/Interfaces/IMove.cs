namespace ElevatorChallenge.Interfaces;

public interface IMove
{
    Elevator MovePeople(Elevator elevator, int initialFloorNumber, int destinationFloorNumber, int noOfPeople);
}
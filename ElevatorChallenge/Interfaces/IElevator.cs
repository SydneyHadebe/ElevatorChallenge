namespace ElevatorChallenge.Interfaces;

public interface IElevator : IMove, IGetElevator
{
    Elevator StopAt(Elevator elevator, int currentDestinationFloor);
    Elevator MoveTo(Elevator elevator, int noOfPeople = 1);
}
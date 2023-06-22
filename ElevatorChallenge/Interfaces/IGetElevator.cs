namespace ElevatorChallenge.Interfaces;

public interface IGetElevator
{
    Elevator GetTheElevator(Elevator elevator, int initialFloor, int noOfPeople = 1);
}
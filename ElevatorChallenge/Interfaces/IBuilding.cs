namespace ElevatorChallenge.Interfaces;

public interface IBuilding
{
    void CallElevator(int destinationFloorNumber, int noOfPeople = 1, int initialFloorNumber = 0);
}
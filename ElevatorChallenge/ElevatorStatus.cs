using ElevatorChallenge.Enums;
using ElevatorChallenge.Interfaces;

namespace ElevatorChallenge;

public class ElevatorStatus
{
    public bool IsMoving { get; set; } = false;
    public Direction Direction { get; set; } = Direction.Stopped;
    public int FloorNumber { get; set; } = 0;
    public int NoOfPeople { get; set; } = 0;
}
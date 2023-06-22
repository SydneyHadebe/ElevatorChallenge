namespace ElevatorChallenge;

public class Helper
{
    public static IReadOnlyList<char> ElevatorHelper(int numberOfElevators)
    {
        var alphabets = new List<char>();
        for (int i = 0; i < numberOfElevators; i++)
        {
            char c = (char)('A' + 1);
            alphabets.Add(c);
        }

        return alphabets;
    }
}
using System; 

public class Die
{
    private int numSides; 
    private static Random Random = new Random();

    public Die(int numSides)
    {
        if(numSides < 4 || numSides > 20)
        {
            throw new ArgumentException("Should be between 4 and 20."); 
        }
        this.numSides = numSides;
    }

    public int rollDie()
    {
        return Random.Next(1, numSides);
    }
}
public class RollingDice
{
    public static void Main()
    {
        int dieOneVal;
        int dieTwoVal;
        int count = 0; 

        Die dieOne = new Die(8);
        Die dieTwo = new Die(8);

        do
        {
            dieOneVal = dieOne.rollDie();
            dieTwoVal = dieTwo.rollDie();

            Console.WriteLine("Rolling dice - Die 1: " + dieOneVal + " Die 2: " + dieTwoVal);

            count++;
        }
        while (dieOneVal != 1 && dieTwoVal !=1);

        Console.WriteLine("It took " + count + " rolls to get snake eyes!"); 
    }
}
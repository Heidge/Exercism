using System;

public class Player
{
    public int RollDie()
    {
        Random number = new Random();
        return number.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        Random spellStrength = new Random();
        return spellStrength.NextDouble();
    }
}

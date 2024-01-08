using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[7] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[6];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[6] = birdsPerDay[6] + 1;
	}

    public bool HasDayWithoutBirds()
    {
        foreach (int day in birdsPerDay)
        {
			if (day == 0)
                return true;
		} 
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            count = count + birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
		int count = 0;
		foreach (int day in birdsPerDay)
		{
            if (day >= 5)
                count = count + 1;
		}
		return count;
	}
}

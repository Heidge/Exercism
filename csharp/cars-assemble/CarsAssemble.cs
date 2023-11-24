using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double succesRate = 0;

        if (speed >= 1 && speed <= 4)
            succesRate = 100;
        else if (speed >= 5 && speed <= 8)
            succesRate = 90;
        else if (speed == 9)
            succesRate = 80;
        else if (speed == 10)
            succesRate = 77;
        
        return succesRate / 100;
	}
    public static double ProductionRatePerHour(int speed) => (speed * SuccessRate(speed)) * 221;
    public static int WorkingItemsPerMinute(int speed) => Convert.ToInt32(ProductionRatePerHour(speed)) / 60;
}

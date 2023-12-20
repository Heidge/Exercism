using System;

class RemoteControlCar
{
    public int Battery = 100;
    public int Meters = 0;

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {Meters} meters";

    public string BatteryDisplay()
    {
        if (Battery == 0)
            return "Battery empty";
        else
            return $"Battery at {Battery}%";
    }

    public void Drive()
    {
        if (Battery > 0)
        {
			Meters += 20;
			Battery -= 1;
		}
        
    }
}

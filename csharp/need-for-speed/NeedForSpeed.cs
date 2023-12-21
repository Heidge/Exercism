using System;

class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    public int meters = 0;
    public int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => battery == 0 || batteryDrain > 50 ? true : false;

    public int DistanceDriven() => meters;

    public void Drive()
    {
		if (this.battery - this.batteryDrain >= 0)
	        this.meters += this.speed;
            this.battery -= this.batteryDrain;
	}

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);

}

class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        float speedFloat = (float)car.speed;
        float batteryDrainFloat = (float)car.batteryDrain;

		if ((batteryDrainFloat * (this._distance / speedFloat) > 100))
            return false;
        return true;
    }
}

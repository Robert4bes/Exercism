class RemoteControlCar
{
    private int _batteryPercentage = 100;
    private int _distanceInMeters = 0;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distanceInMeters} meters";

    public string BatteryDisplay() => _batteryPercentage > 0 ? $"Battery at {_batteryPercentage}%" : "Battery empty";

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _distanceInMeters += 20;
            _batteryPercentage -= 1;
        }
    }
}

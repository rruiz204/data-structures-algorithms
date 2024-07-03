namespace dotnet_dsa.fundamentals;

public interface IVehicle
{
  void Start();
  void Stop();
  int MaxSpeed { get; }
}

public enum BatteryLevelEnum
{
  High,
  Medium,
  Low,
}

public interface IElectric
{
  void Charge();
  BatteryLevelEnum BatteryLevel { get; set; }
}


class ElectricCar(BatteryLevelEnum batteryLevel) : IVehicle, IElectric
{
  public BatteryLevelEnum BatteryLevel { get; set; } = batteryLevel;
  public int MaxSpeed => 180;

  public void Start()
  {

  }

  public void Stop()
  {

  }

  public void Charge()
  {

  }
}
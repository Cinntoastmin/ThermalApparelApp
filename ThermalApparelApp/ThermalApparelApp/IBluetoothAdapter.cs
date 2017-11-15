using System;
namespace ThermalApparelApp
{
    public delegate void TemperatureChangedHandler(int newTemp);
    public interface IBluetoothAdapter
    {

        event TemperatureChangedHandler TemperatureReceived;
    }
}

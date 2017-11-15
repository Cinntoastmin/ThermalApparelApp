using System;
using Plugin.BluetoothLE;

namespace ThermalApparelApp.iOS
{
    public class BluetoothAdapter : IBluetoothAdapter
    {


        public BluetoothAdapter()
        {
        }

        public event TemperatureChangedHandler TemperatureReceived;
    }
}

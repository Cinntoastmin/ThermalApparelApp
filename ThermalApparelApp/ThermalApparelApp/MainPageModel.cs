using System;
using Xamarin.Forms;

namespace ThermalApparelApp
{
    public class MainPageModel
    {
        private static MainPageModel model;
        public IBluetoothAdapter bluetooth {
            get;
            private set;
        }

        private int temperature;

        private MainPageModel()
        {

            bluetooth = DependencyService.Get<IBluetoothAdapter>();
            bluetooth.TemperatureReceived += t =>
            {
                temperature = t;
            };
        }


        /// <summary>
        /// Create this instance.
        /// </summary>
        /// <returns>The create.</returns>
        public static MainPageModel create() {
            if (model == null) {
                model = new MainPageModel();
            }
            return model;
        }
    }
}

/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates {
    class Subject {
        string temp, pressure, humidity;

        public delegate void Notify(object sender, EventArgs args);
        public event Notify handler; // a real event handler

        private void onValueChanged(WeatherDataEventArgs wdArgs) {
            if (handler != null) handler(this, wdArgs);
        }

        public void changeTemp(string temp) {
            this.temp = temp;
            onValueChanged(new WeatherDataEventArgs(ValueType.TEMP_CHANGED, temp));
        }

        public void changePressure(string pressure) {
            this.pressure = pressure;
            onValueChanged(new WeatherDataEventArgs(ValueType.PRESSURE_CHANGED, pressure));
        }

        public void changeHumidity(string humidity) {
            this.humidity = humidity;
            onValueChanged(new WeatherDataEventArgs(ValueType.HUMIDITY_CHANGED, humidity));
        }
    }
}

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

        public delegate void notify(Event e);
        public event notify handler; // a real event handler

        public void changeTemp(string temp) {
            this.temp = temp;
            handler(new ObserverEvent(EventType.TEMP_CHANGED, temp));
        }

        public void changePressure(string pressure) {
            this.pressure = pressure;
            handler(new ObserverEvent(EventType.PRESSURE_CHANGED, pressure));
        }

        public void changeHumidity(string humidity) {
            this.humidity = humidity;
            handler(new ObserverEvent(EventType.HUMIDITY_CHANGED, humidity));
        }
    }
}

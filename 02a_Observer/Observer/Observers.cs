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

namespace Observer {
    class TempObserver : IObserver {
        public void update(Event e) {
            ObserverEvent oe = (ObserverEvent)e;
            if (oe.eventType == EventType.TEMP_CHANGED) Console.WriteLine("NEW TEMP: {0}", oe.message);
        }
    }

    class PressureObserver : IObserver {
        public void update(Event e) {
            ObserverEvent oe = (ObserverEvent)e;
            if (oe.eventType == EventType.PRESSURE_CHANGED) Console.WriteLine("NEW PRESSURE: {0}", oe.message);
        }
    }

    class HumidityObserver : IObserver {
        public void update(Event e) {
            ObserverEvent oe = (ObserverEvent)e;
            if (oe.eventType == EventType.HUMIDITY_CHANGED) Console.WriteLine("NEW HUMIDITY: {0}", oe.message);
        }
    }
}

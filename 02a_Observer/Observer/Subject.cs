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
    class Subject {

        List<Observer> observers = new List<Observer>();
        string temp, pressure, humidity; 

        public void registerObserver(Observer observer) {
            observers.Add(observer);
        }

        public void removeObserver(Observer observer) {
            observers.Remove(observer);
        }

        public void notifyObservers(Event e) {
            foreach(Observer o in observers) {
                o.update(e);
            }
        }

        public void changeTemp(string temp) {
            this.temp = temp;
            notifyObservers(new ObserverEvent(EventType.TEMP_CHANGED, temp));
        }

        public void changePressure(string pressure) {
            this.pressure = pressure;
            notifyObservers(new ObserverEvent(EventType.PRESSURE_CHANGED, pressure));
        }

        public void changeHumidity(string humidity) {
            this.humidity = humidity;
            notifyObservers(new ObserverEvent(EventType.HUMIDITY_CHANGED, humidity));
        }
    }
}

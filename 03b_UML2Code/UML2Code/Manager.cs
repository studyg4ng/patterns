/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;

namespace UML2Code {
    class Manager : ISubject
    {
        private static Manager _instance;
        private List<IObserver> _observers = new List<IObserver>();
        private List<Person> _persons = new List<Person>();

        private Manager() {}

        public void addPerson(Person person) {
            notifiyObserver(new PersonEventArgs(person, "added"));
            this._persons.Add(person);
        }

        public void removePerson(Person person) {
            notifiyObserver(new PersonEventArgs(person, "removed"));
            this._persons.Remove(person);
        }

        public int countPersons() {
            return this._persons.Count;
        }

        public List<Person>.Enumerator getPersons() {
            return this._persons.GetEnumerator();
        }

        public static Manager getInstance() {
            if(Manager._instance == null) Manager._instance = new Manager();
            return Manager._instance;
        }

        public void addObserver(IObserver observer) {
            this._observers.Add(observer);
        }

        public void removeObserver(IObserver observer) {
            _instance._observers.Remove(observer);
        }

        public void notifiyObserver(EventArgs args) {
            foreach(IObserver observer in _instance._observers) {
                observer.update(args);
            }
        }
    }
}

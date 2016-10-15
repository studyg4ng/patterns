/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;

namespace UML2Code {
    abstract class Person : IIdentifyable {
        private List<Address> _addresses = new List<Address>();
        private string _name;
        private int _age;
        private static int _idCount = 0; // weicht ab
        private int _id;

        public Person(string name, int age) {
            this._name = name;
            this._age = age;
            _idCount = _idCount++;
            _id = _idCount;
        }

        public int getID() {
            return _idCount;
        }

        public void addAdress(Address address) {
            this._addresses.Add(address);
        }

        public List<Address> getAddresses() {
            List<Address> shallowCopy = new List<Address>();
            foreach (Address address in this._addresses)
            {
                shallowCopy.Add(address);
            }
            return shallowCopy; // how to deep copy/enumerator/properties locken? ask mr. naderlinger
        }

        public void removeAddress(Address address) {
            this._addresses.Remove(address);
        }

        public void setName(string name) {
            this._name = name;
        }

        public string getName() {
            return this._name;
        }

        public void setAge(int age) {
            this._age = age;
        }

        public int getAge() {
            return this._age;
        }
    }
}

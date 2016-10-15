/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;

namespace UML2Code
{
    class PersonEventArgs : EventArgs // weicht ab
    {
        public Person person;
        public string methodName; 

        public PersonEventArgs(Person person, string methodName) {
            this.person = person;
            this.methodName = methodName;
        }
    }
}

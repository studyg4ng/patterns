/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;

namespace UML2Code
{
    abstract class Person
    {
        List<Address> addresses = new List<Address>();
        private string name;
        private uint age;
    }
}

/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML2Code
{
    static class Program
    {
        static void Main()
        {
            WStrategy p = new Procrastination();
            p.doWork();
            Console.ReadKey();
        }
    }
}

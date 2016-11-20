/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimUDuck_initial
{
    public interface ISwimBehaviour
    {
        void swim();
    }

    class Swim : ISwimBehaviour
    {
        public void swim()
        {
            Console.WriteLine("SWIM SWIM SWIM");
        }
    }

    class NoSwim : ISwimBehaviour
    {
        public void swim()
        {
            Console.WriteLine("I can't swim :(");
        }
    }
}

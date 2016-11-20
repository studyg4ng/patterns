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
    public interface IFlyBehaviour
    {
        void fly();
    }

    class Fly : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I can FLY!!");
        }
    }

    class NoFly : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}

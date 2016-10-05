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
    public interface IQuackBehaviour
    {
        void quack();
    }

    class Quack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("I can quack!!!");
        }
    }

    class MuteQuack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("I can't quack!");
        }
    }
}

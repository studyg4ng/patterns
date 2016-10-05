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
    class Program
    {
        static void Main(string[] args)
        {
            //Mallard
            Console.WriteLine("------Mallard Duck Specs: \n");
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.QuackBehaviour = new MuteQuack();
            mallard.performQuack();
            mallard.performFly();
            mallard.performSwim();
            mallard.display();
            Console.WriteLine();

            //ReadHead
            Console.WriteLine("------RedheadDuck Duck Specs: \n");
            Duck redHead = new RedheadDuck();
            redHead.performSwim();
            redHead.performFly();
            redHead.performQuack();
            redHead.display();

            Console.In.ReadLine();
        }
    }
}

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

    abstract class Duck
    {
        private IQuackBehaviour quackBehaviour;
        private IFlyBehaviour flyBehaviour;
        private ISwimBehaviour swimBehaviour;

        public IQuackBehaviour QuackBehaviour
        {
            get { return quackBehaviour; }
            set { this.quackBehaviour = value; }
        }

        public IFlyBehaviour FlyBehaviour
        {
            get { return flyBehaviour; }
            set { this.flyBehaviour = value; }
        }

        public ISwimBehaviour SwimBehaviour
        {
            get { return swimBehaviour; }
            set { this.swimBehaviour = value; }
        }

        public abstract void display(); // requires implementation

        public Duck(IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehaviour, ISwimBehaviour swimBehaviour)
        {
            this.quackBehaviour = quackBehaviour;
            this.flyBehaviour = flyBehaviour;
            this.swimBehaviour = swimBehaviour;
        }

        public void performSwim()
        {
            this.swimBehaviour.swim();
        }

        public void performQuack()
        {
            this.quackBehaviour.quack();
        }

        public void performFly()
        {
            this.flyBehaviour.fly();
        }
    }

    class MallardDuck : Duck
    {
        public MallardDuck() : base(new Quack(), new Fly(), new Swim())
        {
        }

        public override void display()
        {
            Console.Out.WriteLine("Mallard");
        }
    }

    class RedheadDuck : Duck
    {
        public RedheadDuck() : base(new MuteQuack(), new NoFly(), new NoSwim())
        {
        }

        public override void display()
        {
            Console.Out.WriteLine("RedheadDuck");
        }
    }
}

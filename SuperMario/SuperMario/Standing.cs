using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMario {
    class Standing : IHeroState {
        public IHeroState handleInput(ConsoleKey key, Hero hero) {
            switch(key) {
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Ducking");
                    return new Ducking();
                case ConsoleKey.UpArrow:
                    Console.WriteLine("Jumping");
                    return new Jumping();
                default:
                    return this;
            }
        }
    }
}

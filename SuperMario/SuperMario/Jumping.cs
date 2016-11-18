using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMario {
    class Jumping : IHeroState {
        public IHeroState handleInput(ConsoleKey key, Hero hero) {
            if (key == ConsoleKey.DownArrow) {
                Console.WriteLine("Diving on enemy!");
                return new Diving();
            }
            return this; // default case
        }
    }
}

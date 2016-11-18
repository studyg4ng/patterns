using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMario {
    class Ducking : IHeroState {
        public IHeroState handleInput(ConsoleKey key, Hero hero) {
            if(key == ConsoleKey.UpArrow) {
                Console.WriteLine("Stand Up");
                return new Standing();
            }
            return this;
        }
    }
}

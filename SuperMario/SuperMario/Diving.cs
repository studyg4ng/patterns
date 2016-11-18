using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SuperMario {
    class Diving : IHeroState {
        public IHeroState handleInput(ConsoleKey key, Hero hero) {
            Console.WriteLine("Killed enemy. Stand.");
            return new Standing();
        }
    }
}

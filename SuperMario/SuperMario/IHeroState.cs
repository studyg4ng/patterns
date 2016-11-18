using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMario {
    interface IHeroState {
        IHeroState handleInput(ConsoleKey key, Hero hero);
    }
}

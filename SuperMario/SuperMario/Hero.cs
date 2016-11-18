using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMario {
    class Hero {
        private IHeroState _state = new Standing();

        public void handleInput(ConsoleKey key) {
            IHeroState targetState = _state.handleInput(key, this);
            _state = targetState;
        }
    }
}

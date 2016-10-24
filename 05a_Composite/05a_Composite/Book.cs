using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite {
    class Book : IComponent {
        public void add(IComponent component) {
            throw new NotImplementedException();
        }

        public void operation() {
            throw new NotImplementedException();
        }

        public void remove(IComponent component) {
            throw new NotImplementedException();
        }
    }
}

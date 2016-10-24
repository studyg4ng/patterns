using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite {
    class List : IComponent {
        private List<IComponent> _list = new List<IComponent>();

        public void add(IComponent component) {
            this._list.Add(component);
        }

        public void remove(IComponent component) {
            this._list.Remove(component);
        }
        public void operation() {
            throw new NotImplementedException();
        }
    }
}

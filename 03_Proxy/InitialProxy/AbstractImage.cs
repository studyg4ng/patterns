using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Net;

namespace InitialProxy
{
    public abstract class AbstractImage
    {
        private Image img;

        public virtual Image getImage(string url) {
            return this.img;
        }
    }
}

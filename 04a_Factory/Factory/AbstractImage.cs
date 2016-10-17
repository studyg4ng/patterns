/*1510601027 fhs38532
  Thomas Siller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Net;

namespace Factory
{
    public abstract class AbstractImage
    {
        private Image _img;

        public virtual Image getImage() {
            return this._img;
        }
    }
}

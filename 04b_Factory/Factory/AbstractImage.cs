/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

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

        public delegate void Notify(object sender, EventArgs args);
        public Notify onImageLoaded;

        public virtual Image getImage() {
            return this._img;
        }
    }
}

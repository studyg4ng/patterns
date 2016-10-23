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
using System.Threading;
using System.ComponentModel;

namespace Factory
{
    public class ImageFactory
    {
        private static ImageFactory _instance;
        private ImageFactory() {}

        public static ImageFactory getInstance() {
            if(ImageFactory._instance == null) return ImageFactory._instance = new ImageFactory();
            return ImageFactory._instance;
        }

        public AbstractImage createImage(string url) {
            if(url.Substring(0, 4) == "http") return new ProxyImage(url);
            else return new RealImage(url);
        }
    }
}

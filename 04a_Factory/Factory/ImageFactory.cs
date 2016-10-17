/*1510601027 fhs38532
  Thomas Siller*/

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
    public static class ImageFactory
    {
        public static AbstractImage createImage(string url, ProgressChangedEventHandler pceh) {
            if (url.Substring(0, 4) == "http") return new ProxyImage(url, pceh);
            else return new RealImage(url);
        }
    }
}

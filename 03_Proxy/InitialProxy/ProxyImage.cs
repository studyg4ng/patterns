using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Net;

namespace InitialProxy
{
    public class ProxyImage : AbstractImage
    {
        private RealImage realImage;

        public override Image getImage(string url) {
            this.realImage = new RealImage(url);
            return realImage.getImage();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Net;
using System.Threading;

namespace InitialProxy
{
    public class RealImage : AbstractImage
    {
        protected readonly String url;
        private Image img;

        public RealImage(String url)
        {
            this.url = url;
        }

        public Image getImage()
        {
            if (img == null)
            {
                Thread.Sleep(1000);
                WebRequest requestPic = WebRequest.Create(url);
                WebResponse responsePic = requestPic.GetResponse();
                img = Image.FromStream(responsePic.GetResponseStream());
            }
            return img;
        }
    }
}

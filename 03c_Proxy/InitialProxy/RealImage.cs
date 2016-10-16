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

namespace InitialProxy
{
    public class RealImage : AbstractImage
    {
        protected readonly String _url;
        private Image _img;

        public RealImage(String url)
        {
            this._url = url;
        }

        public override Image getImage()
        {
            if(this._img == null) {
                Thread.Sleep(1000);
                WebRequest requestPic = WebRequest.Create(this._url);
                WebResponse responsePic = requestPic.GetResponse();
                this._img = Image.FromStream(responsePic.GetResponseStream());
            }
            return this._img;
        }
    }
}

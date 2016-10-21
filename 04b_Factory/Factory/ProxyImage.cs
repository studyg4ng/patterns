/*1510601027 fhs38532
  Thomas Siller
  -------------------
  1510601032 fhs38596
  Patrick Obermüller*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Net;

namespace Factory
{
    public class ProxyImage : AbstractImage
    {
        private Image _loadImage = Image.FromFile(@"../../WAITING.jpg");
        private RealImage _realImage;
        private BackgroundWorker _bgw;
        private Boolean _loaded = false;

        public ProxyImage(string url) {
            this._realImage = new RealImage(url);
            this._bgw = new BackgroundWorker();
            this._bgw.DoWork += this.loadRealImage;
        }

        public void loadRealImage(object sender, EventArgs e) {
            this._realImage.getImage();
            this._loaded = true;
            base.onImageLoaded(this, null);
        }

        public override Image getImage() {
            if(this._loaded) {
                return this._realImage.getImage();
            } else {
                this._bgw.RunWorkerAsync();
                return this._loadImage;
            }
        }
    }
}
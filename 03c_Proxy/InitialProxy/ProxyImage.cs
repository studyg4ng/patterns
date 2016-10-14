using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Net;

namespace InitialProxy
{
    public class ProxyImage : AbstractImage
    {
        private Image _loadImage = Image.FromFile(@"../../WAITING.jpg");
        private RealImage _realImage;
        private BackgroundWorker _bgw;
        private Boolean _loaded = false;

        public ProxyImage(string url, ProgressChangedEventHandler pceh) {
            this._realImage = new RealImage(url);
            this._bgw = new BackgroundWorker();
            this._bgw.WorkerReportsProgress = true;
            this._bgw.DoWork += new DoWorkEventHandler(this.loadImage);
            this._bgw.ProgressChanged += pceh;
            this._bgw.RunWorkerAsync();
            
        }

        public void loadImage(object sender, DoWorkEventArgs e) {
            this._realImage.getImage();
            this._loaded = true;
            this._bgw.ReportProgress(100);
        }

        public override Image getImage() {
            return this._loaded ? this._realImage.getImage() : this._loadImage;
            /*if(this._realImage != null) {
                this._realImage = new RealImage(url);


                return Image.FromFile(@"../../WAITING.jpg");
            } else {
                return this._realImage.getImage();
            }*/
        }
    }
}


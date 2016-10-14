using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace InitialProxy
{
    public class MyPictureBox : PictureBox
    {
        AbstractImage myImage;

        public MyPictureBox(AbstractImage image)
            : base()
        {
            this.myImage = image;
        }

        public void update() {
        }

    }
}

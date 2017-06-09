using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOD2
{
    class Input : Component
    {
        private Link outputlink;

        public Link OutputLink
        {
            get { return outputlink; }
            set { outputlink = value; }
        }
        private Rectangle outputrect;

        public Rectangle OutPutRect
        {
            get { return outputrect; }
            set { outputrect = value; }
        }
        public Input(Image image, int Value, Rectangle rect, Link OutputLink)
            : base(image, Value, rect)
        {
            this.outputlink = OutputLink;
        }
        public override void calculateValue()
        {
            //todo
        }

    }
}

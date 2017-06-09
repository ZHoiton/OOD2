using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOD2
{
    class XOR : Component
    {
        private Link upperInputLink;

        public Link UpperInputLink
        {
            get { return upperInputLink; }
            set { upperInputLink = value; }
        }
        private Link lowerInputLink;

        public Link LowerInputLink
        {
            get { return lowerInputLink; }
            set { lowerInputLink = value; }
        }
        private Link outputLink;

        public Link OutputLink
        {
            get { return outputLink; }
            set { outputLink = value; }
        }
        private Rectangle upperinputrect;

        public Rectangle UpperInputRect
        {
            get { return upperinputrect; }
            set { upperinputrect = value; }
        }
        private Rectangle lowerinputrect;

        public Rectangle LowerInputRect
        {
            get { return lowerinputrect; }
            set { lowerinputrect = value; }
        }
        private Rectangle outputrect;

        public Rectangle OutPutRect
        {
            get { return outputrect; }
            set { outputrect = value; }
        }
        public XOR(Image image, int Value, Rectangle rect, Link UpperInputLink, Link LowerInputLink, Link OutputLink)
            : base(image, Value, rect)
        {
            this.upperInputLink = UpperInputLink;
            this.lowerInputLink = LowerInputLink;
            this.outputLink = OutputLink;
        }
        public override void calculateValue()
        {
            //todo
        }
    }
}

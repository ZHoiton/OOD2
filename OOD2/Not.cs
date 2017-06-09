using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOD2
{
    class Not:Component
    {
        private Link inputlink;

        public Link InputLink
        {
            get { return inputlink; }
            set { inputlink = value; }
        }
        private Link outputlink;

        public Link OutputLink
        {
            get { return outputlink; }
            set { outputlink = value; }
        }
        private Rectangle inputrect;

        public Rectangle InputRect
        {
            get { return inputrect; }
            set { inputrect = value; }
        }
        private Rectangle outputrect;

        public Rectangle OutPutRect
        {
            get { return outputrect; }
            set { outputrect = value; }
        }
        public Not(Image image, int Value,Rectangle rect,Link InputLink, Link OutputLink)
            :base(image,Value,rect)
        {
            this.inputlink = InputLink;
            this.outputlink = OutputLink;
        }
        public override void calculateValue()
        {
            //todo
        }
        
    }
}

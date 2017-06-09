using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOD2
{
    class Output : Component
    {
        private Link inputlink;

        public Link InputLink
        {
            get { return inputlink; }
            set { inputlink = value; }
        }
        private Rectangle inputrect;

        public Rectangle InputRect
        {
            get { return inputrect; }
            set { inputrect = value; }
        }
        public Output(Image image, int Value, Rectangle rect, Link InputLink)
            : base(image, Value, rect)
        {
            this.inputlink = InputLink;
        }
        public override void calculateValue()
        {
            //todo
        }

    }
}

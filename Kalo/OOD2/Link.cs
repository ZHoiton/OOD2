using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOD2
{
    class Link
    {
        private Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        

        private int[] curvePoints;

        public int[] CurvePoints
        {
            get { return curvePoints; }
            set { curvePoints = value; }
        }
        private int valuec;

        public int Value
        {
            get { return valuec; }
            set { valuec = value; }
        }
        private Component stratingC;

        public Component stratingComponent
        {
            get { return stratingC; }
            set { stratingC = value; }
        }
        private Component endingC;

        public Component endingComponent
        {
            get { return endingC; }
            set { endingC = value; }
        }
        public Link()
        {
            //todo
        }
        public void DrawLink(Graphics graphics)
        {
            //todo
        }
        public void ColculateValue()
        {
            //todo
        }
    }
}

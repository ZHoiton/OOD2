using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOD2
{
    abstract class Component
    {
        private Image imageC;

        public Image ImageC
        {
            get { return imageC; }
            set { imageC = value; }
        }
        private int valueC;

        public int ValueC
        {
            get { return valueC; }
            set { valueC = value; }
        }
        
        private Rectangle rectangleC;

        public Rectangle RegtangleC
        {
            get { return rectangleC; }
            set { rectangleC = value; }
        }
        public Component(Image image, int Value, Rectangle rect)
        {
            this.rectangleC = rect;
            this.imageC = image;
            this.valueC = Value;
        }
        public void DrawComponent(Graphics graphics)
        {

        }
        public  abstract void calculateValue();
        public Point getLocation()
        {
            Point point = new Point(rectangleC.Location.X, rectangleC.Location.Y);
            return point;
            //todo
        }
    }
}

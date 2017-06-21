using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOD2_project
{
    [Serializable]
    public class Link
    {
        public Component startComponent;
        public Component endComponent;
        public Color color;
        public int value;
        public Point[] curvePoints;

        public Link(Component StartComp, Component EndComp, Point[] points)
        {
            this.startComponent = StartComp;
            this.endComponent = EndComp;
             this.curvePoints = points;
        }
        /// <summary>
        /// Sets the value of the link
        /// </summary>
        public void setValue(int newValue)
        {
            this.value = newValue;
            endComponent.CalculateValue();
        }
        /// <summary>
        /// Returns a string with the value in this link..
        /// </summary>
        public int getValue()
        {
            return this.value;
        }
        /// <summary>
        /// Drawing the links between the components
        /// </summary>
        /// <param name="gr"></param>
        public void DrawLink(Graphics gr)
        {
                if (value == 1)
                {
                    gr.DrawLines(new Pen(Brushes.Red, 5), curvePoints);
                    gr.DrawString("Value: " + getValue(), new Font(FontFamily.GenericSerif, 10, FontStyle.Regular)
                        , Brushes.Red, ((startComponent.getPosition().X + endComponent.getPosition().X) / 2)
                        , ((startComponent.getPosition().Y + endComponent.getPosition().Y) / 2));
                }
                else
                  gr.DrawLines(new Pen(Brushes.Green, 5), curvePoints);
                  gr.DrawString("Value: " + getValue(), new Font(FontFamily.GenericSerif, 10, FontStyle.Regular)
                      , Brushes.Blue, ((startComponent.getPosition().X + endComponent.getPosition().X) / 2)
                      , ((startComponent.getPosition().Y + endComponent.getPosition().Y) / 2));
        }
    }
}

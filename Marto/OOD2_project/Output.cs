using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOD2_project
{
    [Serializable]
    public class Output : Component
    {
        public Link input;
        private bool isEmpty;
        private int inValue;
        Rectangle rect;

        public Output(Image image, int size, Point coordinates) 
            : base(image, size, coordinates) 
        {
            inValue = 0;
            isEmpty = true;
        }

        public void Clear()
        {
            input = null;
            isEmpty = true;
            inValue = 0;
        }

        public override void DrawComponent(Graphics gr)
        {
            try
            {
                rect = new Rectangle(point.X - 1, point.Y - 1, base.size, base.size);
                gr.DrawImage(base.image, rect);
                gr.DrawString(Convert.ToString(inValue), new Font(FontFamily.GenericSerif, 17, FontStyle.Bold), Brushes.Black, new Point(getPosition().X + 10, getPosition().Y + 10));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// return the position of the component
        /// </summary>
        /// <returns></returns>
        public override Point getPosition()
        {
            return base.getPosition();
        }

        /// <summary>
        /// sets the link connected to the component
        /// </summary>
        /// <param name="link"></param>
        public void setInput(ref Link link)
        {
            if (isEmpty)
            {
                input = link;
                this.inValue = link.value;
                isEmpty = false;
            }
            else
            {
                link = null;
                MessageBox.Show("You cannot have more than one input for this component!");
            }
        }

    }
}
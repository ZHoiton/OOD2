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
    public class Input : Component
    {
        private new int currentValue;
        private Link output;
        public bool isUsed { get; set; }

        public Input(Image image, int size, Point coordinates, int value)
            : base(image, size, coordinates)
        {
            //rect = new Rectangle(point.X - 1, point.Y - 1, base.size, base.size);
            this.currentValue = value;
            isUsed = false;
        }

        public void Clear()
        {
            isUsed = false;
            output = null;
        }

        public override void DrawComponent(Graphics gr)
        {
            try
            { 
                gr.DrawImage(base.image, base.rect);
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Link getOutput()
        {
            return output;
        }

        public int getValue()
        {
            return currentValue;
        }

        public override Point getPosition()
        {
            return base.getPosition();
        }

        public void setOutput(ref Link link)
        {
            if (!isUsed)
            {
                output = link;
                link.setValue(currentValue);
                isUsed = true;
            }
            else
            {
                MessageBox.Show("You cannot have more than 1 outputs for this input.");
                link = null;
            }
        }


    }
}
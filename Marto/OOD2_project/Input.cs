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
        private int currentvalue;
        private Link output;
        Rectangle rect;
        public bool isUsed { get; set; }

        public Input(Image image, int size, Point coordinates, int CurrentValue)
            : base(image, size, coordinates)
        {
            //rect = new Rectangle(point.X - 1, point.Y - 1, base.size, base.size);
            currentvalue = CurrentValue;
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
            return currentvalue;
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
                link.value = currentvalue;
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
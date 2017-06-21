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
    public class OR : Component
    {
         public Link upInput { get; set; }
        public Link lowInput { get; set; }
        public Link Output { get; set; }
        private int lowInValue;
        private int upperInValue;
        public int outValue;
        public bool hasLowIn = false;
        public bool hasUpperIn = false;
        public bool hasOut = false;

        public Rectangle upperLeft;
        public Rectangle lowerLeft;
        public Rectangle output;

        public OR(Image image, int size, Point coordinates)
            : base(image, size, coordinates)
        {
            //this.upInput = UpInput;
            //this.lowInput = LowInput;
            upperLeft = new Rectangle(base.rect.Left, base.rect.Top, 27, 27);
            lowerLeft = new Rectangle(base.rect.Left, base.rect.Top + (base.rect.Height / 2), 27, 27);
            output = new Rectangle(base.rect.Left + (base.rect.Width / 2), base.rect.Top, base.rect.Width/2,base.rect.Height);
        }

        public void Clear(Link l)
        {
            //remove all links related to a component
            if (l == this.Output)
            {
                hasOut = false;
                Output = null;
            }
            else if (l == this.lowInput)
            {
                hasLowIn = false;
                lowInValue = 0;
                outValue = upperInValue;
                lowInput = null;
            }
            else if (l == this.upInput)
            {
                hasUpperIn = false;
                upperInValue = 0;
                outValue = lowInValue;
                lowInput = null;
            }
        }

        public void Clear()
        {
             
             
                hasOut = false;
                Output = null;
             
                hasLowIn = false;
                lowInValue = 0;
                outValue = upperInValue;
                lowInput = null;
            
                hasUpperIn = false;
                upperInValue = 0;
                outValue = lowInValue;
              
        }

        public void DrawComponent(Graphics gr, Point p)
        {
            // draw the certain component on the work panel
        }

        public override Point getPosition()
        {
            return base.getPosition();
            // get the position of the component
        }

        public override void CalculateValue()
        {
            //calculate the value of lower and upper outputs
            this.outValue = this.upperInValue | this.lowInValue;
            Console.WriteLine("COMPONENT TO LINK OUTER");
            if (Output != null)
            {
                Console.WriteLine("COMPONENT TO LINK INNER");
                Output.setValue(this.outValue);
            }
        }

        public void setLowInput(ref Link l)
        {
            //set the the low input
            if (!hasLowIn)
            {
                lowInput = l;
                lowInValue = l.getValue();
                CalculateValue();
                hasLowIn = true;
            }
            else
            {
                MessageBox.Show("You cannot have more than 2 low Inputs!");
                l = null;
            }

        }

        public void setUpInput(ref Link l)
        {
            if (!hasUpperIn)
            {
                upInput = l;
                upperInValue = l.getValue();
                CalculateValue();
                hasUpperIn = true;
            }
            else
            {
                MessageBox.Show("You cannot have more than 2 upper Inputs!");
                l = null;
                //set the up input of the component
            }
        }

        public void setOutput(ref Link l)
        {
            if (!hasOut)
            {
                Output = l;
                CalculateValue();
                l.setValue(outValue);
                hasOut = true;
            }
            else
            {
                l = null;
                MessageBox.Show("You cannot have more than 2 low Inputs!");
            }
        }




    }
    
}

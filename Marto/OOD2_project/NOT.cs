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
    public class NOT: Component
    {
       
        public Link Input { get; set; }
         
        public Link Output { get; set; }
         
        private int InValue;
        public int outValue;
        
        public bool hasIn = false;
        public bool hasOut = false;

        public Rectangle inLeft;
        
        public Rectangle output;

        public NOT(Image image, int size, Point coordinates)
            : base(image, size, coordinates)
        {
            //this.upInput = UpInput;
            //this.lowInput = LowInput;
            inLeft = new Rectangle(base.rect.Left, base.rect.Top, 27, 54);
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
            
            else if (l == this.Input)
            {
                hasIn = false;
                InValue = 0;
              // outValue = upperInValue;

            }
        }

        public void Clear()
        {
                hasOut = false;
                Output = null;
             
                outValue = InValue;
                
                hasIn = false;
                InValue = 0;
               // outValue = upperInValue;
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
            if(this.InValue == 1){
               this.outValue = 0;
            }
            else if(this.InValue == 0)
            {
                this.outValue = 1;
            }
            if (Output != null)
            {
                Output.setValue(this.outValue);
            }
        }

      
        public void setUpInput(ref Link l)
        {
            if (!hasIn)
            {
                Input = l;
                InValue = l.getValue();
                CalculateValue();
                hasIn = true;
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


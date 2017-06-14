using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace OOD2_project
{
    [Serializable]
    public class Component
    {
        public Point point { get; set; }
        public Image image { get; set; }
        //private bool selected = false;
        public int currentValue;
        public int size { get; set; }
        public List<Link> links;
        public Rectangle rect;

        public Component(Image Image, int Size, Point coordinates)
        {
            this.point = coordinates;
            this.image = Image;
            this.size = Size;
            this.links = new List<Link>();
            rect = new Rectangle(point.X - 1, point.Y - 1, size + 50, size);
         }

        
        /// <summary>
        /// Returns the position of the component. It will be implemented in the sub classes
        /// </summary>
        /// <param name="p"></param>
        public virtual Point getPosition() { return point; }

        /// <summary>
        /// Returns a list of links..
        /// </summary>
        public List<Link> getLinks() { return links; }

        /// <summary>
        /// Drawing the components on the project design
        /// </summary>
        /// <param name="gr"></param>
        public virtual void DrawComponent(Graphics gr)
        {
            try
            {
                gr.DrawImage(image, rect);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //filler method to allow calls to CalculateValue() in child classes generalized as a Component subclass
        public virtual void CalculateValue() { }

    }

}

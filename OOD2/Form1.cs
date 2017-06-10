using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD2
{
    public partial class Form1 : Form
    {

        private Image selectedImage;
        private string selectedComponent;
        private bool isSelected = false; //To show that there is a selected component..
        private Point point;


        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pbInput0_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbInput0.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbInput0.Image;
            selectedComponent = "input0";
            pbInput0.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
            pbAnd.BorderStyle = BorderStyle.None;
            pbOr.BorderStyle = BorderStyle.None;
            pbXor.BorderStyle = BorderStyle.None;
            pbNot.BorderStyle = BorderStyle.None;
            pbLink.BorderStyle = BorderStyle.None;
        }

        private void workPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void workPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedImage != null)
            {
                point = workPanel.PointToClient(new Point(e.X, e.Y));
                this.workPanel.Invalidate();
            }
        }

        private void pbInput0_MouseUp_1(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbInput0.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.workPanel.AllowDrop = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;

namespace OOD2_project
{
    public partial class Form1 : Form
    {
        List<Point> pointsList;
        private Image selectedImage;
        private string selectedComponent;
        private bool isSelected = false; //To show that there is a selected component..
        public Project project;
        private Point point;
        private Component startComponent;
        private Component endComponent;
        private int InputToBeRemovedValue = 2;
        Graphics gr;
        Link linkref;
        List<Link> listOfLinks;
        private Point[] points;
        private bool linkActivate;
        private bool linkSelected = true;
        private bool isComponentRemoved = false;

        public Form1()
        {
            InitializeComponent();
            pointsList = new List<Point>();
            listOfLinks = new List<Link>();
            this.project = new Project(workPanel.Height, workPanel.Width);

        }

        private void workPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        //Drawing the component on the workPanel..
        private void workPanel_Paint(object sender, PaintEventArgs e)
        {
            gr = e.Graphics;
            if (isSelected)
            {
                try
                {
                    if (!isComponentRemoved)
                    {
                        switch (selectedComponent)
                        {
                            case "input0":   // CUrrent flow added...
                                if (!this.project.checkOverlap(point))
                                {
                                    this.project.listComponents.Add(new Input(selectedImage,
                                       (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width + 80)), point, 0));
                                }
                                else
                                    MessageBox.Show("Components cannot overlap!");
                                break;

                            case "input1":
                                if (!this.project.checkOverlap(point))
                                {
                                    this.project.listComponents.Add(new Input(selectedImage,
                                        (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width + 80)), point, 1));
                                    isSelected = false;
                                }
                                else
                                    MessageBox.Show("Components cannot overlap!");

                                break;

                            case "OR":
                                if (!this.project.checkOverlap(point))
                                {
                                    this.project.listComponents.Add(new OR(selectedImage,
                                        (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width + 80)), point));
                                }
                                else
                                    MessageBox.Show("Components cannot overlap!");
                                break;

                            case "XOR":
                                if (!this.project.checkOverlap(point))
                                {
                                    this.project.listComponents.Add(new XOR(selectedImage
                                        , (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width + 80)), point));
                                }
                                else
                                    MessageBox.Show("Components cannot overlap!");
                                break;

                            case "NOT":
                                if (!this.project.checkOverlap(point))
                                {
                                    this.project.listComponents.Add(new NOT(selectedImage,
                                        (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width + 80)), point));
                                }
                                else
                                    MessageBox.Show("Components cannot overlap!");
                                break;

                            case "AND":
                                if (!this.project.checkOverlap(point))
                                {
                                    this.project.listComponents.Add(new And(selectedImage
                                        , (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width + 80)), point));
                                }
                                else
                                    MessageBox.Show("Components cannot overlap!");
                                break;

                            case "output":
                                if (!this.project.checkOverlap(point))
                                {
                                    this.project.listComponents.Add(new Output(selectedImage,
                                        (this.workPanel.Width - (this.workPanel.Width - selectedImage.Width + 80)), point));
                                }
                                else
                                    MessageBox.Show("Components cannot overlap!");
                                break;
                        }
                    }
                }
                catch (Exception exeption)
                {
                    Console.WriteLine(exeption.Message);
                }

            }
            if (linkActivate && endComponent != null)
            {
                if (linkref != null)
                    linkref.DrawLink(gr);

                pointsList = new List<Point>();
                startComponent = null;
                endComponent = null;
                linkActivate = false;
            }
            this.project.panelHeight = Convert.ToInt32(this.workPanel.Size.Height);
            this.project.panelWidth = Convert.ToInt32(this.workPanel.Size.Width);

            foreach (Component com in this.project.listComponents)
            {
                com.DrawComponent(gr);
            }
            foreach (Link c in this.project.listLinks)
            {
                c.DrawLink(gr);
            }
            isComponentRemoved = false;
        }
        private void pbInput0_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbInput0.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbInput0.Image;
            selectedComponent = "input0";
            pbInput0.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
            pbInput1.BorderStyle = BorderStyle.None;
            pbAnd.BorderStyle = BorderStyle.None;
            pbXor.BorderStyle = BorderStyle.None;
            pbNot.BorderStyle = BorderStyle.None;
            pbLink.BorderStyle = BorderStyle.None;
        }


        private void pbInput1_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbInput1.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbInput1.Image;
            selectedComponent = "input1";
            pbInput1.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
            pbInput0.BorderStyle = BorderStyle.None;
            pbAnd.BorderStyle = BorderStyle.None;
            pbXor.BorderStyle = BorderStyle.None;
            pbNot.BorderStyle = BorderStyle.None;
            pbLink.BorderStyle = BorderStyle.None;
        }

        private void pbOR_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbOR.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbOR.Image;
            selectedComponent = "OR";
            pbOR.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
            pbInput0.BorderStyle = BorderStyle.None;
            pbAnd.BorderStyle = BorderStyle.None;
            pbXor.BorderStyle = BorderStyle.None;
            pbNot.BorderStyle = BorderStyle.None;
            pbLink.BorderStyle = BorderStyle.None;
        }

        private void pbOutput_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbOutput.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbOutput.Image;
            selectedComponent = "output";
            pbOutput.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
            pbInput0.BorderStyle = BorderStyle.None;
            pbAnd.BorderStyle = BorderStyle.None;
            pbXor.BorderStyle = BorderStyle.None;
            pbNot.BorderStyle = BorderStyle.None;
            pbLink.BorderStyle = BorderStyle.None;
        }



        private void pbAnd_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbAnd.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbAnd.Image;
            selectedComponent = "AND";
            pbAnd.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
            pbInput1.BorderStyle = BorderStyle.None;
            pbInput0.BorderStyle = BorderStyle.None;
            pbXor.BorderStyle = BorderStyle.None;
            pbNot.BorderStyle = BorderStyle.None;
            pbLink.BorderStyle = BorderStyle.None;
        }

        private void pbXOR_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbXor.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbXor.Image;
            selectedComponent = "XOR";
            pbXor.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
            pbInput1.BorderStyle = BorderStyle.None;
            pbAnd.BorderStyle = BorderStyle.None;
            pbInput0.BorderStyle = BorderStyle.None;
            pbNot.BorderStyle = BorderStyle.None;
            pbLink.BorderStyle = BorderStyle.None;
        }


        private void pbNOT_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            pbNot.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbNot.Image;
            selectedComponent = "NOT";
            pbNot.DoDragDrop(selectedImage, DragDropEffects.Copy);
            isSelected = true;
            pbInput1.BorderStyle = BorderStyle.None;
            pbAnd.BorderStyle = BorderStyle.None;
            pbXor.BorderStyle = BorderStyle.None;
            pbInput0.BorderStyle = BorderStyle.None;
            pbLink.BorderStyle = BorderStyle.None;
        }



        private void pbLink_MouseDown(object sender, MouseEventArgs e)
        {
            if (linkSelected)
            {
                MessageBox.Show("After pressing the link button first select a component then draw your path and select the other component.", "Message");
                linkSelected = false;
            }
            Cursor.Current = Cursors.Cross;
            pbLink.BorderStyle = BorderStyle.FixedSingle;
            selectedImage = pbLink.Image;
            selectedComponent = "link";
            pbLink.DoDragDrop(selectedImage, DragDropEffects.Copy);
            linkActivate = true;
            pbInput1.BorderStyle = BorderStyle.None;
            pbAnd.BorderStyle = BorderStyle.None;
            pbXor.BorderStyle = BorderStyle.None;
            pbNot.BorderStyle = BorderStyle.None;
            pbInput0.BorderStyle = BorderStyle.None;
        }


        private void workPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            label10.Visible = false;

        }

        //Checks where the client clicks on the workPanel and add the point to the listComponent..
        private void workPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (selectedImage != null)
            {
                point = workPanel.PointToClient(new Point(e.X, e.Y));
                this.workPanel.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.workPanel.AllowDrop = true;
        }

        private void pbInput0_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbInput0.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }

        private void pbInput1_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbInput1.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }

        private void pbOR_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbOR.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }


        private void pbAnd_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbAnd.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }


        private void pbOutput_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbOutput.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }
        private void pbSink_MouseUp(object sender, MouseEventArgs e)
        {

        }


        private void pbXOR_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbXor.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }



        private void pbNOT_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbNot.BorderStyle = BorderStyle.None;
            point = new Point(e.X, e.Y);
        }


        private void pbLink_MouseUp(object sender, MouseEventArgs e)
        {
            selectedImage = null;
            pbLink.BorderStyle = BorderStyle.None;
        }

        //Checks where the user click..
        private void workPanel_MouseClick(object sender, MouseEventArgs e)
        {
            //The point where the user click
            Point p = new Point(e.X, e.Y);

            if (linkActivate)
            {
                if (startComponent == null || endComponent == null)
                {
                    this.addConnectionPoints(p);
                }

            }
            if (e.Button == MouseButtons.Right)
            {
                if (this.project.listComponents.Count >= 1 && this.project.getComponent(p) != null)
                {
                    MenuItem[] menuItems;
                    if (this.project.getComponent(p) is Input)
                    {
                        menuItems = new MenuItem[4];
                        menuItems[3] = new MenuItem("Change input value");
                        menuItems[3].Click += new EventHandler((obj, evargs) => menuItem_click(obj, evargs, p, menuItems));
                        Input input = (Input)this.project.getComponent(p);
                        if (input.getValue() == 0)
                        {
                            InputToBeRemovedValue = 0;
                        }
                        if (input.getValue() == 1)
                        {
                            InputToBeRemovedValue = 1;
                        }
                    }
                    else
                    {
                        menuItems = new MenuItem[3];
                    }

                    menuItems[0] = new MenuItem("Remove Links");
                    menuItems[1] = new MenuItem("Remove Component");
                    menuItems[2] = new MenuItem("Clear Settings");

                    ContextMenu buttonMenu = new ContextMenu(menuItems);
                    buttonMenu.Show(workPanel, new System.Drawing.Point(p.X, p.Y));
                    menuItems[0].Click += new EventHandler((obj, evargs) => menuItem_click(obj, evargs, p, menuItems));
                    menuItems[1].Click += new EventHandler((obj, evargs) => menuItem_click(obj, evargs, p, menuItems));
                    menuItems[2].Click += new EventHandler((obj, evargs) => menuItem_click(obj, evargs, p, menuItems));

                }
            }

        }

        public void menuItem_click(object sender, EventArgs e, Point point, MenuItem[] menuItems)
        {
            //MenuItem Delete Link from the list with links
            if (sender == menuItems[0])
            {
                this.project.RemoveLink(this.project.getComponent(point));
                this.project.ClearSettings(this.project.getComponent(point));
            }
            //MenuItem Delete Component form the list with components
            else if (sender == menuItems[1])
            {
                this.project.RemoveLink(this.project.getComponent(point));
                this.project.RemoveComponent(this.project.getComponent(point));
            }
            //clears settings for the selected item so it can be reused
            else if (sender == menuItems[2])
            {
                this.project.ClearSettings(this.project.getComponent(point));
            }
            else
            {
                Point pointt = project.getComponent(point).point;
                this.project.RemoveLink(this.project.getComponent(point));
                this.project.RemoveComponent(project.getComponent(point));
                isComponentRemoved = true;
                workPanel.Invalidate();
                if (InputToBeRemovedValue == 1)
                {
                    this.project.listComponents.Add(new Input(pbInput0.Image,
                                        (this.workPanel.Width - (this.workPanel.Width - pbInput0.Image.Width + 80)), pointt, 0));
                }
                if (InputToBeRemovedValue == 0)
                {
                    this.project.listComponents.Add(new Input(pbInput1.Image,
                                        (this.workPanel.Width - (this.workPanel.Width - pbInput0.Image.Width + 80)), pointt, 1));
                }

            }
            // workPanel.Refresh();
            workPanel.Invalidate();
        }

        /// <summary>
        /// Collects and assigns points to the links
        /// </summary>
        /// <param name="p"></param>
        private void addConnectionPoints(Point p)
        {
            if (this.project.getComponent(p) != null)
            {
                if (startComponent == null)
                {
                    startComponent = this.project.getComponent(p);
                    if (startComponent is Output)
                    {
                        MessageBox.Show("You cannot start with Output");
                        startComponent = null;
                    }
                    else
                        pointsList.Add(new Point(p.X + 10, p.Y + 5));
                }
                else if (endComponent == null)
                {
                    endComponent = this.project.getComponent(p);

                    pointsList.Add(p);
                    points = pointsList.ToArray();
                    Link link = new Link(startComponent, endComponent, points);
                    linkref = link;
                    listOfLinks.Add(link);
                    //adjSpliter.setInput(con,Convert.ToInt32(con.setFlow()));
                    this.project.AddLink(ref link);
                    this.workPanel.Invalidate();
                }

            }
            else if (startComponent == null)
            {
                MessageBox.Show("You must select a starting component first");
            }
            else if (endComponent == null)
                pointsList.Add(p);

        }

        //private void btSet_Click(object sender, EventArgs e)
        //{
        //    numericUpDown1.Visible = false;
        //    label9.Visible = false;

        //    btSet.Visible = false;
        //     adjSpliter.setPercentage(Convert.ToDouble(numericUpDown1.Value));
        //     workPanel.Enabled = true;

        //}

        private void pbLink_MouseClick(object sender, MouseEventArgs e)
        {
            linkActivate = true;

        }

        private void pbLink_Click(object sender, EventArgs e)
        {
            linkActivate = true;
        }




        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.project.listComponents.Count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to save your current work?", "Save file ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveLoadManager.SaveAs(this.project);
                    this.project.listComponents.Clear();
                    this.project.listLinks.Clear();
                    this.isSelected = false;
                    //label10.Visible = false;
                    this.workPanel.Invalidate();
                }
                else
                {
                    this.project.listComponents.Clear();
                    this.project.listLinks.Clear();
                    this.isSelected = false;
                    this.workPanel.Invalidate();
                }

            }
            else
            {
                this.project.listComponents.Clear();
                this.project.listLinks.Clear();
                this.isSelected = false;
                this.workPanel.Invalidate();

            }
        }

        /// <summary>
        /// Method to Open a file with project
        /// </summary>
        public bool OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                BinaryFormatter bf = null;

                openFileDialog.Filter = "SimulatorExtension files (*.simex)|*.simex";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;


                fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                Project loadproject = (Project)(bf.Deserialize(fs));
                this.project = loadproject;
                this.project.listComponents = loadproject.listComponents;
                this.project.listLinks = loadproject.listLinks;
                return true;
            }
            else
                return false;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.project.listComponents.Count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to save your current work?", "Save file ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveLoadManager.SaveAs(this.project);
                    SaveLoadManager.OpenFile(ref this.project);
                    label10.Visible = false;
                    isSelected = true;
                    workPanel.Invalidate();
                }
                else
                    SaveLoadManager.OpenFile(ref this.project);
                label10.Visible = false;
                this.isSelected = true;
                workPanel.Invalidate();
            }
            else
            {
                SaveLoadManager.OpenFile(ref this.project);
                label10.Visible = false;
                this.isSelected = true;
                workPanel.Invalidate();
            }
            // workPanel.Invalidate();

        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveLoadManager.SaveAs(this.project);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.project.listComponents.Count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to save your current work?", "Save file ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveLoadManager.SaveAs(this.project);
                    this.Close();
                }
                else
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLoadManager.SaveAs(this.project);

        }


        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }




    }

}

        

     
        
        

        
       
        

        

        

       

    
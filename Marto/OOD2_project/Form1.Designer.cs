namespace OOD2_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.workPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.toolBox = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbOR = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbInput0 = new System.Windows.Forms.PictureBox();
            this.pbInput1 = new System.Windows.Forms.PictureBox();
            this.pbAnd = new System.Windows.Forms.PictureBox();
            this.pbXor = new System.Windows.Forms.PictureBox();
            this.pbNot = new System.Windows.Forms.PictureBox();
            this.pbLink = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPipe = new System.Windows.Forms.PictureBox();
            this.workPanel.SuspendLayout();
            this.toolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLink)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe)).BeginInit();
            this.SuspendLayout();
            // 
            // workPanel
            // 
            this.workPanel.BackColor = System.Drawing.Color.White;
            this.workPanel.Controls.Add(this.label10);
            this.workPanel.Location = new System.Drawing.Point(164, 29);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(815, 588);
            this.workPanel.TabIndex = 0;
            this.workPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.workPanel_DragDrop);
            this.workPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.workPanel_DragEnter);
            this.workPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.workPanel_MouseClick);
            this.workPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.workPanel_MouseDown);
            this.workPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.workPanel_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(152, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(578, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Drag a component here to begin constructing your pipeline.";
            // 
            // toolBox
            // 
            this.toolBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolBox.Controls.Add(this.label2);
            this.toolBox.Controls.Add(this.pbOutput);
            this.toolBox.Controls.Add(this.label1);
            this.toolBox.Controls.Add(this.pbOR);
            this.toolBox.Controls.Add(this.label8);
            this.toolBox.Controls.Add(this.label7);
            this.toolBox.Controls.Add(this.label6);
            this.toolBox.Controls.Add(this.label5);
            this.toolBox.Controls.Add(this.label4);
            this.toolBox.Controls.Add(this.label3);
            this.toolBox.Controls.Add(this.pbInput0);
            this.toolBox.Controls.Add(this.pbInput1);
            this.toolBox.Controls.Add(this.pbAnd);
            this.toolBox.Controls.Add(this.pbXor);
            this.toolBox.Controls.Add(this.pbNot);
            this.toolBox.Controls.Add(this.pbLink);
            this.toolBox.Location = new System.Drawing.Point(0, 27);
            this.toolBox.Name = "toolBox";
            this.toolBox.Size = new System.Drawing.Size(158, 603);
            this.toolBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Output";
            // 
            // pbOutput
            // 
            this.pbOutput.Image = ((System.Drawing.Image)(resources.GetObject("pbOutput.Image")));
            this.pbOutput.Location = new System.Drawing.Point(12, 527);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(84, 46);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOutput.TabIndex = 15;
            this.pbOutput.TabStop = false;
            this.pbOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbOutput_MouseDown);
            this.pbOutput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbOutput_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Or";
            // 
            // pbOR
            // 
            this.pbOR.ErrorImage = null;
            this.pbOR.Image = ((System.Drawing.Image)(resources.GetObject("pbOR.Image")));
            this.pbOR.Location = new System.Drawing.Point(12, 159);
            this.pbOR.Name = "pbOR";
            this.pbOR.Size = new System.Drawing.Size(84, 49);
            this.pbOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOR.TabIndex = 13;
            this.pbOR.TabStop = false;
            this.pbOR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbOR_MouseDown);
            this.pbOR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbOR_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Link";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Xor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Not";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "And";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Input 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Input 0";
            // 
            // pbInput0
            // 
            this.pbInput0.ErrorImage = null;
            this.pbInput0.Image = ((System.Drawing.Image)(resources.GetObject("pbInput0.Image")));
            this.pbInput0.Location = new System.Drawing.Point(12, 21);
            this.pbInput0.Name = "pbInput0";
            this.pbInput0.Size = new System.Drawing.Size(84, 44);
            this.pbInput0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInput0.TabIndex = 0;
            this.pbInput0.TabStop = false;
            this.pbInput0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbInput0_MouseDown);
            this.pbInput0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbInput0_MouseUp);
            // 
            // pbInput1
            // 
            this.pbInput1.Image = ((System.Drawing.Image)(resources.GetObject("pbInput1.Image")));
            this.pbInput1.Location = new System.Drawing.Point(12, 87);
            this.pbInput1.Name = "pbInput1";
            this.pbInput1.Size = new System.Drawing.Size(84, 44);
            this.pbInput1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInput1.TabIndex = 1;
            this.pbInput1.TabStop = false;
            this.pbInput1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbInput1_MouseDown);
            this.pbInput1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbInput1_MouseUp);
            // 
            // pbAnd
            // 
            this.pbAnd.ErrorImage = null;
            this.pbAnd.Image = ((System.Drawing.Image)(resources.GetObject("pbAnd.Image")));
            this.pbAnd.Location = new System.Drawing.Point(12, 236);
            this.pbAnd.Name = "pbAnd";
            this.pbAnd.Size = new System.Drawing.Size(84, 49);
            this.pbAnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnd.TabIndex = 2;
            this.pbAnd.TabStop = false;
            this.pbAnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbAnd_MouseDown);
            this.pbAnd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbAnd_MouseUp);
            // 
            // pbXor
            // 
            this.pbXor.Image = ((System.Drawing.Image)(resources.GetObject("pbXor.Image")));
            this.pbXor.Location = new System.Drawing.Point(12, 319);
            this.pbXor.Name = "pbXor";
            this.pbXor.Size = new System.Drawing.Size(84, 47);
            this.pbXor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbXor.TabIndex = 3;
            this.pbXor.TabStop = false;
            this.pbXor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbXOR_MouseDown);
            this.pbXor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbXOR_MouseUp);
            // 
            // pbNot
            // 
            this.pbNot.Image = ((System.Drawing.Image)(resources.GetObject("pbNot.Image")));
            this.pbNot.Location = new System.Drawing.Point(12, 394);
            this.pbNot.Name = "pbNot";
            this.pbNot.Size = new System.Drawing.Size(84, 45);
            this.pbNot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNot.TabIndex = 4;
            this.pbNot.TabStop = false;
            this.pbNot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbNOT_MouseDown);
            this.pbNot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbNOT_MouseUp);
            // 
            // pbLink
            // 
            this.pbLink.Image = ((System.Drawing.Image)(resources.GetObject("pbLink.Image")));
            this.pbLink.Location = new System.Drawing.Point(12, 465);
            this.pbLink.Name = "pbLink";
            this.pbLink.Size = new System.Drawing.Size(84, 46);
            this.pbLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLink.TabIndex = 5;
            this.pbLink.TabStop = false;
            this.pbLink.Click += new System.EventHandler(this.pbLink_Click);
            this.pbLink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbLink_MouseClick);
            this.pbLink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLink_MouseDown);
            this.pbLink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLink_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.saveAsToolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pbPipe
            // 
            this.pbPipe.Location = new System.Drawing.Point(23, 347);
            this.pbPipe.Name = "pbPipe";
            this.pbPipe.Size = new System.Drawing.Size(55, 42);
            this.pbPipe.TabIndex = 5;
            this.pbPipe.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 629);
            this.Controls.Add(this.toolBox);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.workPanel.ResumeLayout(false);
            this.workPanel.PerformLayout();
            this.toolBox.ResumeLayout(false);
            this.toolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLink)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.Panel toolBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbInput0;
        private System.Windows.Forms.PictureBox pbInput1;
        private System.Windows.Forms.PictureBox pbAnd;
        private System.Windows.Forms.PictureBox pbXor;
        private System.Windows.Forms.PictureBox pbNot;
        private System.Windows.Forms.PictureBox pbLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOR;
        private System.Windows.Forms.PictureBox pbPipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbOutput;
    }
}


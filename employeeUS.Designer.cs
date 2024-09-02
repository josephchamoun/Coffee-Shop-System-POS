namespace summer2
{
    partial class employeeUS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainpanel = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.hiredate = new MaterialSkin.Controls.MaterialLabel();
            this.role = new MaterialSkin.Controls.MaterialLabel();
            this.dob = new MaterialSkin.Controls.MaterialLabel();
            this.addresslb = new MaterialSkin.Controls.MaterialLabel();
            this.emaillb = new MaterialSkin.Controls.MaterialLabel();
            this.phonelb = new MaterialSkin.Controls.MaterialLabel();
            this.lastname = new MaterialSkin.Controls.MaterialLabel();
            this.firstname = new MaterialSkin.Controls.MaterialLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.empimage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empimage)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(279, 152);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(0, 24);
            this.materialLabel3.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 56);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::summer2.Properties.Resources.icons8_edit_16;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::summer2.Properties.Resources.icons8_delete_16;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BorderRadius = 25;
            this.mainpanel.Controls.Add(this.hiredate);
            this.mainpanel.Controls.Add(this.role);
            this.mainpanel.Controls.Add(this.dob);
            this.mainpanel.Controls.Add(this.addresslb);
            this.mainpanel.Controls.Add(this.emaillb);
            this.mainpanel.Controls.Add(this.phonelb);
            this.mainpanel.Controls.Add(this.lastname);
            this.mainpanel.Controls.Add(this.firstname);
            this.mainpanel.Controls.Add(this.guna2PictureBox1);
            this.mainpanel.Controls.Add(this.empimage);
            this.mainpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.mainpanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.mainpanel.FillColor3 = System.Drawing.Color.RosyBrown;
            this.mainpanel.FillColor4 = System.Drawing.Color.RosyBrown;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(10);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(487, 338);
            this.mainpanel.TabIndex = 11;
            // 
            // hiredate
            // 
            this.hiredate.AutoSize = true;
            this.hiredate.BackColor = System.Drawing.Color.Transparent;
            this.hiredate.Depth = 0;
            this.hiredate.Font = new System.Drawing.Font("Roboto", 11F);
            this.hiredate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hiredate.Location = new System.Drawing.Point(181, 213);
            this.hiredate.MouseState = MaterialSkin.MouseState.HOVER;
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(108, 24);
            this.hiredate.TabIndex = 28;
            this.hiredate.Text = "17-05-2004";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.BackColor = System.Drawing.Color.Transparent;
            this.role.Depth = 0;
            this.role.Font = new System.Drawing.Font("Roboto", 11F);
            this.role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.role.Location = new System.Drawing.Point(181, 293);
            this.role.MouseState = MaterialSkin.MouseState.HOVER;
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(84, 24);
            this.role.TabIndex = 27;
            this.role.Text = "Manager";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.BackColor = System.Drawing.Color.Transparent;
            this.dob.Depth = 0;
            this.dob.Font = new System.Drawing.Font("Roboto", 11F);
            this.dob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dob.Location = new System.Drawing.Point(181, 254);
            this.dob.MouseState = MaterialSkin.MouseState.HOVER;
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(108, 24);
            this.dob.TabIndex = 26;
            this.dob.Text = "17-05-2004";
            // 
            // addresslb
            // 
            this.addresslb.AutoSize = true;
            this.addresslb.BackColor = System.Drawing.Color.Transparent;
            this.addresslb.Depth = 0;
            this.addresslb.Font = new System.Drawing.Font("Roboto", 11F);
            this.addresslb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addresslb.Location = new System.Drawing.Point(181, 177);
            this.addresslb.MouseState = MaterialSkin.MouseState.HOVER;
            this.addresslb.Name = "addresslb";
            this.addresslb.Size = new System.Drawing.Size(95, 24);
            this.addresslb.TabIndex = 25;
            this.addresslb.Text = "Kfarhawra";
            // 
            // emaillb
            // 
            this.emaillb.AutoSize = true;
            this.emaillb.BackColor = System.Drawing.Color.Transparent;
            this.emaillb.Depth = 0;
            this.emaillb.Font = new System.Drawing.Font("Roboto", 11F);
            this.emaillb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emaillb.Location = new System.Drawing.Point(181, 139);
            this.emaillb.MouseState = MaterialSkin.MouseState.HOVER;
            this.emaillb.Name = "emaillb";
            this.emaillb.Size = new System.Drawing.Size(275, 24);
            this.emaillb.TabIndex = 24;
            this.emaillb.Text = "chamounjoseph78@gmail.com";
            // 
            // phonelb
            // 
            this.phonelb.AutoSize = true;
            this.phonelb.BackColor = System.Drawing.Color.Transparent;
            this.phonelb.Depth = 0;
            this.phonelb.Font = new System.Drawing.Font("Roboto", 11F);
            this.phonelb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.phonelb.Location = new System.Drawing.Point(181, 101);
            this.phonelb.MouseState = MaterialSkin.MouseState.HOVER;
            this.phonelb.Name = "phonelb";
            this.phonelb.Size = new System.Drawing.Size(98, 24);
            this.phonelb.TabIndex = 23;
            this.phonelb.Text = "81335243";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.BackColor = System.Drawing.Color.Transparent;
            this.lastname.Depth = 0;
            this.lastname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastname.Location = new System.Drawing.Point(181, 60);
            this.lastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(90, 24);
            this.lastname.TabIndex = 22;
            this.lastname.Text = "Chamoun";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.BackColor = System.Drawing.Color.Transparent;
            this.firstname.Depth = 0;
            this.firstname.Font = new System.Drawing.Font("Roboto", 11F);
            this.firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.firstname.Location = new System.Drawing.Point(181, 24);
            this.firstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(72, 24);
            this.firstname.TabIndex = 21;
            this.firstname.Text = "Joseph";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::summer2.Properties.Resources.icons8_three_dots_16;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(440, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(36, 32);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // empimage
            // 
            this.empimage.BackColor = System.Drawing.Color.Transparent;
            this.empimage.Image = global::summer2.Properties.Resources.No_Image_Available;
            this.empimage.ImageRotate = 0F;
            this.empimage.Location = new System.Drawing.Point(25, 24);
            this.empimage.Name = "empimage";
            this.empimage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.empimage.Size = new System.Drawing.Size(127, 123);
            this.empimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.empimage.TabIndex = 18;
            this.empimage.TabStop = false;
            // 
            // employeeUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.mainpanel);
            this.Name = "employeeUS";
            this.Size = new System.Drawing.Size(487, 338);
            this.contextMenuStrip1.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel mainpanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox empimage;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private MaterialSkin.Controls.MaterialLabel dob;
        private MaterialSkin.Controls.MaterialLabel addresslb;
        private MaterialSkin.Controls.MaterialLabel emaillb;
        private MaterialSkin.Controls.MaterialLabel phonelb;
        private MaterialSkin.Controls.MaterialLabel lastname;
        public MaterialSkin.Controls.MaterialLabel firstname;
        private MaterialSkin.Controls.MaterialLabel role;
        private MaterialSkin.Controls.MaterialLabel hiredate;
    }
}

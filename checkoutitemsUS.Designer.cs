namespace summer2
{
    partial class checkoutitemsUS
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
            this.mainpanel = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.price = new System.Windows.Forms.Label();
            this.mainlb = new System.Windows.Forms.Label();
            this.nbofitems = new System.Windows.Forms.Label();
            this.deletebtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.downarrow = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.uparrow = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.itempic = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itempic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.mainpanel.BorderRadius = 20;
            this.mainpanel.Controls.Add(this.deletebtn);
            this.mainpanel.Controls.Add(this.downarrow);
            this.mainpanel.Controls.Add(this.uparrow);
            this.mainpanel.Controls.Add(this.price);
            this.mainpanel.Controls.Add(this.mainlb);
            this.mainpanel.Controls.Add(this.nbofitems);
            this.mainpanel.Controls.Add(this.itempic);
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(354, 105);
            this.mainpanel.TabIndex = 6;
            this.mainpanel.Resize += new System.EventHandler(this.mainpanel_Resize);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.price.Location = new System.Drawing.Point(280, 65);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(70, 22);
            this.price.TabIndex = 28;
            this.price.Text = "5.75 $";
            // 
            // mainlb
            // 
            this.mainlb.BackColor = System.Drawing.Color.Transparent;
            this.mainlb.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.mainlb.Location = new System.Drawing.Point(115, 19);
            this.mainlb.MaximumSize = new System.Drawing.Size(210, 70);
            this.mainlb.Name = "mainlb";
            this.mainlb.Size = new System.Drawing.Size(210, 46);
            this.mainlb.TabIndex = 27;
            this.mainlb.Text = "Americano Passion Coffee";
            // 
            // nbofitems
            // 
            this.nbofitems.AutoSize = true;
            this.nbofitems.BackColor = System.Drawing.Color.Transparent;
            this.nbofitems.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbofitems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.nbofitems.Location = new System.Drawing.Point(115, 65);
            this.nbofitems.Name = "nbofitems";
            this.nbofitems.Size = new System.Drawing.Size(35, 22);
            this.nbofitems.TabIndex = 26;
            this.nbofitems.Text = "x 1";
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deletebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletebtn.Image = global::summer2.Properties.Resources.icons8_delete_ios_17_glyph_70;
            this.deletebtn.Location = new System.Drawing.Point(324, 3);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.deletebtn.Size = new System.Drawing.Size(26, 27);
            this.deletebtn.TabIndex = 35;
            // 
            // downarrow
            // 
            this.downarrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.downarrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.downarrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downarrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downarrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downarrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downarrow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.downarrow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.downarrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downarrow.Image = global::summer2.Properties.Resources.icons8_expand_arrow_16;
            this.downarrow.Location = new System.Drawing.Point(148, 81);
            this.downarrow.Name = "downarrow";
            this.downarrow.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.downarrow.Size = new System.Drawing.Size(18, 10);
            this.downarrow.TabIndex = 34;
            this.downarrow.Click += new System.EventHandler(this.downarrow_Click);
            // 
            // uparrow
            // 
            this.uparrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uparrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.uparrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.uparrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.uparrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.uparrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.uparrow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.uparrow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uparrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uparrow.Image = global::summer2.Properties.Resources.icons8_collapse_arrow_16;
            this.uparrow.Location = new System.Drawing.Point(148, 65);
            this.uparrow.Name = "uparrow";
            this.uparrow.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.uparrow.Size = new System.Drawing.Size(18, 10);
            this.uparrow.TabIndex = 33;
            this.uparrow.Click += new System.EventHandler(this.uparrow_Click);
            // 
            // itempic
            // 
            this.itempic.BackColor = System.Drawing.Color.Transparent;
            this.itempic.BorderRadius = 15;
            this.itempic.FillColor = System.Drawing.Color.Black;
            this.itempic.ImageRotate = 0F;
            this.itempic.Location = new System.Drawing.Point(3, 3);
            this.itempic.Name = "itempic";
            this.itempic.Size = new System.Drawing.Size(96, 98);
            this.itempic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itempic.TabIndex = 5;
            this.itempic.TabStop = false;
            // 
            // checkoutitemsUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.Controls.Add(this.mainpanel);
            this.Name = "checkoutitemsUS";
            this.Size = new System.Drawing.Size(354, 105);
            this.Resize += new System.EventHandler(this.checkoutitemsUS_Resize);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itempic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox itempic;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel mainpanel;
        private System.Windows.Forms.Label nbofitems;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label mainlb;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton uparrow;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton downarrow;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton deletebtn;
    }
}

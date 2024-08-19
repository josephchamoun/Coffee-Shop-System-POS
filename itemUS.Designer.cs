namespace summer2
{
    partial class itemUS
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
            this.mainpanel = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.addbtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.desclb = new System.Windows.Forms.Label();
            this.mainlb = new System.Windows.Forms.Label();
            this.pricelb = new System.Windows.Forms.Label();
            this.itempic = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itempic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.mainpanel.BorderRadius = 30;
            this.mainpanel.Controls.Add(this.addbtn);
            this.mainpanel.Controls.Add(this.desclb);
            this.mainpanel.Controls.Add(this.mainlb);
            this.mainpanel.Controls.Add(this.pricelb);
            this.mainpanel.Controls.Add(this.itempic);
            this.mainpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.mainpanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.mainpanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.mainpanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.mainpanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainpanel.Location = new System.Drawing.Point(0, 3);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(431, 256);
            this.mainpanel.TabIndex = 9;
            this.mainpanel.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // addbtn
            // 
            this.addbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.addbtn.BorderRadius = 20;
            this.addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.addbtn.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(26, 196);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(378, 43);
            this.addbtn.TabIndex = 28;
            this.addbtn.Text = "Add to billing";
            // 
            // desclb
            // 
            this.desclb.BackColor = System.Drawing.Color.Transparent;
            this.desclb.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.desclb.Location = new System.Drawing.Point(196, 85);
            this.desclb.MaximumSize = new System.Drawing.Size(210, 60);
            this.desclb.Name = "desclb";
            this.desclb.Size = new System.Drawing.Size(210, 60);
            this.desclb.TabIndex = 27;
            this.desclb.Text = "Americano Passion Coffee";
            this.desclb.Click += new System.EventHandler(this.desclb_Click);
            // 
            // mainlb
            // 
            this.mainlb.BackColor = System.Drawing.Color.Transparent;
            this.mainlb.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.mainlb.Location = new System.Drawing.Point(196, 19);
            this.mainlb.MaximumSize = new System.Drawing.Size(210, 70);
            this.mainlb.Name = "mainlb";
            this.mainlb.Size = new System.Drawing.Size(210, 66);
            this.mainlb.TabIndex = 26;
            this.mainlb.Text = "Americano Passion Coffee";
            this.mainlb.Click += new System.EventHandler(this.mainlb_Click);
            // 
            // pricelb
            // 
            this.pricelb.AutoSize = true;
            this.pricelb.BackColor = System.Drawing.Color.Transparent;
            this.pricelb.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pricelb.Location = new System.Drawing.Point(196, 144);
            this.pricelb.Name = "pricelb";
            this.pricelb.Size = new System.Drawing.Size(70, 22);
            this.pricelb.TabIndex = 25;
            this.pricelb.Text = "5.75 $";
            // 
            // itempic
            // 
            this.itempic.BackColor = System.Drawing.Color.Transparent;
            this.itempic.BorderRadius = 15;
            this.itempic.FillColor = System.Drawing.Color.Black;
            this.itempic.ImageRotate = 0F;
            this.itempic.Location = new System.Drawing.Point(18, 19);
            this.itempic.Name = "itempic";
            this.itempic.Size = new System.Drawing.Size(154, 147);
            this.itempic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itempic.TabIndex = 4;
            this.itempic.TabStop = false;
            // 
            // itemUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.mainpanel);
            this.Name = "itemUS";
            this.Size = new System.Drawing.Size(431, 260);
            this.Load += new System.EventHandler(this.itemUS_Load);
            this.Resize += new System.EventHandler(this.itemUS_Resize);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itempic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel mainpanel;
        private System.Windows.Forms.Label pricelb;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox itempic;
        private System.Windows.Forms.Label mainlb;
        private System.Windows.Forms.Label desclb;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addbtn;
    }
}

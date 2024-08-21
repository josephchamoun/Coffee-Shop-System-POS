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
            this.itempic = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.nbofitems = new System.Windows.Forms.Label();
            this.mainlb = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itempic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.mainpanel.BorderRadius = 20;
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
    }
}

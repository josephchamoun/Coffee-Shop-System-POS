namespace summer2
{
    partial class Roles
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
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.datelb = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.BorderRadius = 30;
            this.siticoneCustomGradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.siticoneCustomGradientPanel1.Controls.Add(this.label1);
            this.siticoneCustomGradientPanel1.Controls.Add(this.datelb);
            this.siticoneCustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.siticoneCustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.siticoneCustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.siticoneCustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(3, 0);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(400, 122);
            this.siticoneCustomGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 26);
            this.label1.TabIndex = 37;
            this.label1.Text = "Manager Role Description";
            // 
            // datelb
            // 
            this.datelb.AutoSize = true;
            this.datelb.BackColor = System.Drawing.Color.Transparent;
            this.datelb.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.datelb.Location = new System.Drawing.Point(59, 0);
            this.datelb.Name = "datelb";
            this.datelb.Size = new System.Drawing.Size(157, 38);
            this.datelb.TabIndex = 36;
            this.datelb.Text = "Manager";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::summer2.Properties.Resources.icons8_three_dots_16;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(346, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(36, 32);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 38;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.siticoneCustomGradientPanel1);
            this.Name = "Roles";
            this.Size = new System.Drawing.Size(402, 122);
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private System.Windows.Forms.Label datelb;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

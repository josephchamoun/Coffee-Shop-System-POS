namespace summer2
{
    partial class addemployeescard
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
            this.image = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneGroupBox1 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.addresstb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.emailtb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.phonetb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lntb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.fntb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.savebtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.combobox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.hiredatetb = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.dobtb = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.siticoneGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Transparent;
            this.image.Image = global::summer2.Properties.Resources.No_Image_Available;
            this.image.ImageRotate = 0F;
            this.image.Location = new System.Drawing.Point(23, 21);
            this.image.Name = "image";
            this.image.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.image.Size = new System.Drawing.Size(202, 197);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.picture_Click);
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.BackColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.siticoneGroupBox1.BorderRadius = 10;
            this.siticoneGroupBox1.Controls.Add(this.dobtb);
            this.siticoneGroupBox1.Controls.Add(this.hiredatetb);
            this.siticoneGroupBox1.Controls.Add(this.combobox);
            this.siticoneGroupBox1.Controls.Add(this.addresstb);
            this.siticoneGroupBox1.Controls.Add(this.emailtb);
            this.siticoneGroupBox1.Controls.Add(this.phonetb);
            this.siticoneGroupBox1.Controls.Add(this.lntb);
            this.siticoneGroupBox1.Controls.Add(this.fntb);
            this.siticoneGroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(255, 21);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.Size = new System.Drawing.Size(330, 398);
            this.siticoneGroupBox1.TabIndex = 1;
            this.siticoneGroupBox1.Text = "Details";
            // 
            // addresstb
            // 
            this.addresstb.BackColor = System.Drawing.Color.White;
            this.addresstb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.addresstb.BorderRadius = 15;
            this.addresstb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addresstb.DefaultText = "";
            this.addresstb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addresstb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addresstb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresstb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addresstb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addresstb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addresstb.ForeColor = System.Drawing.Color.Black;
            this.addresstb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addresstb.Location = new System.Drawing.Point(12, 222);
            this.addresstb.Name = "addresstb";
            this.addresstb.PasswordChar = '\0';
            this.addresstb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.addresstb.PlaceholderText = "Address";
            this.addresstb.SelectedText = "";
            this.addresstb.Size = new System.Drawing.Size(303, 36);
            this.addresstb.TabIndex = 4;
            // 
            // emailtb
            // 
            this.emailtb.BackColor = System.Drawing.Color.White;
            this.emailtb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.emailtb.BorderRadius = 15;
            this.emailtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtb.DefaultText = "";
            this.emailtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailtb.ForeColor = System.Drawing.Color.Black;
            this.emailtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtb.Location = new System.Drawing.Point(12, 180);
            this.emailtb.Name = "emailtb";
            this.emailtb.PasswordChar = '\0';
            this.emailtb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.emailtb.PlaceholderText = "Email";
            this.emailtb.SelectedText = "";
            this.emailtb.Size = new System.Drawing.Size(303, 36);
            this.emailtb.TabIndex = 3;
            // 
            // phonetb
            // 
            this.phonetb.BackColor = System.Drawing.Color.White;
            this.phonetb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.phonetb.BorderRadius = 15;
            this.phonetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonetb.DefaultText = "";
            this.phonetb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phonetb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phonetb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phonetb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phonetb.ForeColor = System.Drawing.Color.Black;
            this.phonetb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phonetb.Location = new System.Drawing.Point(12, 138);
            this.phonetb.Name = "phonetb";
            this.phonetb.PasswordChar = '\0';
            this.phonetb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.phonetb.PlaceholderText = "Phone Number";
            this.phonetb.SelectedText = "";
            this.phonetb.Size = new System.Drawing.Size(303, 36);
            this.phonetb.TabIndex = 2;
            // 
            // lntb
            // 
            this.lntb.BackColor = System.Drawing.Color.White;
            this.lntb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.lntb.BorderRadius = 15;
            this.lntb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lntb.DefaultText = "";
            this.lntb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lntb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lntb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lntb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lntb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lntb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lntb.ForeColor = System.Drawing.Color.Black;
            this.lntb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lntb.Location = new System.Drawing.Point(12, 96);
            this.lntb.Name = "lntb";
            this.lntb.PasswordChar = '\0';
            this.lntb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.lntb.PlaceholderText = "Last Name";
            this.lntb.SelectedText = "";
            this.lntb.Size = new System.Drawing.Size(303, 36);
            this.lntb.TabIndex = 1;
            // 
            // fntb
            // 
            this.fntb.BackColor = System.Drawing.Color.White;
            this.fntb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.fntb.BorderRadius = 15;
            this.fntb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fntb.DefaultText = "";
            this.fntb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fntb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fntb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fntb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fntb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fntb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fntb.ForeColor = System.Drawing.Color.Black;
            this.fntb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fntb.Location = new System.Drawing.Point(12, 54);
            this.fntb.Name = "fntb";
            this.fntb.PasswordChar = '\0';
            this.fntb.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.fntb.PlaceholderText = "First Name";
            this.fntb.SelectedText = "";
            this.fntb.Size = new System.Drawing.Size(303, 36);
            this.fntb.TabIndex = 0;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.White;
            this.savebtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.savebtn.BorderRadius = 20;
            this.savebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.savebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.savebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.savebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.savebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.savebtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(334, 425);
            this.savebtn.Name = "savebtn";
            this.savebtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.savebtn.Size = new System.Drawing.Size(180, 45);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // combobox
            // 
            this.combobox.BackColor = System.Drawing.Color.Transparent;
            this.combobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.combobox.BorderRadius = 15;
            this.combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combobox.ItemHeight = 30;
            this.combobox.Location = new System.Drawing.Point(12, 348);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(303, 36);
            this.combobox.TabIndex = 41;
            // 
            // hiredatetb
            // 
            this.hiredatetb.BorderRadius = 15;
            this.hiredatetb.Checked = true;
            this.hiredatetb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.hiredatetb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hiredatetb.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.hiredatetb.Location = new System.Drawing.Point(12, 264);
            this.hiredatetb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.hiredatetb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.hiredatetb.Name = "hiredatetb";
            this.hiredatetb.Size = new System.Drawing.Size(303, 36);
            this.hiredatetb.TabIndex = 3;
            this.hiredatetb.Value = new System.DateTime(2024, 9, 2, 10, 36, 56, 873);
            // 
            // dobtb
            // 
            this.dobtb.BorderRadius = 15;
            this.dobtb.Checked = true;
            this.dobtb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.dobtb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dobtb.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dobtb.Location = new System.Drawing.Point(12, 306);
            this.dobtb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dobtb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dobtb.Name = "dobtb";
            this.dobtb.Size = new System.Drawing.Size(303, 36);
            this.dobtb.TabIndex = 42;
            this.dobtb.Value = new System.DateTime(2024, 9, 2, 10, 36, 56, 873);
            // 
            // addemployeescard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 540);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.image);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addemployeescard";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.siticoneGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox image;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox fntb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addresstb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox emailtb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox phonetb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox lntb;
        private Siticone.Desktop.UI.WinForms.SiticoneButton savebtn;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox combobox;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dobtb;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker hiredatetb;
    }
}
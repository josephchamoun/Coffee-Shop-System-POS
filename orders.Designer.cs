namespace summer2
{
    partial class orders
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
            this.checkoutPanel = new System.Windows.Forms.Panel();
            this.datelb = new System.Windows.Forms.Label();
            this.deletebtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.displayitems = new System.Windows.Forms.FlowLayoutPanel();
            this.checkoutitemsUS1 = new summer2.checkoutitemsUS();
            this.checkoutitemsUS2 = new summer2.checkoutitemsUS();
            this.checkoutitemsUS3 = new summer2.checkoutitemsUS();
            this.checkoutitemsUS5 = new summer2.checkoutitemsUS();
            this.checkoutitemsUS6 = new summer2.checkoutitemsUS();
            this.checkoutitemsUS4 = new summer2.checkoutitemsUS();
            this.checkoutitemsUS7 = new summer2.checkoutitemsUS();
            this.totallbprice = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.Label();
            this.totallb = new System.Windows.Forms.Label();
            this.disclb = new System.Windows.Forms.Label();
            this.subtotallb = new System.Windows.Forms.Label();
            this.checkoutbtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.empname = new System.Windows.Forms.Label();
            this.positionlb = new System.Windows.Forms.Label();
            this.leftarrowbtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.rightarrowbtn = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.editpic = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.checkoutPanel.SuspendLayout();
            this.displayitems.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.checkoutPanel.Controls.Add(this.editpic);
            this.checkoutPanel.Controls.Add(this.datelb);
            this.checkoutPanel.Controls.Add(this.deletebtn);
            this.checkoutPanel.Controls.Add(this.displayitems);
            this.checkoutPanel.Controls.Add(this.totallbprice);
            this.checkoutPanel.Controls.Add(this.price2);
            this.checkoutPanel.Controls.Add(this.price1);
            this.checkoutPanel.Controls.Add(this.totallb);
            this.checkoutPanel.Controls.Add(this.disclb);
            this.checkoutPanel.Controls.Add(this.subtotallb);
            this.checkoutPanel.Controls.Add(this.checkoutbtn);
            this.checkoutPanel.Controls.Add(this.empname);
            this.checkoutPanel.Controls.Add(this.positionlb);
            this.checkoutPanel.Location = new System.Drawing.Point(244, 0);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Size = new System.Drawing.Size(862, 782);
            this.checkoutPanel.TabIndex = 28;
            // 
            // datelb
            // 
            this.datelb.AutoSize = true;
            this.datelb.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.datelb.Location = new System.Drawing.Point(347, 15);
            this.datelb.Name = "datelb";
            this.datelb.Size = new System.Drawing.Size(256, 26);
            this.datelb.TabIndex = 35;
            this.datelb.Text = "22/8/2024 12:30 PM";
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
            this.deletebtn.Image = global::summer2.Properties.Resources.icons8_delete_ios_17_glyph_310;
            this.deletebtn.ImageSize = new System.Drawing.Size(40, 40);
            this.deletebtn.Location = new System.Drawing.Point(791, 15);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.deletebtn.Size = new System.Drawing.Size(55, 40);
            this.deletebtn.TabIndex = 29;
            // 
            // displayitems
            // 
            this.displayitems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayitems.AutoScroll = true;
            this.displayitems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.displayitems.Controls.Add(this.checkoutitemsUS1);
            this.displayitems.Controls.Add(this.checkoutitemsUS2);
            this.displayitems.Controls.Add(this.checkoutitemsUS3);
            this.displayitems.Controls.Add(this.checkoutitemsUS5);
            this.displayitems.Controls.Add(this.checkoutitemsUS6);
            this.displayitems.Controls.Add(this.checkoutitemsUS4);
            this.displayitems.Controls.Add(this.checkoutitemsUS7);
            this.displayitems.Location = new System.Drawing.Point(27, 99);
            this.displayitems.Name = "displayitems";
            this.displayitems.Size = new System.Drawing.Size(819, 387);
            this.displayitems.TabIndex = 34;
            // 
            // checkoutitemsUS1
            // 
            this.checkoutitemsUS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.checkoutitemsUS1.Location = new System.Drawing.Point(3, 3);
            this.checkoutitemsUS1.Name = "checkoutitemsUS1";
            this.checkoutitemsUS1.Size = new System.Drawing.Size(354, 105);
            this.checkoutitemsUS1.TabIndex = 0;
            // 
            // checkoutitemsUS2
            // 
            this.checkoutitemsUS2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.checkoutitemsUS2.Location = new System.Drawing.Point(363, 3);
            this.checkoutitemsUS2.Name = "checkoutitemsUS2";
            this.checkoutitemsUS2.Size = new System.Drawing.Size(354, 105);
            this.checkoutitemsUS2.TabIndex = 1;
            // 
            // checkoutitemsUS3
            // 
            this.checkoutitemsUS3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.checkoutitemsUS3.Location = new System.Drawing.Point(3, 114);
            this.checkoutitemsUS3.Name = "checkoutitemsUS3";
            this.checkoutitemsUS3.Size = new System.Drawing.Size(354, 105);
            this.checkoutitemsUS3.TabIndex = 2;
            // 
            // checkoutitemsUS5
            // 
            this.checkoutitemsUS5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.checkoutitemsUS5.Location = new System.Drawing.Point(363, 114);
            this.checkoutitemsUS5.Name = "checkoutitemsUS5";
            this.checkoutitemsUS5.Size = new System.Drawing.Size(354, 105);
            this.checkoutitemsUS5.TabIndex = 4;
            // 
            // checkoutitemsUS6
            // 
            this.checkoutitemsUS6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.checkoutitemsUS6.Location = new System.Drawing.Point(3, 225);
            this.checkoutitemsUS6.Name = "checkoutitemsUS6";
            this.checkoutitemsUS6.Size = new System.Drawing.Size(354, 105);
            this.checkoutitemsUS6.TabIndex = 5;
            // 
            // checkoutitemsUS4
            // 
            this.checkoutitemsUS4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.checkoutitemsUS4.Location = new System.Drawing.Point(363, 225);
            this.checkoutitemsUS4.Name = "checkoutitemsUS4";
            this.checkoutitemsUS4.Size = new System.Drawing.Size(354, 105);
            this.checkoutitemsUS4.TabIndex = 6;
            // 
            // checkoutitemsUS7
            // 
            this.checkoutitemsUS7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.checkoutitemsUS7.Location = new System.Drawing.Point(3, 336);
            this.checkoutitemsUS7.Name = "checkoutitemsUS7";
            this.checkoutitemsUS7.Size = new System.Drawing.Size(354, 105);
            this.checkoutitemsUS7.TabIndex = 7;
            // 
            // totallbprice
            // 
            this.totallbprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totallbprice.AutoSize = true;
            this.totallbprice.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.totallbprice.Location = new System.Drawing.Point(757, 625);
            this.totallbprice.Name = "totallbprice";
            this.totallbprice.Size = new System.Drawing.Size(89, 22);
            this.totallbprice.TabIndex = 33;
            this.totallbprice.Text = "20.00 $";
            // 
            // price2
            // 
            this.price2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.price2.AutoSize = true;
            this.price2.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.price2.Location = new System.Drawing.Point(776, 540);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(70, 22);
            this.price2.TabIndex = 32;
            this.price2.Text = "1.50 $";
            // 
            // price1
            // 
            this.price1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.price1.AutoSize = true;
            this.price1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.price1.Location = new System.Drawing.Point(763, 503);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(83, 22);
            this.price1.TabIndex = 31;
            this.price1.Text = "21.50 $";
            // 
            // totallb
            // 
            this.totallb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totallb.AutoSize = true;
            this.totallb.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.totallb.Location = new System.Drawing.Point(23, 625);
            this.totallb.Name = "totallb";
            this.totallb.Size = new System.Drawing.Size(62, 22);
            this.totallb.TabIndex = 30;
            this.totallb.Text = "Total";
            // 
            // disclb
            // 
            this.disclb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.disclb.AutoSize = true;
            this.disclb.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disclb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.disclb.Location = new System.Drawing.Point(23, 540);
            this.disclb.Name = "disclb";
            this.disclb.Size = new System.Drawing.Size(96, 22);
            this.disclb.TabIndex = 29;
            this.disclb.Text = "Discount";
            // 
            // subtotallb
            // 
            this.subtotallb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subtotallb.AutoSize = true;
            this.subtotallb.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotallb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.subtotallb.Location = new System.Drawing.Point(24, 503);
            this.subtotallb.Name = "subtotallb";
            this.subtotallb.Size = new System.Drawing.Size(91, 22);
            this.subtotallb.TabIndex = 28;
            this.subtotallb.Text = "Subtotal";
            // 
            // checkoutbtn
            // 
            this.checkoutbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.checkoutbtn.BorderRadius = 20;
            this.checkoutbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkoutbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkoutbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkoutbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkoutbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.checkoutbtn.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutbtn.ForeColor = System.Drawing.Color.White;
            this.checkoutbtn.Location = new System.Drawing.Point(310, 717);
            this.checkoutbtn.Name = "checkoutbtn";
            this.checkoutbtn.Size = new System.Drawing.Size(266, 45);
            this.checkoutbtn.TabIndex = 27;
            this.checkoutbtn.Text = "Save";
            // 
            // empname
            // 
            this.empname.AutoSize = true;
            this.empname.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.empname.Location = new System.Drawing.Point(22, 52);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(170, 22);
            this.empname.TabIndex = 26;
            this.empname.Text = "Joseph Chamoun";
            // 
            // positionlb
            // 
            this.positionlb.AutoSize = true;
            this.positionlb.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.positionlb.Location = new System.Drawing.Point(22, 15);
            this.positionlb.Name = "positionlb";
            this.positionlb.Size = new System.Drawing.Size(191, 26);
            this.positionlb.TabIndex = 25;
            this.positionlb.Text = "Order Number 1";
            // 
            // leftarrowbtn
            // 
            this.leftarrowbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leftarrowbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.leftarrowbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.leftarrowbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.leftarrowbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.leftarrowbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.leftarrowbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.leftarrowbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.leftarrowbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftarrowbtn.Image = global::summer2.Properties.Resources.icons8_left_arrow_ios_17_outlined_32;
            this.leftarrowbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.leftarrowbtn.Location = new System.Drawing.Point(144, 278);
            this.leftarrowbtn.Name = "leftarrowbtn";
            this.leftarrowbtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.leftarrowbtn.Size = new System.Drawing.Size(57, 55);
            this.leftarrowbtn.TabIndex = 31;
            // 
            // rightarrowbtn
            // 
            this.rightarrowbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightarrowbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.rightarrowbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rightarrowbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rightarrowbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rightarrowbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rightarrowbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.rightarrowbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rightarrowbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rightarrowbtn.Image = global::summer2.Properties.Resources.icons8_right_arrow_ios_17_outlined_32;
            this.rightarrowbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.rightarrowbtn.Location = new System.Drawing.Point(1141, 278);
            this.rightarrowbtn.Name = "rightarrowbtn";
            this.rightarrowbtn.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.rightarrowbtn.Size = new System.Drawing.Size(57, 55);
            this.rightarrowbtn.TabIndex = 30;
            // 
            // editpic
            // 
            this.editpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.editpic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editpic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editpic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editpic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editpic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.editpic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editpic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editpic.Image = global::summer2.Properties.Resources.icons8_delete_ios_17_glyph_310;
            this.editpic.ImageSize = new System.Drawing.Size(40, 40);
            this.editpic.Location = new System.Drawing.Point(740, 15);
            this.editpic.Name = "editpic";
            this.editpic.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.editpic.Size = new System.Drawing.Size(55, 40);
            this.editpic.TabIndex = 36;
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1314, 768);
            this.ControlBox = false;
            this.Controls.Add(this.leftarrowbtn);
            this.Controls.Add(this.rightarrowbtn);
            this.Controls.Add(this.checkoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orders";
            this.ShowIcon = false;
            this.Resize += new System.EventHandler(this.orders_Resize);
            this.checkoutPanel.ResumeLayout(false);
            this.checkoutPanel.PerformLayout();
            this.displayitems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel checkoutPanel;
        private System.Windows.Forms.FlowLayoutPanel displayitems;
        private checkoutitemsUS checkoutitemsUS1;
        private checkoutitemsUS checkoutitemsUS2;
        private checkoutitemsUS checkoutitemsUS3;
        private checkoutitemsUS checkoutitemsUS5;
        private checkoutitemsUS checkoutitemsUS6;
        private checkoutitemsUS checkoutitemsUS4;
        private checkoutitemsUS checkoutitemsUS7;
        private System.Windows.Forms.Label totallbprice;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.Label totallb;
        private System.Windows.Forms.Label disclb;
        private System.Windows.Forms.Label subtotallb;
        private Siticone.Desktop.UI.WinForms.SiticoneButton checkoutbtn;
        private System.Windows.Forms.Label empname;
        private System.Windows.Forms.Label positionlb;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton deletebtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton rightarrowbtn;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton leftarrowbtn;
        private System.Windows.Forms.Label datelb;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton editpic;
    }
}
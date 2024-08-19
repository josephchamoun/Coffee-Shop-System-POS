namespace CoffeeStation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.adminbtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formSubMenu2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.formSubMenu1 = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pnBillings = new System.Windows.Forms.Panel();
            this.billingsbtn = new System.Windows.Forms.Button();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.pnTables = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnDashboard.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.pnBillings.SuspendLayout();
            this.pnSettings.SuspendLayout();
            this.pnTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHam
            // 
            this.btnHam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 33);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(45, 47);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sidebar.Controls.Add(this.btnHam);
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Controls.Add(this.pnBillings);
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Controls.Add(this.pnTables);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(179, 962);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // pnDashboard
            // 
            this.pnDashboard.Controls.Add(this.dashboardbtn);
            this.pnDashboard.Location = new System.Drawing.Point(3, 86);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnDashboard.Size = new System.Drawing.Size(363, 64);
            this.pnDashboard.TabIndex = 3;
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.dashboardbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.ForeColor = System.Drawing.Color.White;
            this.dashboardbtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardbtn.Image")));
            this.dashboardbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardbtn.Location = new System.Drawing.Point(-17, -35);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dashboardbtn.Size = new System.Drawing.Size(415, 122);
            this.dashboardbtn.TabIndex = 2;
            this.dashboardbtn.Text = "               Dashboard";
            this.dashboardbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardbtn.UseVisualStyleBackColor = false;
            this.dashboardbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.menuContainer.Controls.Add(this.panel9);
            this.menuContainer.Controls.Add(this.panel8);
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Controls.Add(this.panel2);
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.panel4);
            this.menuContainer.Location = new System.Drawing.Point(0, 153);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(363, 62);
            this.menuContainer.TabIndex = 9;
            this.menuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.menuContainer_Paint);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.adminbtn);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(363, 64);
            this.panel9.TabIndex = 11;
            // 
            // adminbtn
            // 
            this.adminbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.adminbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbtn.ForeColor = System.Drawing.Color.White;
            this.adminbtn.Image = ((System.Drawing.Image)(resources.GetObject("adminbtn.Image")));
            this.adminbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminbtn.Location = new System.Drawing.Point(-14, -32);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.adminbtn.Size = new System.Drawing.Size(443, 122);
            this.adminbtn.TabIndex = 2;
            this.adminbtn.Text = "                Admin  ";
            this.adminbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminbtn.UseVisualStyleBackColor = false;
            this.adminbtn.Click += new System.EventHandler(this.menu_Click_1);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Location = new System.Drawing.Point(0, 64);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(363, 64);
            this.panel8.TabIndex = 10;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-14, -9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(415, 89);
            this.button1.TabIndex = 12;
            this.button1.Text = "                Manage";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 61);
            this.panel1.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button3);
            this.panel6.Location = new System.Drawing.Point(0, 128);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(363, 61);
            this.panel6.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-14, -35);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(415, 122);
            this.button3.TabIndex = 13;
            this.button3.Text = "                Manage";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.formSubMenu2);
            this.panel2.Location = new System.Drawing.Point(0, 189);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 61);
            this.panel2.TabIndex = 14;
            // 
            // formSubMenu2
            // 
            this.formSubMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.formSubMenu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formSubMenu2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formSubMenu2.ForeColor = System.Drawing.Color.White;
            this.formSubMenu2.Image = ((System.Drawing.Image)(resources.GetObject("formSubMenu2.Image")));
            this.formSubMenu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formSubMenu2.Location = new System.Drawing.Point(-14, -34);
            this.formSubMenu2.Margin = new System.Windows.Forms.Padding(0);
            this.formSubMenu2.Name = "formSubMenu2";
            this.formSubMenu2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.formSubMenu2.Size = new System.Drawing.Size(415, 122);
            this.formSubMenu2.TabIndex = 2;
            this.formSubMenu2.Text = "                Inventory";
            this.formSubMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formSubMenu2.UseVisualStyleBackColor = false;
            this.formSubMenu2.Click += new System.EventHandler(this.formSubMenu2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(0, 250);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 61);
            this.panel3.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-14, -35);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(415, 122);
            this.button2.TabIndex = 12;
            this.button2.Text = "                Inventory";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.formSubMenu1);
            this.panel4.Location = new System.Drawing.Point(0, 311);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 61);
            this.panel4.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-14, -34);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(415, 122);
            this.button4.TabIndex = 11;
            this.button4.Text = "                Inventory";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // formSubMenu1
            // 
            this.formSubMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.formSubMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formSubMenu1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formSubMenu1.ForeColor = System.Drawing.Color.White;
            this.formSubMenu1.Image = ((System.Drawing.Image)(resources.GetObject("formSubMenu1.Image")));
            this.formSubMenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formSubMenu1.Location = new System.Drawing.Point(276, -15);
            this.formSubMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.formSubMenu1.Name = "formSubMenu1";
            this.formSubMenu1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.formSubMenu1.Size = new System.Drawing.Size(415, 32);
            this.formSubMenu1.TabIndex = 2;
            this.formSubMenu1.Text = "                Manage";
            this.formSubMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formSubMenu1.UseVisualStyleBackColor = false;
            this.formSubMenu1.Click += new System.EventHandler(this.formSubMenu1_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.button5);
            this.pnLogout.Location = new System.Drawing.Point(3, 218);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnLogout.Size = new System.Drawing.Size(363, 64);
            this.pnLogout.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-17, -27);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(415, 122);
            this.button5.TabIndex = 2;
            this.button5.Text = "               Clients";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pnBillings
            // 
            this.pnBillings.Controls.Add(this.billingsbtn);
            this.pnBillings.Location = new System.Drawing.Point(3, 288);
            this.pnBillings.Name = "pnBillings";
            this.pnBillings.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnBillings.Size = new System.Drawing.Size(363, 64);
            this.pnBillings.TabIndex = 5;
            // 
            // billingsbtn
            // 
            this.billingsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.billingsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billingsbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingsbtn.ForeColor = System.Drawing.Color.White;
            this.billingsbtn.Image = ((System.Drawing.Image)(resources.GetObject("billingsbtn.Image")));
            this.billingsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billingsbtn.Location = new System.Drawing.Point(-17, -21);
            this.billingsbtn.Name = "billingsbtn";
            this.billingsbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.billingsbtn.Size = new System.Drawing.Size(415, 122);
            this.billingsbtn.TabIndex = 2;
            this.billingsbtn.Text = "               Billings";
            this.billingsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billingsbtn.UseVisualStyleBackColor = false;
            this.billingsbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.Controls.Add(this.settingsbtn);
            this.pnSettings.Location = new System.Drawing.Point(3, 358);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnSettings.Size = new System.Drawing.Size(363, 64);
            this.pnSettings.TabIndex = 4;
            // 
            // settingsbtn
            // 
            this.settingsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.settingsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsbtn.ForeColor = System.Drawing.Color.White;
            this.settingsbtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsbtn.Image")));
            this.settingsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsbtn.Location = new System.Drawing.Point(-17, -19);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.settingsbtn.Size = new System.Drawing.Size(415, 122);
            this.settingsbtn.TabIndex = 2;
            this.settingsbtn.Text = "               Settings";
            this.settingsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsbtn.UseVisualStyleBackColor = false;
            this.settingsbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnTables
            // 
            this.pnTables.Controls.Add(this.button6);
            this.pnTables.Location = new System.Drawing.Point(3, 428);
            this.pnTables.Name = "pnTables";
            this.pnTables.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnTables.Size = new System.Drawing.Size(363, 64);
            this.pnTables.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-17, -22);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(415, 122);
            this.button6.TabIndex = 2;
            this.button6.Text = "               Logout";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1327, 962);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnDashboard.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.pnBillings.ResumeLayout(false);
            this.pnSettings.ResumeLayout(false);
            this.pnTables.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Panel pnSettings;
        private System.Windows.Forms.Button settingsbtn;
        private System.Windows.Forms.Panel pnBillings;
        private System.Windows.Forms.Button billingsbtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button formSubMenu2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button formSubMenu1;
        /*
        private System.Windows.Forms.Button formSubMenu3;
        private System.Windows.Forms.Button formSubMenu4;
        private System.Windows.Forms.Button formSubMenu5;
        private System.Windows.Forms.Button formSubMenu6;
        */
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnTables;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
    }
}


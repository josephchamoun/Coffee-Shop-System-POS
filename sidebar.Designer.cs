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
            this.shiftsandrolesbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.expensesbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.managesuppliersbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.allproductsbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.manageempbtn = new System.Windows.Forms.Button();
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
            this.manageproductbtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.panel5.SuspendLayout();
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
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Controls.Add(this.pnTables);
            this.sidebar.Controls.Add(this.pnBillings);
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
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.menuContainer.Controls.Add(this.panel4);
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.panel9);
            this.menuContainer.Controls.Add(this.panel2);
            this.menuContainer.Controls.Add(this.panel5);
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Controls.Add(this.panel8);
            this.menuContainer.Location = new System.Drawing.Point(0, 153);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(363, 57);
            this.menuContainer.TabIndex = 9;
            this.menuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.menuContainer_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel9.Controls.Add(this.shiftsandrolesbtn);
            this.panel9.Location = new System.Drawing.Point(0, 122);
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
            this.adminbtn.Location = new System.Drawing.Point(-14, -34);
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
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel8.Controls.Add(this.managesuppliersbtn);
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Location = new System.Drawing.Point(0, 369);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(363, 64);
            this.panel8.TabIndex = 10;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // shiftsandrolesbtn
            // 
            this.shiftsandrolesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.shiftsandrolesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shiftsandrolesbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftsandrolesbtn.ForeColor = System.Drawing.Color.White;
            this.shiftsandrolesbtn.Image = ((System.Drawing.Image)(resources.GetObject("shiftsandrolesbtn.Image")));
            this.shiftsandrolesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shiftsandrolesbtn.Location = new System.Drawing.Point(-14, -15);
            this.shiftsandrolesbtn.Margin = new System.Windows.Forms.Padding(0);
            this.shiftsandrolesbtn.Name = "shiftsandrolesbtn";
            this.shiftsandrolesbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.shiftsandrolesbtn.Size = new System.Drawing.Size(415, 89);
            this.shiftsandrolesbtn.TabIndex = 12;
            this.shiftsandrolesbtn.Text = "             Shifts and Roles";
            this.shiftsandrolesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shiftsandrolesbtn.UseVisualStyleBackColor = false;
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
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel6.Controls.Add(this.allproductsbtn);
            this.panel6.Location = new System.Drawing.Point(0, 308);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(363, 61);
            this.panel6.TabIndex = 7;
            // 
            // expensesbtn
            // 
            this.expensesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.expensesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expensesbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesbtn.ForeColor = System.Drawing.Color.White;
            this.expensesbtn.Image = ((System.Drawing.Image)(resources.GetObject("expensesbtn.Image")));
            this.expensesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expensesbtn.Location = new System.Drawing.Point(-14, -14);
            this.expensesbtn.Margin = new System.Windows.Forms.Padding(0);
            this.expensesbtn.Name = "expensesbtn";
            this.expensesbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.expensesbtn.Size = new System.Drawing.Size(415, 89);
            this.expensesbtn.TabIndex = 13;
            this.expensesbtn.Text = "                Expenses           ";
            this.expensesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expensesbtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.expensesbtn);
            this.panel2.Location = new System.Drawing.Point(0, 186);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 61);
            this.panel2.TabIndex = 14;
            // 
            // managesuppliersbtn
            // 
            this.managesuppliersbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.managesuppliersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managesuppliersbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managesuppliersbtn.ForeColor = System.Drawing.Color.White;
            this.managesuppliersbtn.Image = ((System.Drawing.Image)(resources.GetObject("managesuppliersbtn.Image")));
            this.managesuppliersbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managesuppliersbtn.Location = new System.Drawing.Point(-14, -13);
            this.managesuppliersbtn.Margin = new System.Windows.Forms.Padding(0);
            this.managesuppliersbtn.Name = "managesuppliersbtn";
            this.managesuppliersbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.managesuppliersbtn.Size = new System.Drawing.Size(415, 89);
            this.managesuppliersbtn.TabIndex = 2;
            this.managesuppliersbtn.Text = "              Manage Suppliers";
            this.managesuppliersbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managesuppliersbtn.UseVisualStyleBackColor = false;
            this.managesuppliersbtn.Click += new System.EventHandler(this.formSubMenu2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.manageempbtn);
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 61);
            this.panel3.TabIndex = 14;
            // 
            // allproductsbtn
            // 
            this.allproductsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.allproductsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allproductsbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allproductsbtn.ForeColor = System.Drawing.Color.White;
            this.allproductsbtn.Image = ((System.Drawing.Image)(resources.GetObject("allproductsbtn.Image")));
            this.allproductsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allproductsbtn.Location = new System.Drawing.Point(-14, -19);
            this.allproductsbtn.Margin = new System.Windows.Forms.Padding(0);
            this.allproductsbtn.Name = "allproductsbtn";
            this.allproductsbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.allproductsbtn.Size = new System.Drawing.Size(415, 89);
            this.allproductsbtn.TabIndex = 12;
            this.allproductsbtn.Text = "                All Products";
            this.allproductsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allproductsbtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel4.Controls.Add(this.adminbtn);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 61);
            this.panel4.TabIndex = 14;
            // 
            // manageempbtn
            // 
            this.manageempbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.manageempbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageempbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageempbtn.ForeColor = System.Drawing.Color.White;
            this.manageempbtn.Image = ((System.Drawing.Image)(resources.GetObject("manageempbtn.Image")));
            this.manageempbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageempbtn.Location = new System.Drawing.Point(-14, -12);
            this.manageempbtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageempbtn.Name = "manageempbtn";
            this.manageempbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.manageempbtn.Size = new System.Drawing.Size(415, 89);
            this.manageempbtn.TabIndex = 2;
            this.manageempbtn.Text = "             Manage Employees";
            this.manageempbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageempbtn.UseVisualStyleBackColor = false;
            this.manageempbtn.Click += new System.EventHandler(this.formSubMenu1_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.button5);
            this.pnLogout.Location = new System.Drawing.Point(3, 213);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnLogout.Size = new System.Drawing.Size(363, 58);
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
            this.button5.Location = new System.Drawing.Point(-17, -34);
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
            this.pnBillings.Controls.Add(this.button6);
            this.pnBillings.Location = new System.Drawing.Point(3, 409);
            this.pnBillings.Name = "pnBillings";
            this.pnBillings.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnBillings.Size = new System.Drawing.Size(363, 58);
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
            this.billingsbtn.Location = new System.Drawing.Point(-17, -34);
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
            this.pnSettings.Controls.Add(this.billingsbtn);
            this.pnSettings.Location = new System.Drawing.Point(3, 277);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnSettings.Size = new System.Drawing.Size(363, 60);
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
            this.settingsbtn.Location = new System.Drawing.Point(-17, -36);
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
            this.pnTables.Controls.Add(this.settingsbtn);
            this.pnTables.Location = new System.Drawing.Point(3, 343);
            this.pnTables.Name = "pnTables";
            this.pnTables.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnTables.Size = new System.Drawing.Size(363, 60);
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
            this.button6.Location = new System.Drawing.Point(-17, -38);
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
            // manageproductbtn
            // 
            this.manageproductbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.manageproductbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageproductbtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageproductbtn.ForeColor = System.Drawing.Color.White;
            this.manageproductbtn.Image = ((System.Drawing.Image)(resources.GetObject("manageproductbtn.Image")));
            this.manageproductbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageproductbtn.Location = new System.Drawing.Point(-14, -19);
            this.manageproductbtn.Margin = new System.Windows.Forms.Padding(0);
            this.manageproductbtn.Name = "manageproductbtn";
            this.manageproductbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.manageproductbtn.Size = new System.Drawing.Size(415, 89);
            this.manageproductbtn.TabIndex = 15;
            this.manageproductbtn.Text = "              Manage Products";
            this.manageproductbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageproductbtn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel5.Controls.Add(this.manageproductbtn);
            this.panel5.Location = new System.Drawing.Point(0, 247);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(363, 61);
            this.panel5.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1669, 962);
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
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.Button managesuppliersbtn;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button manageempbtn;
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
        private System.Windows.Forms.Button shiftsandrolesbtn;
        private System.Windows.Forms.Button allproductsbtn;
        private System.Windows.Forms.Button expensesbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button manageproductbtn;
    }
}


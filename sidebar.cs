using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using summer2;

namespace CoffeeStation
{
    public partial class Form1 : Form
    {
        //Windows Forms 
        Home dashboard;
        addemployees sub1;
        addsuppliers sub3;
        expenses sub5;
        shiftsandroles sub6;
        supplierproducts sub4;
        additems sub2;
        Billings bill;
        orders tab;
        settings sett;
        


        Button formSubMenu3;
        Button formSubMenu4;
        Button formSubMenu5;
        Button formSubMenu6;

        public Form1()
        {
            InitializeComponent();
         
            this.WindowState = FormWindowState.Maximized;
            mdiProp();
        }

      

        private void menu_Click_1(object sender, EventArgs e)
        {

                menuTransition.Start();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new Home();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }


        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        // Tabel Expand 
        bool menuExpand = false;
        
        private void mdiProp()
        {
          //  this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(42,42,42);
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            //Menu Expand Open
            if (menuExpand == false)
            {
                menuContainer.Height += 5;
                if (menuContainer.Height >= 425)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            //Menu Expand Closed
            else
            {
                menuContainer.Height -= 5;
                if (menuContainer.Height <= 64)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        bool adminExpand = false;
        //Start Menu Expand Function


        //Sidebar Expand 
        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                //Sidebar Expand Closed
                sidebar.Width -= 10;
                if (sidebar.Width <= 58)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnDashboard.Width = sidebar.Width;
                    pnBillings.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    pnTables.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
            //SideBar Expand Open
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 150)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;  
                    pnBillings.Width = sidebar.Width;   
                    pnSettings.Width = sidebar.Width;
                    pnTables.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        //Start Sidebar Expand Function
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        //Open Dashboard on Click
        private void button1_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new Home();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }else
            {
                dashboard.Activate();
            }
        }

        //Dismis Dashboard after open another
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        //Open Table 1 on Click (Remenber change the names)
        private void formSubMenu1_Click(object sender, EventArgs e)
        {
            if (sub1 == null )
            {
                sub1 = new addemployees();
                sub1.FormClosed += Sub1_FormClosed;
                sub1.MdiParent = this;
                sub1.Dock = DockStyle.Fill;
                sub1.Show();    

            }else
            {
                sub1.Activate();
            }
        }

        //Dismis Table 1 after open another 
        private void Sub1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub1 = null;
        }

        //Open Billings on Click
        private void button3_Click(object sender, EventArgs e)
        {
           /* int id = loginbackend.managerid(loginbackend.username);
            if (id == 1)
            {
                return;
            }*/
            if (bill == null)
            {
                bill = new Billings();
                bill.FormClosed += Bill_FormClosed;
                bill.MdiParent = this;  
                bill.Dock = DockStyle.Fill; 
                bill.Show();
            }else
            {
                bill.Activate();
            }


        }

        //Dismis Billings after open another
        private void Bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            bill = null;
        }

        //Open Settings on Click
        private void button2_Click(object sender, EventArgs e)
        {
            if (sett == null)
            {
                sett = new settings();
                sett.FormClosed += Sett_FormClosed;
                sett.MdiParent = this;
                sett.Dock = DockStyle.Fill;
                sett.Show();
            }else
            {
                sett.Activate();
            }
        }

        //Dismis Settings after open another
        private void Sett_FormClosed(object sender, FormClosedEventArgs e)
        {
            sett = null;
        }

        
      

        //Logout of the POS
        private void button6_Click(object sender, EventArgs e)
        {
            //  Application.Exit();
          /*  Login login = new Login();

            // Show the new form
           login.Show();
          */
            // Close the current form
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tab == null)
            {
                tab = new orders();
                tab.FormClosed += Tab_FormClosed;
                tab.MdiParent = this;
                tab.Dock = DockStyle.Fill;
                tab.Show();
            }
            else
            {
                tab.Activate();
            }
        }

        private void Tab_FormClosed(object sender, FormClosedEventArgs e)
        {
            tab = null;
        }

        private void formSubMenu2_Click(object sender, EventArgs e)
        {
            //manage suppliers form
            if (sub2 == null)
            {
                sub2 = new additems();
                sub2.FormClosed += Sub_FormClosed;
                sub2.MdiParent = this;
                sub2.Dock = DockStyle.Fill;
                sub2.Show();
           
            }
            else
            {
                sub2.Activate();
            }
        }

        private void Sub_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub2 = null;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void allproductsbtn_Click(object sender, EventArgs e)
        {

        }

        private void manageproductbtn_Click(object sender, EventArgs e)
        {

        }

        private void shiftsandrolesbtn_Click(object sender, EventArgs e)
        {
            if (sub6 == null)
            {
                sub6 = new shiftsandroles();
                sub6.FormClosed += Sub_FormClosed;
                sub6.MdiParent = this;
                sub6.Dock = DockStyle.Fill;
                sub6.Show();

            }
            else
            {
                sub6.Activate();
            }
        }

        private void expensesbtn_Click(object sender, EventArgs e)
        {
            if (sub5 == null)
            {
                sub5= new expenses();
                sub5.FormClosed += Sub_FormClosed;
                sub5.MdiParent = this;
                sub5.Dock = DockStyle.Fill;
                sub5.Show();

            }
            else
            {
                sub5.Activate();
            }
        }
    }
}
//lzm n3mlo responsive (badna n8ayir l numbers w nhet proportion ahsan)
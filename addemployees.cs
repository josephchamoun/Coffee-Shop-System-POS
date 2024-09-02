using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Siticone.Desktop.UI.WinForms;
using CoffeeStation;
using System.IO;

namespace summer2
{
    public partial class addemployees : Form
    {
        public static addemployees form1inst; // Singleton instance of the form
        Billings billings;
        Home home;
        Form1 sidebar;
      

        public addemployees()
        {
           // MaterialSkinManager materialskinmanager;
            InitializeComponent();
            home = new Home();
            billings = new Billings();
            sidebar = new Form1();
            form1inst = this;
    

            PopulateEmployees(employeesflp);
        
            // materialskinmanager = MaterialSkinManager.Instance;
            // materialskinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
        }
        
        protected override void OnMouseDown(MouseEventArgs e)
        {
            // Do nothing to prevent form movement
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            // Do nothing to prevent form movement
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateEmployees(employeesflp);
        }
        
        public static void PopulateEmployees(FlowLayoutPanel employeesflp)
        {
            // Get the employee data
            DataTable employeeData = manageemployees.GetActiveEmployees();

            // Clear existing controls in the FlowLayoutPanel
            employeesflp.Controls.Clear();

            // Loop through each row in the DataTable
            foreach (DataRow row in employeeData.Rows)
            {
                // Create a new instance of the employeeUS user control
                employeeUS employeeControl = new employeeUS();

                // Populate the user control using properties
                employeeControl.FirstName = row["EFirstName"].ToString();
                employeeControl.LastName = row["ELastName"].ToString();
                employeeControl.Phone = row["EPhone"].ToString();
                employeeControl.Email = row["EEmail"].ToString();
                employeeControl.DateOfBirth = Convert.ToDateTime(row["dob"]).ToString("yyyy-MM-dd");
                employeeControl.HireDate = Convert.ToDateTime(row["EHireDate"]).ToString("yyyy-MM-dd");
                employeeControl.Role = row["ERoleId"].ToString(); // Convert this ID to a role name if necessary

                // Handle photo loading
                if (row["EPhotoURL"] != DBNull.Value)
                {
                    byte[] photoData = (byte[])row["EPhotoURL"];
                    using (MemoryStream ms = new MemoryStream(photoData))
                    {
                        employeeControl.Photo = Image.FromStream(ms);
                    }
                }

                // Add the populated user control to the FlowLayoutPanel
                employeesflp.Controls.Add(employeeControl);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (addemployeescard frm = new addemployeescard())
                {
                    background.StartPosition = FormStartPosition.Manual;
                    background.FormBorderStyle = FormBorderStyle.None;
                    background.Opacity = .50d;
                    background.BackColor = Color.Black;
                    background.WindowState = FormWindowState.Maximized;
                    background.Location = this.Location;
                    background.ShowInTaskbar = false;
                    background.Show();



                    frm.Owner = background;
                    frm.ShowDialog();
                    background.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                background.Dispose();
            }
        }




    }
}

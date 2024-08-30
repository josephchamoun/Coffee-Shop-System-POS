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
using MaterialSkin;
using static System.Net.Mime.MediaTypeNames;

namespace summer2
{
    public partial class addemployeescard : Form
    {
        
        public addemployeescard()
        {
  
            InitializeComponent();
           
        }
        string imagePath;
        private void picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); // Creates a new OpenFileDialog instance

            dlg.Filter = "Image | *.jpg; *.png; *.jpeg"; // Sets the filter to only show image files with the extensions .jpg, .png, and .jpeg

            DialogResult res = dlg.ShowDialog(); // Shows the open file dialog and waits for the user to select a file and close the dialog

            if (res == DialogResult.OK) // Checks if the user selected a file and clicked OK
            {
                image.Image = new Bitmap(dlg.FileName); // Loads the selected image file into a Bitmap and assigns it to the 'Image' property of the 'image' control
                imagePath = dlg.FileName; // Stores the file path of the selected image in a variable 'imagePath'
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of UserControl1
                employeeUS myUserControl = new employeeUS();

                myUserControl.firstname.Text = nametb.Text;

                // Add the UserControl to the FlowLayoutPanel on Form1
               addemployees.form1inst.flowLayoutPanel2.Controls.Add(myUserControl);

                MessageBox.Show("UserControl added successfully.");


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
    }
}

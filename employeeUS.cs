﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace summer2
{
    public partial class employeeUS : UserControl
    {
        public employeeUS()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          //bas ta tezhar l contextmenustrip ta7et l three dots bi fixed place 
            // Get the button's location and size
            var buttonLocation =guna2PictureBox1.Location;
            var buttonHeight = guna2PictureBox1.Height;

            // Calculate the fixed position for the context menu (e.g., directly below the button)
            var contextMenuPosition = new System.Drawing.Point(buttonLocation.X, buttonLocation.Y + buttonHeight);

            // Show the context menu at the calculated position
            contextMenuStrip1.Show(this, contextMenuPosition);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)// ta nemhe l user control li nehna 3le
        {
            // Access the parent form of UserControl1
            addemployees parentForm = this.ParentForm as addemployees;

            // Access the FlowLayoutPanel from the parent form
            FlowLayoutPanel flowLayoutPanel = parentForm.flowLayoutPanel2;

            // Remove this UserControl instance from the FlowLayoutPanel
            flowLayoutPanel.Controls.Remove(this);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            //bas ta tezhar l contextmenustrip ta7et l three dots bi fixed place 
            // Get the button's location and size
            var buttonLocation = guna2PictureBox1.Location;
            var buttonHeight = guna2PictureBox1.Height;

            // Calculate the fixed position for the context menu (e.g., directly below the button)
            var contextMenuPosition = new System.Drawing.Point(buttonLocation.X, buttonLocation.Y + buttonHeight);

            // Show the context menu at the calculated position
            contextMenuStrip1.Show(this, contextMenuPosition);
        }
    }
}
// hide or remove the contextmenustrip on_mouse_scroll event
/*Top-Left: Profile picture icon.
Top-Right: Ellipsis for more options.
Middle-Left: Icons and corresponding text (phone, email, etc.) stacked vertically.
Middle-Right: Job title with a briefcase icon.
Bottom: Status badge or small graph icon, possibly with a subtle background pattern.*/
//Display summary statistics such as the total number of employees, number of employees per department, or other key metrics
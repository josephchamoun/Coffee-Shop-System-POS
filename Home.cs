﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace summer2
{
    public partial class Home : Form
    {


        public Home()
        {
            InitializeComponent();


            this.Resize += Home_Resize; // <--- Added to handle form resize event
            // Initial layout setup
            AdjustPanelSizes();
            adjustbtnandsearchbar();
            AdjustUserControlSizes(); // <--- Added to adjust user control sizes initially
            ResizeUserControlsBasedOnScreenSize();
            AdjustCheckoutPanelControls();
        }
        private void AdjustUserControlSizes()
        {
            // Define constants
            int controlCountPerRow = 3; // Always 3 controls per row

            // Calculate the spacing as a fraction of the panel width
            int spaceBetweenControls = menuFlowLayoutPanel.ClientSize.Width / 60; // Space between controls
            int spaceAtEdges = menuFlowLayoutPanel.ClientSize.Width / 60; // Space at the edges

            // Get the width of the panel
            int panelWidth = menuFlowLayoutPanel.ClientSize.Width;

            // Calculate the total width available for user controls
            int totalSpaceForControls = panelWidth - (2 * spaceAtEdges) - (controlCountPerRow - 1) * spaceBetweenControls;

            // Calculate the width for each control
            int userControlWidth = totalSpaceForControls / controlCountPerRow;

            // Calculate height based on width (assuming a fixed aspect ratio, e.g., 4:3)
            int userControlHeight = (int)(userControlWidth * 0.75); // Adjust aspect ratio as needed

            // Adjust the layout of each control
            foreach (Control control in menuFlowLayoutPanel.Controls)
            {
                // Set width and height of each control
                control.Width = userControlWidth;
                control.Height = userControlHeight;

                // Set margin of each control
                control.Margin = new Padding(spaceBetweenControls / 2, 3, spaceBetweenControls / 2, 3);
            }

            // Force the layout to update
            menuFlowLayoutPanel.PerformLayout();
        }








        private void AdjustCheckoutPanelControls()
        {
            // Existing code
            // Get the size of the checkoutPanel
            int panelWidth = checkoutPanel.ClientSize.Width;
            int panelHeight = checkoutPanel.ClientSize.Height;

            // Calculate positions based on the panel dimensions
            int margin = 10; // Margin for spacing
            int extraSpace = panelWidth / 24; // Space to leave to the left
            int spaceBetweenLabels = 30; // Increased space to leave between disclb and totallb

            // Position for the checkoutbtn
            int checkoutbtnY = panelHeight - checkoutbtn.Height - margin;

            // Start positions for the labels below the middle of the panel, above checkoutbtn
            int startY = (panelHeight - checkoutbtnY) / 2 + checkoutbtnY - (5 * margin + 6 * subtotallb.Height); // Adjust this value based on label height and margin

            // X-axis for price labels with space to the left
            int rightX = panelWidth - extraSpace - price1.Width; // Adjust right position to leave space

            // Positions for subtotallb, disclb, and totallb
            int subtotallbY = startY;
            int disclbY = subtotallbY + subtotallb.Height + margin;
            int totallbY = disclbY + disclb.Height + spaceBetweenLabels; // Add increased space between disclb and totallb

            // Position for totallbprice
            int totallbpriceY = totallbY;

            // Set the positions
            positionlb.Location = new Point(margin, margin);
            empname.Location = new Point(margin, positionlb.Bottom + margin);
            subtotallb.Location = new Point(margin, subtotallbY);
            disclb.Location = new Point(margin, disclbY);
            totallb.Location = new Point(margin, totallbY);
            price1.Location = new Point(rightX, subtotallbY); // Align with subtotallbY
            price2.Location = new Point(rightX, disclbY); // Align with disclbY
            totallbprice.Location = new Point(rightX, totallbY); // Align with totallbY
            checkoutbtn.Location = new Point((panelWidth - checkoutbtn.Width) / 2, checkoutbtnY);

            // New code for displayitems
            int margin2 = this.ClientSize.Width / 60;
            // Position for the displayitems FlowLayoutPanel
            int displayitemsY = empname.Bottom + margin2; // Position it a bit below empname
            
            displayitems.Location = new Point(subtotallb.Left, displayitemsY); // Align the left with subtotallb
                                                                               // Calculate the width of the displayitems FlowLayoutPanel
            int displayitemsWidth = (int)(panelWidth * 0.98) - subtotallb.Left; // Set the width to be slightly less than the checkoutPanel's full width using proportion

            // Calculate the height of the displayitems FlowLayoutPanel
            int displayitemsHeight = subtotallbY - displayitemsY - (int)(panelHeight * 0.02); // Adjust the height using proportion

            // Set the size of displayitems
            displayitems.Size = new Size(displayitemsWidth, displayitemsHeight);
            foreach (Control control in displayitems.Controls)
            {
                control.Width = displayitems.ClientSize.Width-(margin2/5); // Fill the width
                control.Height =( displayitems.ClientSize.Height / 6) -(margin2/3); // Set height to 1/6 of the FlowLayoutPanel height
        
            }

        }



        private void ResizeUserControlsBasedOnScreenSize()
        {
            AdjustUserControlSizes();
        }







        private void AdjustPanelSizes()
        {
            // Calculate the spacing as a fraction of the form's width
            int spacing = this.ClientSize.Width / 17; // Example: 1/20th of the form's width

            // Set the width of the checkoutPanel to be 2/9 of the form's width
            checkoutPanel.Width = 2 * this.ClientSize.Width / 9;

            // Calculate the width of the FlowLayoutPanel
            int flowLayoutPanelWidth = this.ClientSize.Width - checkoutPanel.Width - spacing;

            // Set the width of the FlowLayoutPanel
            flowLayoutPanel1.Width = flowLayoutPanelWidth;

            // Position the checkoutPanel (keeping the location the same)
            checkoutPanel.Location = new Point(flowLayoutPanel1.Right + spacing, checkoutPanel.Location.Y);
        }


        private void adjustbtnandsearchbar() 
        {
            int newPlusButtonX = flowLayoutPanel1.Right + 20; // 20 pixels after the FlowLayoutPanel
            int newPlusButtonY = (flowLayoutPanel1.Top + (flowLayoutPanel1.Height - addButton.Height) / 2) - 15;

            // Set the new location for the plus button
            addButton.Location = new Point(newPlusButtonX, newPlusButtonY);

            // Calculate the width of the searchbar to be 1/3 of the flowLayoutPanel1 width
            int searchBarWidth = flowLayoutPanel1.Width / 3;

            // Calculate the left position for the searchbar to ensure its right edge aligns with the right edge of flowLayoutPanel1
            int searchBarLeft = flowLayoutPanel1.Right - searchBarWidth;

            // Set the new location and width for the searchbar
            searchbar.Location = new Point(searchBarLeft, searchbar.Top);
            searchbar.Width = searchBarWidth;
        }




        private void Home_Resize(object sender, EventArgs e)
        {
            AdjustPanelSizes();
            adjustbtnandsearchbar();
            AdjustUserControlSizes();
            AdjustCheckoutPanelControls();

            ResizeUserControlsBasedOnScreenSize();

            // Set the width of menuFlowLayoutPanel to match flowLayoutPanel1
            menuFlowLayoutPanel.Width = flowLayoutPanel1.Width+15;

            // Set the height of menuFlowLayoutPanel to end at the bottom of checkoutPanel
            int newMenuFlowLayoutPanelHeight = checkoutPanel.Bottom - menuFlowLayoutPanel.Top;

            menuFlowLayoutPanel.Height = newMenuFlowLayoutPanelHeight;
            UpdateResultNumPosition();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            AdjustPanelSizes();
            adjustbtnandsearchbar();
            AdjustUserControlSizes();
            ResizeUserControlsBasedOnScreenSize();
            AdjustCheckoutPanelControls();

            // Assuming 'flowLayoutPanel1' is your main FlowLayoutPanel,
            // 'menuFlowLayoutPanel' is your new FlowLayoutPanel,
            // 'checkoutPanel' is your panel at the bottom

            // Set the width of menuFlowLayoutPanel to match flowLayoutPanel1
            menuFlowLayoutPanel.Width = flowLayoutPanel1.Width;

            // Calculate the location below coffeeMenu with a 20-pixel margin
            int newX = coffeemenu.Location.X;
            int newY = coffeemenu.Location.Y + coffeemenu.Height + 20;

            // Set the location of menuFlowLayoutPanel
            menuFlowLayoutPanel.Location = new Point(newX, newY);

            // Set the height of menuFlowLayoutPanel to end at the bottom of checkoutPanel
            int newMenuFlowLayoutPanelHeight = checkoutPanel.Bottom - menuFlowLayoutPanel.Top;
            menuFlowLayoutPanel.Height = newMenuFlowLayoutPanelHeight;
            UpdateResultNumPosition();
        }
        private void UpdateResultNumPosition()
        {
            // Calculate the horizontal position (X) for coffeemenu label, aligning it with flowLayoutPanel1
            int newXCoffeeMenu = flowLayoutPanel1.Left;

            // Calculate the vertical position (Y) for coffeemenu label
            // Position it slightly below flowLayoutPanel1, using a proportion of the flowLayoutPanel1 height
            int verticalSpacing = (int)(flowLayoutPanel1.Height * 0.05); // 5% of flowLayoutPanel1 height as spacing
            int newYCoffeeMenu = flowLayoutPanel1.Bottom + verticalSpacing;

            // Set the new location of coffeemenu label
            coffeemenu.Location = new Point(newXCoffeeMenu, newYCoffeeMenu+(verticalSpacing*4));
            // Calculate the horizontal space between the right edge of coffeeMenu and the resultnum label
            int spacing = (int)(searchbar.Width * 0.02); // 2% of the searchbar width as spacing

            // Calculate the new X-coordinate for resultnum label (right after coffeeMenu label)
            int newXResultNum = coffeemenu.Right + spacing;

            // Align the Y-coordinate of resultnum with coffeemenu label
            int newY = coffeemenu.Top;

            // Set the location of resultnum label
            resultnum.Location = new Point(newXResultNum, newY);

            // Calculate the horizontal space between the right edge of resultnum and the additems button
            int spacingAfterResultNum = (int)(searchbar.Width * 0.03); // 3% of the searchbar width as spacing

            // Calculate the new X-coordinate for additems button (right after resultnum label)
            int newXAddItems = resultnum.Right + spacingAfterResultNum;

            // Set the location of additems button
            additems.Location = new Point(newXAddItems, newY-verticalSpacing);
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void checkoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemUS1_Load(object sender, EventArgs e)
        {

        }
    }
    
}

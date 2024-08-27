using System;
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
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
            AdjustCheckoutPanelControls();
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
                control.Width = displayitems.ClientSize.Width - (margin2 / 5); // Fill the width
                control.Height = (displayitems.ClientSize.Height / 6) - (margin2 / 3); // Set height to 1/6 of the FlowLayoutPanel height

            }
            // Calculate the size and position of deletebtn
            int deletebtnSize = Math.Max((int)(checkoutPanel.ClientSize.Height * 0.05), (int)(checkoutPanel.ClientSize.Width * 0.05)); // Slightly bigger size
            deletebtn.Size = new Size(deletebtnSize, deletebtnSize);

            // Position the deletebtn at the top right corner of checkoutPanel
            int deletebtnX = checkoutPanel.ClientSize.Width - deletebtn.Width - (int)(checkoutPanel.ClientSize.Width * 0.03); // Move it slightly more to the left
            int deletebtnY = (int)(checkoutPanel.ClientSize.Height * 0.01); // Small margin from the top

            deletebtn.Location = new Point(deletebtnX, deletebtnY);
            datelb.Width = positionlb.Width;

            // Calculate the X and Y positions for datelb
            int datex = (panelWidth - datelb.Width) / 2; // Centering datelb horizontally
            int datey = positionlb.Top + (int)(panelHeight * 0.02); // Position datelb below positionlb with some space

            // Set the location of datelb
            datelb.Location = new Point(datex, datey);


        }
        private void CenterCheckoutPanel()
        {
            // Get the size of the form
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Set the height of the checkoutPanel to fill the height of the form
            int panelHeight = formHeight;

            // Calculate the width of the checkoutPanel based on a proportion of the form's width
            int panelWidth = (int)(formWidth * 0.45);

            // Calculate the X position to center the panel horizontally
            int panelX = (formWidth - panelWidth) / 2;

            // The Y position will be 0 to align it with the top of the form
            int panelY = 0;

            // Set the size and location of the checkoutPanel
            checkoutPanel.Size = new Size(panelWidth, panelHeight);
            checkoutPanel.Location = new Point(panelX, panelY);

            // Calculate spacing and size for buttons
            int buttonWidth = (int)(formWidth * 0.03); // Size of the buttons (adjust as needed)
            int buttonHeight = (int)(formHeight * 0.05); // Height of the buttons (adjust as needed)
            int spaceBetween = (formWidth - (2 * buttonWidth) - panelWidth) / 3; // Space between elements

            // Set the size and location for leftarrowbtn
            leftarrowbtn.Size = new Size(buttonWidth, buttonHeight);
            leftarrowbtn.Location = new Point(spaceBetween, (formHeight - buttonHeight) / 2); // Middle left

            // Set the size and location for rightarrowbtn
            rightarrowbtn.Size = new Size(buttonWidth, buttonHeight);
            rightarrowbtn.Location = new Point(formWidth - spaceBetween - buttonWidth, (formHeight - buttonHeight) / 2); // Middle right
        }

        private void orders_Resize(object sender, EventArgs e)
        {
            CenterCheckoutPanel();
            AdjustCheckoutPanelControls();
        }
    }
}

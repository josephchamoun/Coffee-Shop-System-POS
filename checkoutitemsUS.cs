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
    public partial class checkoutitemsUS : UserControl
    {
        public checkoutitemsUS()
        {
            InitializeComponent();
            AdjustMainPanelControls();
            PositionArrowButtons();
        }
        private void AdjustMainPanelControls()
        {
            // Ensure mainpanel matches the size of the UserControl by docking it
            mainpanel.Dock = DockStyle.Fill;

            // Get the size of the mainpanel
            int panelWidth = mainpanel.ClientSize.Width;
            int panelHeight = mainpanel.ClientSize.Height;

            // Calculate positions based on proportions
            int itempicX = 0; // Place itempic at the very beginning of the panel
            int itempicY = 0; // Top margin for itempic

            int mainlbX = itempic.Right + (int)(panelWidth * 0.02); // Place mainlb slightly to the right of itempic using proportion
            int mainlbY = itempic.Top + (int)(panelHeight * 0.05); // Position mainlb slightly below the top of itempic

            int nbofitemsX = mainlbX; // Same x-axis as mainlb
            int nbofitemsY = mainlb.Bottom + (int)(panelHeight * 0.02); // Position nbofitems below mainlb with some space

            int priceX = panelWidth - price.Width - (int)(panelWidth * 0.02); // Place price at the end of the panel using proportion
            int priceY = nbofitemsY; // Same y-axis as nbofitems

            // Adjust size and position of deletebtn
            int deletebtnSize = (int)(Math.Min(panelWidth, panelHeight) * 0.25); // Set size to 20% of the smaller dimension of the panel
            int deletebtnX = panelWidth - deletebtnSize - (int)(panelWidth * 0.04); // Move it further to the left
            int deletebtnY = (int)(panelHeight * 0.02); // Top margin for deletebtn

            // Set the positions and sizes
            itempic.Location = new Point(itempicX, itempicY);
            mainlb.Location = new Point(mainlbX, mainlbY);
            nbofitems.Location = new Point(nbofitemsX, nbofitemsY);
            price.Location = new Point(priceX, priceY);

            // Set the size and position of deletebtn
            deletebtn.Size = new Size(deletebtnSize, deletebtnSize); // Ensure the button is a circle
            deletebtn.Location = new Point(deletebtnX, deletebtnY);




           // mainlb.MaximumSize = new Size(500, 70);
           // mainlb.Size = new Size(500, 46);
        }






        private void PositionArrowButtons()
        {
            // Calculate the X and Y positions for the uparrow button
            int uparrowX = nbofitems.Right + (int)(this.Width * 0.02); // X position after nbofitems
            int uparrowY = nbofitems.Top + (int)(nbofitems.Height * 0.2); // Slightly lower on the Y-axis

            // Set the location of uparrow button
            uparrow.Location = new Point(uparrowX, uparrowY);

            // Calculate the Y position for the downarrow button
            int downarrowX = uparrowX; // Same X position as uparrow
            int downarrowY = uparrow.Bottom + (int)(this.Height * 0.02); // Positioned below uparrow

            // Set the location of downarrow button
            downarrow.Location = new Point(downarrowX, downarrowY);
        }

        private void checkoutitemsUS_Resize(object sender, EventArgs e)
        {
            AdjustMainPanelControls();
            PositionArrowButtons();

        }

        private void mainpanel_Resize(object sender, EventArgs e)
        {
            AdjustMainPanelControls();
            PositionArrowButtons();
        }

        private void uparrow_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("uparrow_Click triggered.");

                // Assuming your label is named nbofitems
                string labelText = nbofitems.Text;

                // Split the text by the space character
                string[] parts = labelText.Split(' ');

                // Parse the second part as an integer
                if (parts.Length > 1 && int.TryParse(parts[1], out int number))
                {
                    // Successfully parsed the number
                    int itemnb = number;
                    itemnb++;


                    nbofitems.Text = "x " + itemnb.ToString();

                }
                else
                {
                    // Invalid label text format
                    Console.WriteLine("Invalid label text format.");
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void downarrow_Click(object sender, EventArgs e)
        {
            try
            {
               

                // Assuming your label is named nbofitems
                string labelText = nbofitems.Text;

                // Split the text by the space character
                string[] parts = labelText.Split(' ');

                // Parse the second part as an integer
                if (parts.Length > 1 && int.TryParse(parts[1], out int number))
                {
                    // Successfully parsed the number
                    int itemnb = number;
                    itemnb--;


                    nbofitems.Text = "x " + itemnb.ToString();

                }
                else
                {
                    // Invalid label text format
                    Console.WriteLine("Invalid label text format.");
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}

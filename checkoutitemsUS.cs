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

            // Set the positions
            itempic.Location = new Point(itempicX, itempicY);
            mainlb.Location = new Point(mainlbX, mainlbY);
            nbofitems.Location = new Point(nbofitemsX, nbofitemsY);
            price.Location = new Point(priceX, priceY);
        }



        private void checkoutitemsUS_Resize(object sender, EventArgs e)
        {
            AdjustMainPanelControls();

        }

        private void mainpanel_Resize(object sender, EventArgs e)
        {
            AdjustMainPanelControls();
        }
    }
}

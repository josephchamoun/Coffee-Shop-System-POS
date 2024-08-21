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
    public partial class itemUS : UserControl
    {
        public itemUS()
        {
            InitializeComponent();
            AdjustPanelSize();
            AdjustInternalControlSizes();
            AdjustLabelSizes();
        }
        public void AdjustPanelSize()
        {
            // Assuming 'myPanel' is the internal panel you want to resize
            mainpanel.Width = this.Width;
            mainpanel.Height = this.Height;
        }
        public void AdjustInternalControlSizes()
        {
            int padding = this.ClientSize.Width / 30; // Adjust padding as needed
            int itemPicSize = (this.Width * 2) / 5; // Set itempic width and height to 2/5 of the UserControl width
            int itemPicHeight = 2 * (this.Height) / 3;

            // Adjust itempic (PictureBox) size and location
            itempic.Width = itemPicSize;
            itempic.Height = itemPicHeight;
            itempic.Location = new Point(padding, padding);

            // Calculate proportional offsets
            float mainlbOffset = 0.08f; // 8% from the top of the pic
            float pricelbOffset = 0.1f; // 10% from the bottom of the pic

            // Adjust mainlb (Main Label) size and location
            mainlb.Width = this.Width - itempic.Right - padding * 3;
            mainlb.Width = Math.Min(mainlb.Width, this.Width - itempic.Right - padding * 2); // Max width constraint
            mainlb.Location = new Point(itempic.Right + padding, itempic.Top + (int)(itemPicHeight * mainlbOffset));
            mainlb.Height = desclb.Top - mainlb.Top - padding; // Y-axis constraint till start of desclb

            // Adjust desclb (Description Label) size and location
            desclb.Width = mainlb.Width;
            // Increase this value to lower desclb further
            int extrapadding = padding ;
            desclb.Location = new Point(itempic.Right + padding, itempic.Top + (itemPicHeight / 2) - (desclb.Height / 2)+extrapadding);

            desclb.Height = pricelb.Top - desclb.Top - padding; // Y-axis constraint till start of pricelb

            // Adjust pricelb (Price Label) size and location
            pricelb.Width = mainlb.Width;
            pricelb.Location = new Point(itempic.Right + padding, itempic.Bottom - (int)(itemPicHeight * pricelbOffset) - pricelb.Height);
            pricelb.Height = itempic.Bottom - pricelb.Top - padding; // Y-axis constraint till bottom of itempic

            // Adjust addbtn (Button) size and location
            addbtn.Width = this.Width - padding * 5;
            addbtn.Location = new Point(padding, this.Height - addbtn.Height - padding);
        }
        public void AdjustLabelSizes()
        {
            int padding = this.ClientSize.Width / 60; // Adjust padding as needed
            int itemPicSize = (this.Width * 2) / 5; // Set itempic width and height to 2/5 of the UserControl width
            int itemPicHeight = 2 * (this.Height) / 3;

            // Calculate maximum width for the labels
            int maxLabelWidth = this.Width - itempic.Width - padding * 3;

            // Adjust mainlb (Main Label) size and location
            mainlb.MaximumSize = new Size(maxLabelWidth, itemPicHeight / 3); // Limit mainlb height to 1/3 of itemPicHeight
            mainlb.Size = new Size(maxLabelWidth, mainlb.Height);
            mainlb.Location = new Point(itempic.Right + padding, itempic.Top); // Align mainlb with the top of itempic

            // Adjust desclb (Description Label) size and location
            desclb.MaximumSize = new Size(maxLabelWidth, itemPicHeight / 3); // Limit desclb height to 1/3 of itemPicHeight
            desclb.Size = new Size(maxLabelWidth, desclb.Height);

            // Increase the Y coordinate to lower the desclb
            int extraPadding = padding * 100000; // Increase this value to lower desclb further
            desclb.Location = new Point(itempic.Right + padding, itempic.Top + mainlb.Height + extraPadding);
            // Adjust pricelb (Price Label) size and location
            pricelb.MaximumSize = new Size(maxLabelWidth, itemPicHeight / 3); // Limit pricelb height to 1/3 of itemPicHeight
            pricelb.Size = new Size(maxLabelWidth, pricelb.Height);
            pricelb.Location = new Point(itempic.Right + padding, itempic.Bottom - pricelb.Height); // Align pricelb with the bottom of itempic

            // Adjust addbtn (Button) size and location
            addbtn.Width = this.Width - padding * 5;
            addbtn.Location = new Point(padding, this.Height - addbtn.Height - padding);
        }


        private void panel1_Resize(object sender, EventArgs e)
        {
            AdjustInternalControlSizes();
      

       
        }

        private void mainlb_Click(object sender, EventArgs e)
        {

        }

        private void itemUS_Load(object sender, EventArgs e)
        {
            AdjustInternalControlSizes();
            AdjustLabelSizes();
        }

        private void itemUS_Resize(object sender, EventArgs e)
        {
            AdjustPanelSize();
   
          
        }

        private void desclb_Click(object sender, EventArgs e)
        {

        }
    }
}
//labels badoun t3dil (iza l cheche zghire l katibe mabi bayno)
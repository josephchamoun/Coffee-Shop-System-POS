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
            AdjustInternalControlSizes();
        }
        public void AdjustInternalControlSizes()
        {
            int padding = this.ClientSize.Width/30; // Adjust padding as needed
            int itemPicSize = (this.Width * 2) / 5; // Set itempic width and height to 2/5 of the UserControl width
            int itemPicHeight = 2 * (this.Height) / 3;
            // Adjust itempic (PictureBox) size and location
            itempic.Width = itemPicSize;
            itempic.Height = itemPicHeight;
            itempic.Location = new Point(padding, padding);

            // Adjust mainlb (Main Label) size and location
            mainlb.Width = this.Width - itempic.Right - padding * 3;
            mainlb.Location = new Point(itempic.Right + padding, padding);

            // Adjust desclb (Description Label) size and location
            desclb.Width = mainlb.Width;
            desclb.Location = new Point(itempic.Right + padding, mainlb.Bottom + padding / 2);

            // Adjust pricelb (Price Label) size and location
            pricelb.Width = mainlb.Width;
            pricelb.Location = new Point(itempic.Right + padding, desclb.Bottom + padding / 2);

            // Adjust addbtn (Button) size and location
            addbtn.Width = this.Width - padding * 5;
            addbtn.Location = new Point(padding, this.Height - addbtn.Height - padding);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            AdjustInternalControlSizes();
        }
    }
}
//labels badoun t3dil (iza l cheche zghire l katibe mabi bayno)
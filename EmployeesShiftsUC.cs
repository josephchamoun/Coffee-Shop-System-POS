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
    public partial class EmployeesShiftsUC : UserControl
    {
        public EmployeesShiftsUC()
        {
            InitializeComponent();
            AdjustControlSizesAndPositions();
        }
        private void AdjustControlSizesAndPositions()
        {
            // Get the dimensions of the user control
            int userControlWidth = this.Width;
            int userControlHeight = this.Height;

            // Set the mainpanel size to match the user control size
            mainpanel.Size = new Size(userControlWidth, userControlHeight);

            // Define proportions
            float controlsTotalWidthProportion = 0.33f; // The total width for pic, namelb, and role combined (33%)
            float infopanelWidthProportion = 0.67f; // infopanel takes 67% of the mainpanel's width
            float spacingProportion = 0.02f; // 2% of the panel's width for spacing

            // Calculate total width for pic, namelb, and role combined
            int controlsTotalWidth = (int)(mainpanel.Width * controlsTotalWidthProportion);

            // Calculate individual control widths
            int spacing = (int)(mainpanel.Width * spacingProportion);

            int picWidth = controlsTotalWidth / 9; // Pic is around three times smaller than 1/3
            int nameWidth = controlsTotalWidth / 3; // Name label takes 1/3 of the total width
            int roleWidth = nameWidth; // Role takes the same width as namelb for alignment

            // Calculate control height
            int controlHeight = (int)(mainpanel.Height * 0.5f); // Controls are 50% of the panel's height

            // Set size for pic and make it round
            pic.Size = new Size(picWidth, picWidth); // Square dimensions to make it round
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pic.Width, pic.Height);
            pic.Region = new Region(path);

            // Calculate positions for pic
            int picX = spacing; // Start at the beginning with a small space
            int picY = (mainpanel.Height - pic.Height) / 2; // Center vertically in the mainpanel

            // Set position for pic
            pic.Location = new Point(picX, picY);

            // Set size for namelb
            namelb.Size = new Size(nameWidth, namelb.Height);

            // Set size for role
            role.Size = new Size(roleWidth, role.Height);

            // Calculate combined height of namelb and role
            int combinedLabelsHeight = namelb.Height + role.Height;

            // Calculate position for namelb
            int nameX = picX + picWidth + spacing; // Next to pic with spacing
            int nameY = picY + (pic.Height - combinedLabelsHeight) / 2; // Center the two labels around the middle of pic

            // Set position for namelb
            namelb.Location = new Point(nameX, nameY);

            // Calculate position for role
            int roleX = nameX; // Same X-axis as namelb
            int roleY = nameY + namelb.Height; // Directly below namelb

            // Set position for role
            role.Location = new Point(roleX, roleY);

            // Calculate size and position for infopanel
            int infopanelX = controlsTotalWidth + spacing; // Start after controls' total width with spacing

            // Ensure infopanel does not exceed mainpanel width
            int infopanelWidth = mainpanel.Width - infopanelX; // Remaining width in mainpanel
            infopanelWidth = (int)Math.Min(infopanelWidth, mainpanel.Width * infopanelWidthProportion); // Ensure it does not exceed proportion

            int infopanelHeight = mainpanel.Height;

            // Set size and position for infopanel
            infopanel.Size = new Size(infopanelWidth, infopanelHeight);
            infopanel.Location = new Point(infopanelX, 0); // Align to top of panel
        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void infopanel_Resize(object sender, EventArgs e)
        {

        }

        private void mainpanel_Resize(object sender, EventArgs e)
        {
            AdjustControlSizesAndPositions();
        }
    }
}

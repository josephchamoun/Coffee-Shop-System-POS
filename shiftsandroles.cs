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
    public partial class shiftsandroles : Form
    {
        public shiftsandroles()
        {
            InitializeComponent();
            AdjustControlLayout();
            AdjustDatePanelControls();
        }
        private void AdjustControlLayout()
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Adjusted proportional margins and spacing
            int horizontalMargin = formWidth / 40; // Margin from the left edge
            int verticalMargin = formHeight / 40;  // Margin from the top edge
            int controlSpacing = formHeight / 30;  // Spacing between controls

            // Define common width for horizontally aligned controls
            int commonWidth = formWidth - 2 * horizontalMargin;

            // Adjust roleslb location
            roleslb.Location = new Point(horizontalMargin, verticalMargin);
            roleslb.AutoSize = true;

            // Adjust roleflp settings
            int roleFlpHeight = formHeight / 8; // Height of roleflp
            roleflp.Size = new Size(commonWidth - horizontalMargin, roleFlpHeight); // Adjust width to fill space
            roleflp.Location = new Point(horizontalMargin, roleslb.Bottom + controlSpacing);

            // Adjust addrolebtn size and location
            int buttonDiameter = Math.Min(horizontalMargin * 2, roleFlpHeight / 3); // Diameter of the button
            addrolebtn.Size = new Size(buttonDiameter, buttonDiameter); // Set width and height to be the same for a circle
            addrolebtn.Location = new Point(roleflp.Right + controlSpacing, roleflp.Top + (roleFlpHeight - buttonDiameter) / 2);

            // Adjust shiftlb location
            shiftlb.Location = new Point(horizontalMargin, roleflp.Bottom + controlSpacing);
            shiftlb.AutoSize = true;

            // Adjust combobox size and location
            int comboBoxWidth = formWidth / 8; // Width of the combobox
            combobox.Size = new Size(comboBoxWidth, shiftlb.Height);
            combobox.Location = new Point(shiftlb.Right + controlSpacing, shiftlb.Top);

            // Adjust daysoffbtn size and location
            int buttonWidth = formWidth / 5; // Width of the button
            daysoffbtn.Size = new Size(buttonWidth, (shiftlb.Height * 2) - (formHeight / 60)); // Height of the button
            daysoffbtn.Location = new Point(combobox.Right + controlSpacing, shiftlb.Top);

            // Adjust workingdaysbtn size and location
            workingdaysbtn.Size = new Size(buttonWidth, (shiftlb.Height * 2) - (formHeight / 60)); // Same size as daysoffbtn
            workingdaysbtn.Location = new Point(daysoffbtn.Right + controlSpacing, shiftlb.Top);

            // Adjust datepanel size and location
            int datePanelHeight = formHeight / 20; // Height of the datepanel
            datepanel.Size = new Size(commonWidth, datePanelHeight);
            datepanel.Location = new Point(horizontalMargin, Math.Max(daysoffbtn.Bottom, shiftlb.Bottom) + controlSpacing);

            // Adjust searchbar size and location
            int searchBarWidth = formWidth / 4; // Width of the searchbar
            searchbar.Size = new Size(searchBarWidth, shiftlb.Height + controlSpacing); // Height adjusted
            searchbar.Location = new Point(datepanel.Left, datepanel.Bottom + controlSpacing); // Below the datepanel

            // Adjust daysflp size and location
            int daysflpHeight = searchbar.Height * 2; // Height of the daysflp
            daysflp.Size = new Size(commonWidth - searchBarWidth - controlSpacing, daysflpHeight); // Width adjusted
            daysflp.Location = new Point(searchbar.Right + controlSpacing, searchbar.Top); // Align with searchbar

            // Adjust mainflp size and location
            int mainFlpHeight = formHeight - daysflp.Bottom - 2 * controlSpacing; // Height of the mainflp
            mainflp.Size = new Size(commonWidth, mainFlpHeight);
            mainflp.Location = new Point(horizontalMargin, daysflp.Bottom + controlSpacing);
        }




        private void AdjustDatePanelControls()
        {
            int datePanelWidth = datepanel.ClientSize.Width;
            int datePanelHeight = datepanel.ClientSize.Height;

            // Define margins and spacing
            int sideMargin = datePanelWidth / 40; // Small margin on the sides
            int spacingBetweenControls = datePanelWidth / 60; // Spacing between controls

            // Center vertical alignment
            int centerY = datePanelHeight / 2;

            // Position monthandyearlb
            monthandyearlb.Location = new Point(0, centerY - monthandyearlb.Height / 2);

            // Position betweenlb in the middle of datepanel (x-axis)
            int betweenlbWidth = betweenlb.Width;
            int betweenlbX = (datePanelWidth - betweenlbWidth) / 2;
            betweenlb.Location = new Point(betweenlbX, centerY - betweenlb.Height / 2);

            // Position lastdaylb to the right of betweenlb
            int lastdaylbX = betweenlb.Right + spacingBetweenControls;
            lastdaylb.Location = new Point(lastdaylbX, centerY - lastdaylb.Height / 2);

            // Position firstdaylb to the left of betweenlb
            int firstdaylbX = betweenlb.Left - firstdaylb.Width - spacingBetweenControls;
            firstdaylb.Location = new Point(firstdaylbX, centerY - firstdaylb.Height / 2);

            // Position leftarrowbtn to the left of firstdaylb
            int leftarrowbtnX = firstdaylb.Left - leftarrowbtn.Width - spacingBetweenControls;
            leftarrowbtn.Location = new Point(leftarrowbtnX, centerY - leftarrowbtn.Height / 2);

            // Position rightarrowbtn to the right of lastdaylb
            int rightarrowbtnX = lastdaylb.Right + spacingBetweenControls;
            rightarrowbtn.Location = new Point(rightarrowbtnX, centerY - rightarrowbtn.Height / 2);
        }






        private void userControl21_Load(object sender, EventArgs e)
        {
                   }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void daysoffbtn_Click(object sender, EventArgs e)
        {
            //hayde bas ef2os 3laya lezim l color tb3 l UC tb3 l shiftdaysUC yerja3 tabi3e (ma ka2eno 7ada fe2is 3le) w ba3da ybayin days off tb3 kel employee 7asab iza mna2a weekly monthly etc...(akid ma betbayin l shift tb3o(8:00am - 4:00PM )
            //wa2ta nef2os 3a nhar (iza fe2sin 3a daysoff) bi farjina iza nhar off aw no (betrouh l number of days off (weekly)

        }


        private void Workingdaysbtn_Click(object sender, EventArgs e)
        {
            //mtl l daysoffbtn bas ta nf2sa w 7asab ech mne2eyin (weekly-monthly) w bas nf2os edit btn bi sir fina n7et kel 7ada l schedule taba3o 3a kel l chaher fared marra
            //w akid iza badna n8ayir schedule 3a nhar masalan, fina na2e aya nhar w n8ayero (ma 3ad menkoun fe2sin 3a working days)(mensir fe2sin 3al nhar li badna ne3ti off
        }

        private void shiftsandroles_Resize(object sender, EventArgs e)
        {
            AdjustControlLayout();
            AdjustDatePanelControls();
        }
    }
}

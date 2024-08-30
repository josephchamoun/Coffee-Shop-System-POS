using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace summer2
{
    public partial class Billings : Form
    {
        public static Billings billingsinst;
        public Billings()
        {
            InitializeComponent();
            billingsinst = this;
            AdjustLeftPanelSize();
            AdjustPanelSize();
            resizeorderpanel();
            resizepanel2();
            resizesalespanel();
            AdjustLeftPanel4Controls();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Products");
            dataTable.Columns.Add("Units");
            dataTable.Rows.Add("Salt", "5");
            dataTable.Rows.Add("Sugar", "6");
            dataGridView1.DataSource = dataTable;

        }

        private void Billings_Load(object sender, EventArgs e)
        {
            AdjustPanelSize();
            AdjustLeftPanelSize();
            resizepanel2();
            resizesalespanel();
            resizeorderpanel();
            AdjustLeftPanel4Controls();
        }
        private void AdjustPanelSize()
        {
            // Get the form dimensions
            int formHeight = this.ClientSize.Height;
            int formWidth = this.ClientSize.Width;

            // Set the right panel size and location
            rightPanel.Size = new Size(formWidth / 3, formHeight - 20);
            rightPanel.Location = new Point(formWidth - rightPanel.Width, 0);

            int buttonHeight = 30;
            int buttonWidth = (rightPanel.Width - 20) / 3;
            int buttonSpacing = 5;
            int panelSpacing = 10;
            int chartSpacing = 10;

            // Adjust button sizes and locations
            buttons1.Size = new Size(buttonWidth, buttonHeight);
            buttons1.Location = new Point(5, 5);

            buttons2.Size = new Size(buttonWidth, buttonHeight);
            buttons2.Location = new Point(buttons1.Right + buttonSpacing, 5);

            buttons3.Size = new Size(buttonWidth, buttonHeight);
            buttons3.Location = new Point(buttons2.Right + buttonSpacing, 5);

            // Adjust the anotherPanel to align with the panels in the left panel
            int panelHeight = (int)(rightPanel.Height * 0.2) - buttonHeight - panelSpacing;
            anotherPanel.Location = new Point(5, buttons1.Bottom + panelSpacing);  // Ensure alignment here
            anotherPanel.Size = new Size(rightPanel.Width - 10, panelHeight);

            // Calculate the total available height for charts after buttons and anotherPanel
            int availableHeightForCharts = rightPanel.Height - anotherPanel.Bottom - (2 * chartSpacing);

            // Adjust chart sizes to fit both in the available space
            int chartHeight = availableHeightForCharts / 2; // Half of the available height

            // Adjust the topProductChart size and location
            topProductChart.Size = new Size(rightPanel.Width - 10, chartHeight);
            topProductChart.Location = new Point(5, anotherPanel.Bottom + chartSpacing);

            // Add and adjust the leastSoldProducts chart size and location
            leastsoldproducts.Size = new Size(rightPanel.Width - 10, chartHeight);
            leastsoldproducts.Location = new Point(5, topProductChart.Bottom + chartSpacing);
        }


        private void AdjustLeftPanelSize()
        {
            // Get the form dimensions
            int formHeight = this.ClientSize.Height;
            int formWidth = this.ClientSize.Width;

            // Adjust the left panel size to fill the remaining width of the form
            leftPanel.Size = new Size(formWidth - rightPanel.Width, formHeight - 20);
            leftPanel.Location = new Point(0, 0);

            int buttonHeight = 30;
            int buttonWidth = (rightPanel.Width - 20) / 3;
            int squareButtonSize = buttonHeight;
            int buttonSpacing = 5;
            int panelSpacing = 10;
            int extraPanelSpacing = 20; // Increased spacing between panels

            dateTimePicker1.Size = new Size((leftPanel.Width - 4 * buttonSpacing - 2 * buttonWidth - squareButtonSize) / 2, buttonHeight);
            dateTimePicker1.Location = new Point(5, 5);

            dateTimePicker2.Size = new Size((leftPanel.Width - 4 * buttonSpacing - 2 * buttonWidth - squareButtonSize) / 2, buttonHeight);
            dateTimePicker2.Location = new Point(dateTimePicker1.Right + buttonSpacing, 5);

            leftButton1.Size = new Size(squareButtonSize, buttonHeight);
            leftButton1.Location = new Point(dateTimePicker2.Right + buttonSpacing, 5);

            leftButton2.Size = new Size(buttonWidth, buttonHeight);
            leftButton2.Location = new Point(leftButton1.Right + buttonSpacing, 5);

            leftButton3.Size = new Size(buttonWidth, buttonHeight);
            leftButton3.Location = new Point(leftButton2.Right + buttonSpacing, 5);

            // Calculate new width for the panels to allow spacing between them
            int panelWidth = (leftPanel.Width - 15) / 2; // Total width minus spacing

            // Adjust the sizes of orderpanel and leftPanel2 to fill the width but have space between them
            orderpanel.Size = new Size(panelWidth - 5, (int)(rightPanel.Height * 0.2) - buttonHeight - panelSpacing);
            orderpanel.Location = new Point(5, leftButton1.Bottom + panelSpacing);

            leftPanel2.Size = new Size(panelWidth - 5, (int)(rightPanel.Height * 0.2) - buttonHeight - panelSpacing);
            leftPanel2.Location = new Point(orderpanel.Right + 10, leftButton1.Bottom + panelSpacing); // Add space between panels

            int chartHeight = (int)(rightPanel.Height / 2.0) - panelSpacing;
            leftPanelChart.Size = new Size(leftPanel.Width - 10, chartHeight);
            leftPanelChart.Location = new Point(5, orderpanel.Bottom + panelSpacing);

            int panel34Height = (int)(rightPanel.Height / 2.0) - panelSpacing;
            leftPanel3.Size = new Size((leftPanel.Width - 15) / 3, panel34Height);
            leftPanel3.Location = new Point(5, leftPanelChart.Bottom + panelSpacing);

            leftPanel4.Size = new Size((2 * (leftPanel.Width - 15)) / 3, panel34Height);
            leftPanel4.Location = new Point(leftPanel3.Right + panelSpacing, leftPanelChart.Bottom + panelSpacing);
        }



        private void resizeorderpanel()
        {
            int panelWidth = orderpanel.Width;
            int panelHeight = orderpanel.Height;

            // Set pictureBox size and position
            orpic.Width = panelWidth / 5;
            orpic.Height = panelHeight;
            orpic.Location = new Point(0, 0);

            // Calculate appropriate font sizes based on panel size
            float baseFontSize = panelHeight / 5f; // Base font size, adjust as needed
            float orderlbFontSize = baseFontSize; // Font size for "Orders" label
            float ornblbFontSize = baseFontSize * 1.4f; // Font size for "53" label
            float perlbFontSize = baseFontSize * 0.8f; // Font size for right label

            // Calculate combined height of orderlb and ornblb
            using (Graphics g = orderlb.CreateGraphics())
            {
                SizeF orderlbSize = g.MeasureString(orderlb.Text, new Font(orderlb.Font.FontFamily, orderlbFontSize));
                SizeF ornblbSize = g.MeasureString(ornblb.Text, new Font(ornblb.Font.FontFamily, ornblbFontSize));

                float totalLabelsHeight = orderlbSize.Height + ornblbSize.Height;
                float verticalCenter = (panelHeight - totalLabelsHeight) / 2;

                // Set label1 size and position
                orderlb.Font = new Font(orderlb.Font.FontFamily, orderlbFontSize);
                orderlb.Location = new Point(panelWidth / 3, (int)verticalCenter);
                orderlb.AutoSize = true;

                // Set label2 size and position
                ornblb.Font = new Font(ornblb.Font.FontFamily, ornblbFontSize);
                ornblb.Location = new Point(panelWidth / 3, (int)(verticalCenter + orderlbSize.Height));
                ornblb.AutoSize = true;
            }

            // Set label3 size and position
            perlb.Font = new Font(perlb.Font.FontFamily, perlbFontSize);
            perlb.AutoSize = true; // Ensure label's width is correct before positioning
            int perlbLeftOffset = panelWidth - perlb.Width - 10; // Move a little bit to the left
            perlb.Location = new Point(perlbLeftOffset, panelHeight / 2 - perlb.Height / 2);
        }
        private void resizepanel2()
        {
            int panelWidth = leftPanel2.Width;
            int panelHeight = leftPanel2.Height;

            // Set pictureBox size and position
            pic2.Width = panelWidth / 5;
            pic2.Height = panelHeight;
            pic2.Location = new Point(0, 0);

            // Calculate appropriate font sizes based on panel size
            float baseFontSize = panelHeight / 5f; // Base font size, adjust as needed
            float orderlbFontSize = baseFontSize; // Font size for "Orders" label
            float ornblbFontSize = baseFontSize * 1.4f; // Font size for "53" label
            float perlbFontSize = baseFontSize * 0.8f; // Font size for right label

            // Calculate combined height of orderlb and ornblb
            using (Graphics g = lb1.CreateGraphics())
            {
                SizeF orderlbSize = g.MeasureString(lb1.Text, new Font(lb1.Font.FontFamily, orderlbFontSize));
                SizeF ornblbSize = g.MeasureString(lb1.Text, new Font(lb1.Font.FontFamily, ornblbFontSize));

                float totalLabelsHeight = orderlbSize.Height + ornblbSize.Height;
                float verticalCenter = (panelHeight - totalLabelsHeight) / 2;

                // Set label1 size and position
                lb1.Font = new Font(lb1.Font.FontFamily, orderlbFontSize);
                lb1.Location = new Point(panelWidth / 3, (int)verticalCenter);
                lb1.AutoSize = true;

                // Set label2 size and position
                lb2.Font = new Font(lb2.Font.FontFamily, ornblbFontSize);
                lb2.Location = new Point(panelWidth / 3, (int)(verticalCenter + orderlbSize.Height));
                lb2.AutoSize = true;
            }

            // Set label3 size and position
            perlb1.Font = new Font(perlb1.Font.FontFamily, perlbFontSize);
            perlb1.AutoSize = true; // Ensure label's width is correct before positioning
            int perlbLeftOffset = panelWidth - perlb1.Width - 10; // Move a little bit to the left
            perlb1.Location = new Point(perlbLeftOffset, panelHeight / 2 - perlb1.Height / 2);
        }
        private void resizesalespanel()
        {
            int panelWidth = anotherPanel.Width;
            int panelHeight = anotherPanel.Height;

            // Set pictureBox size and position
            pic3.Width = panelWidth / 5;
            pic3.Height = panelHeight;
            pic3.Location = new Point(0, 0);

            // Calculate appropriate font sizes based on panel size
            float baseFontSize = panelHeight / 5f; // Base font size, adjust as needed
            float orderlbFontSize = baseFontSize; // Font size for "Orders" label
            float ornblbFontSize = baseFontSize * 1.4f; // Font size for "53" label
            float perlbFontSize = baseFontSize * 0.8f; // Font size for right label

            // Calculate combined height of orderlb and ornblb
            using (Graphics g = lb3.CreateGraphics())
            {
                SizeF orderlbSize = g.MeasureString(lb3.Text, new Font(lb3.Font.FontFamily, orderlbFontSize));
                SizeF ornblbSize = g.MeasureString(lb3.Text, new Font(lb3.Font.FontFamily, ornblbFontSize));

                float totalLabelsHeight = orderlbSize.Height + ornblbSize.Height;
                float verticalCenter = (panelHeight - totalLabelsHeight) / 2;

                // Set label1 size and position
                lb3.Font = new Font(lb3.Font.FontFamily, orderlbFontSize);
                lb3.Location = new Point(panelWidth / 3, (int)verticalCenter);
                lb3.AutoSize = true;

                // Set label2 size and position
                lb4.Font = new Font(lb4.Font.FontFamily, ornblbFontSize);
                lb4.Location = new Point(panelWidth / 3, (int)(verticalCenter + orderlbSize.Height));
                lb4.AutoSize = true;
            }

            // Set label3 size and position
            perlb2.Font = new Font(perlb2.Font.FontFamily, perlbFontSize);
            perlb2.AutoSize = true; // Ensure label's width is correct before positioning
            int perlbLeftOffset = panelWidth - perlb2.Width - 10; // Move a little bit to the left
            perlb2.Location = new Point(perlbLeftOffset, panelHeight / 2 - perlb2.Height / 2);
        }
        private void AdjustLeftPanel4Controls()
        {
            int labelHeight = 30;
            int labelSpacing = 5;

            label1.Size = new Size(leftPanel4.Width - 10, labelHeight);
            label1.Location = new Point(5, 5);

            dataGridView1.Size = new Size(leftPanel4.Width - 10, leftPanel4.Height - labelHeight - labelSpacing - 10);
            dataGridView1.Location = new Point(5, label1.Bottom + labelSpacing);
        }



        private void Billings_Resize(object sender, EventArgs e)
        {
            AdjustPanelSize();
            AdjustLeftPanelSize();
            resizeorderpanel();
            resizepanel2();
            resizesalespanel();
            AdjustLeftPanel4Controls();
        }
    }
}

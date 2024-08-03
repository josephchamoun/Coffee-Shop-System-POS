using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Siticone.Desktop.UI.WinForms;

namespace summer2
{
    public partial class Form1 : Form
    {
        public static Form1 form1inst;
        Billings billings;
        Home home;
        public Form1()
        {
           // MaterialSkinManager materialskinmanager;
            InitializeComponent();
            home = new Home();
            billings = new Billings();
            form1inst = this;
           // materialskinmanager = MaterialSkinManager.Instance;
           // materialskinmanager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Cyan700, TextShade.WHITE);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            // Do nothing to prevent form movement
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            // Do nothing to prevent form movement
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Form background = new Form();
            try
            {
                using (Form2 frm = new Form2())
                {
                    background.StartPosition = FormStartPosition.Manual;
                    background.FormBorderStyle = FormBorderStyle.None;
                    background.Opacity = .50d;
                    background.BackColor = Color.Black;
                    background.WindowState = FormWindowState.Maximized;
                    background.Location = this.Location;
                    background.ShowInTaskbar = false;
                    background.Show();



                    frm.Owner = background;
                    frm.ShowDialog();
                    background.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                background.Dispose();
            }
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("joseph push");
           
            home.Show();
        }

        private void siticoneCircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            billings.Show();
        }
    }
}

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
        }

        private void Workingdaysbtn_Click(object sender, EventArgs e)
        {
            //mtl l daysoffbtn bas ta nf2sa w 7asab ech mne2eyin (weekly-monthly) w bas nf2os edit btn bi sir fina n7et kel 7ada l schedule taba3o 3a kel l chaher fared marra
            //w akid iza badna n8ayir schedule 3a nhar masalan, fina na2e aya nhar w n8ayero (ma 3ad menkoun fe2sin 3a working days)(mensir fe2sin 3al nhar li badna ne3ti off
        }
    }
}

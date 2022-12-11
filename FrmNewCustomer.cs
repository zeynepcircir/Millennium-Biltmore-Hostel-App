using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millennium_Biltmore_Hostel_App
{
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void BtnRoom101_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "101";
        }

        private void BtnRoom102_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "102";
        }

        private void BtnRoom103_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "103";
        }

        private void BtnRoom104_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "104";
        }

        private void BtnRoom105_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "105";
        }

        private void BtnRoom106_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "106";
        }

        private void BtnRoom201_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "201";
        }

        private void BtnRoom202_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "202";
        }

        private void BtnRoom203_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "203";
        }

        private void BtnRoom204_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "204";
        }

        private void BtnRoom205_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "205";
        }

        private void BtnRoom206_Click(object sender, EventArgs e)
        {
            TxtRoomNumber.Text = "206";
        }

        private void BtnFullRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blue Colored Buttons Indicate that the Rooms are Full");
        }

        private void BtnEmptyRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Green Colored Buttons Indicate that the Rooms are Empty");
        }

        private void DtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            int Pricing;
            DateTime SmallDate = Convert.ToDateTime(DtpDateOfEntry.Text);
            DateTime BigDate = Convert.ToDateTime(DtpReleaseDate.Text);
            
            TimeSpan Result = BigDate - SmallDate;

            label10.Text = Result.TotalDays.ToString();

            Pricing = Convert.ToInt32(label10.Text) * 50;
            TxtPricing.Text = Pricing.ToString();   
        }   
    }
}

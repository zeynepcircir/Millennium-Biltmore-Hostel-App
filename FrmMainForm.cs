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
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminLogin fr = new FrmAdminLogin(); 
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNewCustomer fr = new FrmNewCustomer();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            FrmCustomers customers = new FrmCustomers();    
            customers.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Millennium Biltmore Hostel Application - 2022 / San Francisco");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRooms fr = new FrmRooms();
            fr.Show();
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

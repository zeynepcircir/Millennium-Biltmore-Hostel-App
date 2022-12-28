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

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAdminLogin fr = new FrmAdminLogin(); 
            fr.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmNewCustomer fr = new FrmNewCustomer();
            fr.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            FrmCustomers customers = new FrmCustomers();    
            customers.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Millennium Biltmore Hostel Application - 2022 / San Francisco");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmRooms fr = new FrmRooms();
            fr.Show();
        }

        private void FrmMainForm_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmIncomeExpenditure fr = new FrmIncomeExpenditure();
            fr.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            StocksandInvoices fr = new StocksandInvoices(); 
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmListentoRadio fr = new FrmListentoRadio();
            fr.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmNewspapers fr = new FrmNewspapers();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmUpdatePassword fr = new FrmUpdatePassword();
            fr.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmNewCustomer fr = new FrmNewCustomer();   
            fr.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmRooms fr = new FrmRooms();
            fr.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FrmIncomeExpenditure fr = new FrmIncomeExpenditure();
            fr.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FrmNewspapers fr = new FrmNewspapers();
            fr.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

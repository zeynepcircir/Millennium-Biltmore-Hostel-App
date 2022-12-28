using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Millennium_Biltmore_Hostel_App
{
    public partial class FrmIncomeExpenditure : Form
    {
        public FrmIncomeExpenditure()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-OKFPVGR5\\SQLEXPRESS;Initial Catalog=MillenniumBilmoreHostel;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            int staff;
            staff = Convert.ToInt16(textBox1.Text);
            LblStaffSalary.Text = (staff * 1500).ToString();

            int result;
            result = Convert.ToInt32(LblTotalSafe.Text) - (Convert.ToInt32(LblStaffSalary.Text) + Convert.ToInt32(LblPAFood.Text) + Convert.ToInt32(LblPADrink.Text) + Convert.ToInt32(LblPASnack.Text) + Convert.ToInt32(LblInvoicesElectric.Text) + Convert.ToInt32(LblInvoicesWater.Text) + Convert.ToInt32(LblInvoicesInternet.Text));
            LblResult.Text = result.ToString();
        }

        private void FrmIncomeExpenditure_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select sum(Pricing) as sum from AddCustomer", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                LblTotalSafe.Text = read["sum"].ToString();
            }
            connection.Close();

           


            connection.Open();
            SqlCommand command2 = new SqlCommand("Select sum(Food) as sum1 from Stocks", connection);
            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
                LblPAFood.Text = read2["sum1"].ToString();
            }
            connection.Close();



            connection.Open();
            SqlCommand command3 = new SqlCommand("Select sum(Drink) as sum2 from Stocks", connection);
            SqlDataReader read3 = command3.ExecuteReader();
            while (read3.Read())
            {
                LblPADrink.Text = read3["sum2"].ToString();
            }
            connection.Close();




            connection.Open();
            SqlCommand command4 = new SqlCommand("Select sum(Snack) as sum3 from Stocks", connection);
            SqlDataReader read4 = command4.ExecuteReader();
            while (read4.Read())
            {
                LblPASnack.Text = read4["sum3"].ToString();
            }
            connection.Close();


            connection.Open();
            SqlCommand command5 = new SqlCommand("Select sum(Electric) as sum4 from Invoices", connection);
            SqlDataReader read5 = command5.ExecuteReader();
            while (read5.Read())
            {
                LblInvoicesElectric.Text = read5["sum4"].ToString();
            }
            connection.Close();


            connection.Open();
            SqlCommand command6 = new SqlCommand("Select sum(Water) as sum5 from Invoices", connection);
            SqlDataReader read6 = command6.ExecuteReader();
            while (read6.Read())
            {
                LblInvoicesWater.Text = read6["sum5"].ToString();
            }
            connection.Close();



            connection.Open();
            SqlCommand command7 = new SqlCommand("Select sum(Internet) as sum6 from Invoices", connection);
            SqlDataReader read7 = command7.ExecuteReader();
            while (read7.Read())
            {
                LblInvoicesInternet.Text = read7["sum6"].ToString();
            }
            connection.Close();
        }

        private void LblTotalSafe_Click(object sender, EventArgs e)
        {

        }

        private void LblStaffSalary_Click(object sender, EventArgs e)
        {

        }

        private void LblPAFood_Click(object sender, EventArgs e)
        {

        }

        private void LblInvoicesElectric_Click(object sender, EventArgs e)
        {

        }

        private void LblPADrink_Click(object sender, EventArgs e)
        {

        }

        private void LblInvoicesWater_Click(object sender, EventArgs e)
        {

        }

        private void LblPASnack_Click(object sender, EventArgs e)
        {

        }

        private void LblInvoicesInternet_Click(object sender, EventArgs e)
        {

        }

        private void LblResult_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Millennium_Biltmore_Hostel_App
{
    public partial class StocksandInvoices : Form
    {
        public StocksandInvoices()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-OKFPVGR5\\SQLEXPRESS;Initial Catalog=MillenniumBilmoreHostel;Integrated Security=True");

        private void data()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Stocks", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["Food"].ToString();
                add.SubItems.Add(read["Drink"].ToString());
                add.SubItems.Add(read["Snack"].ToString());
                listView1.Items.Add(add);
            }
            connection.Close();
        }

        private void data2()
        {
            listView2.Items.Clear();
            connection.Open();
            SqlCommand command2 = new SqlCommand("select * from Invoices", connection);
            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read2["Electric"].ToString();
                add.SubItems.Add(read2["Water"].ToString());
                add.SubItems.Add(read2["Internet"].ToString());
                listView2.Items.Add(add);
            }
            connection.Close();
        }



        private void BtnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Stocks(Food,Drink,Snack)values( '" + TxtFoods.Text+ "','"+ TxtDrinks.Text+"','"+ TxtSnacks.Text+"')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            data();
        
        
        }

        private void FrmStocks_Load(object sender, EventArgs e)
        {
            data();
            data2();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command2 = new SqlCommand("insert into Invoices(Electric,Water,Internet)values( '" + TxtElectric.Text + "','" + TxtWater.Text + "','" + TxtInternet.Text + "')", connection);
            command2.ExecuteNonQuery();
            connection.Close();
            data2();

        }
    }
}

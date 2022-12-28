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
    public partial class FrmMessages : Form
    {
        public FrmMessages()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-OKFPVGR5\SQLEXPRESS;Initial Catalog=MillenniumBilmoreHostel;Integrated Security=True");

        private void showdata()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Messages", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem insert = new ListViewItem();
                insert.Text = read["MessageId"].ToString();
                insert.SubItems.Add(read["NameSurname"].ToString());
                insert.SubItems.Add(read["Message"].ToString());
                
                listView1.Items.Add(insert);
            }
            connection.Close();
        }
        

        
        private void FrmMessages_Load(object sender, EventArgs e)
        {
            showdata();
        }
        int id = 0;
        

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Messages(NameSurname,Message) values('" + textBox1.Text + "','" + richTextBox1.Text + "')", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Your Message has been Successfully Saved !..");
            connection.Close();
            showdata();
        }
    }
}

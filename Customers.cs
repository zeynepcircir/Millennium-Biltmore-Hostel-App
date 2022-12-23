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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-OKFPVGR5\SQLEXPRESS;Initial Catalog=MillenniumBilmoreHostel;Integrated Security=True");

        private void showdata()
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from AddCustomer", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem insert = new ListViewItem();
                insert.Text = read["CustomerId"].ToString();
                insert.SubItems.Add(read["Name"].ToString());
                insert.SubItems.Add(read["Surname"].ToString());
                insert.SubItems.Add(read["Gender"].ToString());
                insert.SubItems.Add(read["Telephone"].ToString());
                insert.SubItems.Add(read["Mail"].ToString());
                insert.SubItems.Add(read["TRId"].ToString());
                insert.SubItems.Add(read["RoomNum"].ToString());
                insert.SubItems.Add(read["Pricing"].ToString());
                insert.SubItems.Add(read["DateofEntry"].ToString());
                insert.SubItems.Add(read["ReleaseDate"].ToString());


                listView1.Items.Add(insert);
            }
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {

        }

        private void TxtRoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int id= 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            id= int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CboxGender.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelephone.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtIdNum.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtRoomNumber.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtPricing.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpDateOfEntry.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpReleaseDate.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update AddCustomer set Name='" + TxtName.Text + "',Surname='" + TxtSurname.Text + "',Gender='" + CboxGender.Text + "',Telephone='" + MskTxtTelephone.Text + "',Mail='" + TxtMail.Text + "',TRId='" + TxtIdNum.Text + "',RoomNum='" + TxtRoomNumber.Text + "',Pricing='" + TxtPricing.Text + "',DateofEntry='" + DtpDateOfEntry.Value.ToString("yyyy-MM-dd") + "',ReleaseDate='" + DtpReleaseDate.Value.ToString("yyyy-MM-dd") + "' where CustomerId =" + id + "", connection);
            
            command.ExecuteNonQuery();
            
            connection.Close();
            showdata();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtRoomNumber.Text == "101") { 
            connection.Open();
                SqlCommand command = new SqlCommand("delete from Room101", connection);

            command.ExecuteNonQuery();

            connection.Close();
            showdata();
            }

            if (TxtRoomNumber.Text == "102")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Room102", connection);

                command.ExecuteNonQuery();

                connection.Close();
                showdata();
            }

            if (TxtRoomNumber.Text == "103")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Room103", connection);

                command.ExecuteNonQuery();

                connection.Close();
                showdata();
            }

            if (TxtRoomNumber.Text == "104")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Room104", connection);

                command.ExecuteNonQuery();

                connection.Close();
                showdata();
            }


            if (TxtRoomNumber.Text == "105")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Room105", connection);

                command.ExecuteNonQuery();

                connection.Close();
                showdata();
            }

            if (TxtRoomNumber.Text == "106")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Room106", connection);

                command.ExecuteNonQuery();

                connection.Close();
                showdata();
            }

            if (TxtRoomNumber.Text == "201")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Room201", connection);

                command.ExecuteNonQuery();

                connection.Close();
                showdata();
            }

            if (TxtRoomNumber.Text == "202")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Room202", connection);

                command.ExecuteNonQuery();

                connection.Close();
                showdata();
            }

            if (TxtRoomNumber.Text == "203")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Room203", connection);

                command.ExecuteNonQuery();

                connection.Close();
                showdata();
            }

            if (TxtRoomNumber.Text == "204")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Room204", connection);

                command.ExecuteNonQuery();

                connection.Close();
                showdata();
            }

            if (TxtRoomNumber.Text == "205")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Room205", connection);

                command.ExecuteNonQuery();

                connection.Close();
                showdata();
            }


            if (TxtRoomNumber.Text == "206")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Room206", connection);

                command.ExecuteNonQuery();

                connection.Close();
                showdata();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtSurname.Clear();
            CboxGender.Text = "";
            MskTxtTelephone.Clear();
            TxtMail.Text = "";
            TxtIdNum.Clear();
            TxtRoomNumber.Clear();
            TxtPricing.Clear();
            DtpDateOfEntry.Text = "";
            DtpReleaseDate.Text = "";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from AddCustomer where Name like '%" + textBox1.Text + "%'", connection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem insert = new ListViewItem();
                insert.Text = read["CustomerId"].ToString();
                insert.SubItems.Add(read["Name"].ToString());
                insert.SubItems.Add(read["Surname"].ToString());
                insert.SubItems.Add(read["Gender"].ToString());
                insert.SubItems.Add(read["Telephone"].ToString());
                insert.SubItems.Add(read["Mail"].ToString());
                insert.SubItems.Add(read["TRId"].ToString());
                insert.SubItems.Add(read["RoomNum"].ToString());
                insert.SubItems.Add(read["Pricing"].ToString());
                insert.SubItems.Add(read["DateofEntry"].ToString());
                insert.SubItems.Add(read["ReleaseDate"].ToString());


                listView1.Items.Add(insert);
            }
            connection.Close();
        }
    }
}
//Data Source=LAPTOP-OKFPVGR5\SQLEXPRESS;Initial Catalog=MillenniumBilmoreHostel;Integrated Security=True
//SqlCommand command = new SqlCommand("delete from AddCustomer where CustomerId = (" + id + ")", connection);
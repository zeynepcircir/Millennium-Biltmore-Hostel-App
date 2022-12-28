using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Millennium_Biltmore_Hostel_App
{
    public partial class FrmRooms : Form
    {
        public FrmRooms()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-OKFPVGR5\\SQLEXPRESS;Initial Catalog=MillenniumBilmoreHostel;Integrated Security=True");
        private void FrmRooms_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command1 = new SqlCommand("select * from Room101",connection);
            SqlDataReader read1 = command1.ExecuteReader();

            while (read1.Read())
            {
                BtnRoom101.Text = read1["Name"].ToString() + " " + read1["Surname"].ToString();
            }
            connection.Close();
            if(BtnRoom101.Text != "101")
            {
                BtnRoom101.BackColor = Color.Blue;
            }


            connection.Open();
            SqlCommand command2 = new SqlCommand("select * from Room102", connection);
            SqlDataReader read2 = command2.ExecuteReader();

            while (read2.Read())
            {
                BtnRoom102.Text = read2["Name"].ToString() + " " + read2["Surname"].ToString();
            }
            connection.Close();
            if (BtnRoom102.Text != "102")
            {
                BtnRoom102.BackColor = Color.Blue;
            }

            connection.Open();
            SqlCommand command3 = new SqlCommand("select * from Room103", connection);
            SqlDataReader read3 = command3.ExecuteReader();

            while (read3.Read())
            {
                BtnRoom103.Text = read3["Name"].ToString() + " " + read3["Surname"].ToString();
            }
            connection.Close();
            if (BtnRoom103.Text != "103")
            {
                BtnRoom103.BackColor = Color.Blue;
            }


            connection.Open();
            SqlCommand command4 = new SqlCommand("select * from Room104", connection);
            SqlDataReader read4 = command4.ExecuteReader();

            while (read4.Read())
            {
                BtnRoom104.Text = read4["Name"].ToString() + " " + read4["Surname"].ToString();
            }
            connection.Close();
            if (BtnRoom104.Text != "104")
            {
                BtnRoom104.BackColor = Color.Blue;
            }


            connection.Open();
            SqlCommand command5 = new SqlCommand("select * from Room105", connection);
            SqlDataReader read5 = command5.ExecuteReader();

            while (read5.Read())
            {
                BtnRoom105.Text = read5["Name"].ToString() + " " + read5["Surname"].ToString();
            }
            connection.Close();
            if (BtnRoom105.Text != "105")
            {
                BtnRoom105.BackColor = Color.Blue;
            }


            connection.Open();
            SqlCommand command6 = new SqlCommand("select * from Room106", connection);
            SqlDataReader read6 = command6.ExecuteReader();

            while (read6.Read())
            {
                BtnRoom106.Text = read6["Name"].ToString() + " " + read6["Surname"].ToString();
            }
            connection.Close();
            if (BtnRoom106.Text != "106")
            {
                BtnRoom106.BackColor = Color.Blue;
            }

            connection.Open();
            SqlCommand command7 = new SqlCommand("select * from Room201", connection);
            SqlDataReader read7 = command7.ExecuteReader();

            while (read7.Read())
            {
                BtnRoom201.Text = read7["Name"].ToString() + " " + read7["Surname"].ToString();
            }
            connection.Close();
            if (BtnRoom201.Text != "201")
            {
                BtnRoom201.BackColor = Color.Blue;
            }

            connection.Open();
            SqlCommand command8 = new SqlCommand("select * from Room202", connection);
            SqlDataReader read8 = command8.ExecuteReader();

            while (read8.Read())
            {
                BtnRoom202.Text = read8["Name"].ToString() + " " + read8["Surname"].ToString();
            }
            connection.Close();
            if (BtnRoom202.Text != "202")
            {
                BtnRoom202.BackColor = Color.Blue;
            }

            connection.Open();
            SqlCommand command9 = new SqlCommand("select * from Room203", connection);
            SqlDataReader read9 = command9.ExecuteReader();

            while (read9.Read())
            {
                BtnRoom203.Text = read9["Name"].ToString() + " " + read9["Surname"].ToString();
            }
            connection.Close();
            if (BtnRoom203.Text != "203")
            {
                BtnRoom203.BackColor = Color.Blue;
            }

            connection.Open();
            SqlCommand command10 = new SqlCommand("select * from Room204", connection);
            SqlDataReader read10 = command10.ExecuteReader();

            while (read10.Read())
            {
                BtnRoom204.Text = read10["Name"].ToString() + " " + read10["Surname"].ToString();
            }
            connection.Close();
            if (BtnRoom204.Text != "204")
            {
                BtnRoom204.BackColor = Color.Blue;
            }

            connection.Open();
            SqlCommand command11 = new SqlCommand("select * from Room205", connection);
            SqlDataReader read11 = command11.ExecuteReader();

            while (read11.Read())
            {
                BtnRoom205.Text = read11["Name"].ToString() + " " + read11["Surname"].ToString();
            }
            connection.Close();
            if (BtnRoom205.Text != "205")
            {
                BtnRoom205.BackColor = Color.Blue;
            }

            connection.Open();
            SqlCommand command12 = new SqlCommand("select * from Room206", connection);
            SqlDataReader read12 = command12.ExecuteReader();

            while (read12.Read())
            {
                BtnRoom206.Text = read12["Name"].ToString() + " " + read12["Surname"].ToString();
            }
            connection.Close();
            if (BtnRoom206.Text != "206")
            {
                BtnRoom206.BackColor = Color.Blue;
            }
        }

        
    }
}

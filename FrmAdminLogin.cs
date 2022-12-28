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
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-OKFPVGR5\\SQLEXPRESS;Initial Catalog=MillenniumBilmoreHostel;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            {
                if (TxtUserName.Text == "admin" && TxtPassword.Text == "1234")
                {

                    FrmMainForm fr = new FrmMainForm();
                    fr.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect");

                }


            }

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

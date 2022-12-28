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

        
    }
}

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
using System.Xml.Linq;

namespace Millennium_Biltmore_Hostel_App
{
    public partial class FrmUpdatePassword : Form
    {
        public FrmUpdatePassword()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-OKFPVGR5\SQLEXPRESS;Initial Catalog=MillenniumBilmoreHostel;Integrated Security=True");
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update AdminLogin set Username='" + TxtUserName.Text + "', Password='" + TxtPassword.Text + "'" , connection);
                MessageBox.Show("The Password Update was Successful !..");
                command.ExecuteNonQuery();

                connection.Close();
                
            }
        }

       
    }
}

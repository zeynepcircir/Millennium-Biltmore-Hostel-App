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
    public partial class FrmNewspapers : Form
    {
        public FrmNewspapers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://www.hurriyet.com.tr");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://www.milliyet.com.tr");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://www.sozcu.com.tr");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://www.haberturk.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://www.fanatik.com.tr");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://onedio.com/");
        }
    }
}

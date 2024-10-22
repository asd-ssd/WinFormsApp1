using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class adminlogin : UserControl
    {
        public Panel panel1 = Form1.form1.panel1;
        public login login1;
        public adminlogin()
        {
            InitializeComponent();
        }
        private void admin_mode_Click(object sender, EventArgs e)
        {
            login1 = new login();
            login1.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(login1);
        }
    }
}

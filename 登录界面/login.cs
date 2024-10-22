using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.工作界面;

namespace WinFormsApp1
{
    public partial class login : UserControl
    {
        public Panel panel1 = Form1.form1.panel1;
        public login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f1.Hide();
            f2.ShowDialog();
            f1.Dispose();
        }
    }
}

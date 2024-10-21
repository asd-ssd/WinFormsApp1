using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.系统管理工作界面;
using WinFormsApp1.采购管理;

namespace WinFormsApp1
{
    public partial class caigou2 : UserControl
    {
        public Panel panel = Form2.form.panel2;
        public cgsq cgsq1;
        public thsq thsq1;
        public gys gys1;
        public ddcx ddcx1;

        public caigou2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cgsq1 = new cgsq();
            cgsq1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(cgsq1);    //将窗体一加入容器panel2
        }

        private void caigou2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            thsq1 = new thsq();
            thsq1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(thsq1);    //将窗体一加入容器panel2
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gys1 = new gys();
            gys1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(gys1);    //将窗体一加入容器panel2
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ddcx1 = new ddcx();
            ddcx1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(ddcx1);    //将窗体一加入容器panel2
        }
    }
}

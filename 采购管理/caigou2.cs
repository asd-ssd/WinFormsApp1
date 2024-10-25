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
using WinFormsApp1.采购管理.入库;

using WinFormsApp1.采购管理.采购;
using WinFormsApp1.采购管理.采购审核;

namespace WinFormsApp1
{
    public partial class caigou2 : UserControl
    {
        public Panel panel = Form2.form.panel2;
        public cgsqy cgsqy1;
        public thsq thsq1;
        public gys gys1;
        public ddcx ddcx1;
        public shx shx1;
        
        public ruku ruku1;


        public caigou2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cgsqy1 = new cgsqy();
            cgsqy1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(cgsqy1);    //将窗体一加入容器panel2
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

        private void button1_Click(object sender, EventArgs e)
        {
            shx1 = new shx();
            shx1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(shx1);    //将窗体一加入容器panel2
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            ruku1 = new ruku();
            ruku1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(ruku1);    //将窗体一加入容器panel2
        }
    }
}

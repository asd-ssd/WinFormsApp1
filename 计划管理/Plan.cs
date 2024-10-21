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
using WinFormsApp1.计划管理.三级;

namespace WinFormsApp1.Second
{
    public partial class Plan : UserControl
    {
        public Panel panel = Form2.form.panel2;
        public 生产计划及MRP shengchang1;
        public 车间作业 chejianzuoye1;
        public 领料单 lingliaodan1;
        public 派工单 paigongdan1;
        public Plan()
        {
            InitializeComponent();
        }

        private void button_MRP_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            shengchang1 = new 生产计划及MRP();
            shengchang1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(shengchang1);    //将窗体一加入容器panel2
        }

        private void button_chejian_Click(object sender, EventArgs e)
        {
            chejianzuoye1 = new 车间作业();
            chejianzuoye1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(chejianzuoye1);    //将窗体一加入容器panel2
        }

        private void button_paigong_Click(object sender, EventArgs e)
        {
            paigongdan1 = new 派工单();
            paigongdan1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(paigongdan1);    //将窗体一加入容器panel2
        }

        private void button_lingliao_Click(object sender, EventArgs e)
        {
            lingliaodan1 = new 领料单();
            lingliaodan1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(lingliaodan1);    //将窗体一加入容器panel2
        }
    }
}

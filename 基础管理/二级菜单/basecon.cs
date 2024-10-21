using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.基础信息管理工作界面;
using WinFormsApp1.工作界面;

namespace WinFormsApp1
{
    public partial class basecon : UserControl
    {
        public Panel panel = Form2.form.panel2;
        public BOMplat BOMplat1;
        public craftplat craftplat1;
        public empplat empplat1;
        public partplat partplat1;
        public basecon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BOMplat1 = new BOMplat();
            BOMplat1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(BOMplat1);    //将窗体一加入容器panel2
        }

        private void crafconbutton_Click(object sender, EventArgs e)
        {
            craftplat1 = new craftplat();
            craftplat1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(craftplat1);    //将窗体一加入容器panel2
        }

        private void empconbutton_Click(object sender, EventArgs e)
        {
            empplat1 = new empplat();
            empplat1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(empplat1);    //将窗体一加入容器panel2
        }

        private void partconbutton_Click(object sender, EventArgs e)
        {
            partplat1 = new partplat();
            partplat1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(partplat1);    //将窗体一加入容器panel2
        }
    }
}

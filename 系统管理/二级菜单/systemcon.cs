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
using WinFormsApp1.系统管理工作界面;


namespace WinFormsApp1.二级菜单
{
    public partial class systemcon : UserControl
    {
        public Panel panel = Form2.form.panel2;
        public userconplat userconplat1;
        public texplat texplat1;
        public syswhplat syswhplat1;
        public systemcon()
        {
            InitializeComponent();
        }

        private void syswhconbutton_Click(object sender, EventArgs e)
        {
            syswhplat1 = new syswhplat();
            syswhplat1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(syswhplat1);    //将窗体一加入容器panel2
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void syssetconbutton_Click(object sender, EventArgs e)
        {

        }

        private void userconbutton_Click(object sender, EventArgs e)
        {
            userconplat1 = new userconplat();
            userconplat1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(userconplat1);    //将窗体一加入容器panel2
        }

        private void texconbutton_Click(object sender, EventArgs e)
        {
            texplat1 = new texplat();
            texplat1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(texplat1);    //将窗体一加入容器panel2
        }
    }
}

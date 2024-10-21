using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.仓库管理.入库界面;
using WinFormsApp1.仓库管理.出库界面;
using WinFormsApp1.仓库管理.初始查询界面;
using WinFormsApp1.仓库管理.库存盘点界面;
using WinFormsApp1.系统管理工作界面;

namespace WinFormsApp1
{
    public partial class warehouse_usercontrol : UserControl
    {
        public Panel panel = Form2.form.panel2;
        public Os os1;
        public Is Is1;
        public warehouse_initial warehouse_Initial1;
        public count_push count_Push1;

        public warehouse_usercontrol()
        {
            InitializeComponent();
            this.warehouse_in.Click += new EventHandler(this.showTip);
        }

        //2.Button的Click点击事件（手动添加）
        public void showTip(Object sender, EventArgs e)
        {
            MessageBox.Show("手动添加!");
        }



        private void warehouse_usercontrol_Load(object sender, EventArgs e)
        {

        }

        private void warehouse_inquiry_Click(object sender, EventArgs e)
        {
            warehouse_Initial1 = new warehouse_initial();
            warehouse_Initial1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(warehouse_Initial1);    //将窗体一加入容器panel2
        }

        private void warehouse_edit_Click(object sender, EventArgs e)
        {
            count_Push1 = new count_push();
            count_Push1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(count_Push1);    //将窗体一加入容器panel2
        }

        private void warehouse_in_Click(object sender, EventArgs e)
        {
            Is1 = new Is();
            Is1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(Is1);    //将窗体一加入容器panel2
        }

        private void warehouse_out_Click(object sender, EventArgs e)
        {
            os1 = new Os();
            os1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(os1);    //将窗体一加入容器panel2
        }

        private void warehouse_move_Click(object sender, EventArgs e)
        {

        }
    }
}

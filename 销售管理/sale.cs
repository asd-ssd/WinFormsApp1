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
using WinFormsApp1.销售管理;

namespace WinFormsApp1
{
    public partial class sale : UserControl
    {
        public Panel panel = Form2.form.panel2;
        public clientform clientform1;
        public CargoForm CargoForm1;
        public Order2nd order2Nd1;
        public orderform orderform1;
        public Receipt2nd receipt2Nd1;
        public ReceiptForm ReceiptForm1;
        public StateForm StateForm1;
        public sale()
        {
            InitializeComponent();
        }

        private void xsskd_Click(object sender, EventArgs e)
        {
            ReceiptForm1 = new ReceiptForm();
            ReceiptForm1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(ReceiptForm1);    //将窗体一加入容器panel2
        }

        private void client_Click(object sender, EventArgs e)
        {
            clientform1 = new clientform();
            clientform1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(clientform1);    //将窗体一加入容器panel2
        }

        private void xsdd_Click(object sender, EventArgs e)
        {
            orderform1 = new orderform();
            orderform1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(orderform1);    //将窗体一加入容器panel2
        }

        private void sfh_Click(object sender, EventArgs e)
        {
            CargoForm1 = new CargoForm();
            CargoForm1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(CargoForm1);    //将窗体一加入容器panel2
        }

        private void bbfx_Click(object sender, EventArgs e)
        {
            StateForm1 = new StateForm();
            StateForm1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(StateForm1);    //将窗体一加入容器panel2
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.销售管理.客户管理;


using WinFormsApp1.销售管理.收发货管理.发货;

namespace WinFormsApp1.销售管理
{
    public partial class SaleForm : UserControl
    {
        public Panel panel = Form2.form.panel2;
        public clientform Clientform;
        public Delievery delievery;
        public Order2nd order2Nd1;
        public orderform orderform1;
        public Receipt2nd receipt2Nd1;
        public ReceiptForm ReceiptForm1;
        
        public ExamineForm examineForm1;
        public ReturnForm returnForm1;
        
        
        public SaleForm()
        {
            InitializeComponent();
        }

        private void saleclient_Click(object sender, EventArgs e)
        {
            Clientform = new clientform();
            Clientform.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(Clientform);    //将窗体一加入容器panel2
        }


        private void salexsdd_Click(object sender, EventArgs e)
        {
            orderform1 = new orderform();
            orderform1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(orderform1);    //将窗体一加入容器panel2
        }

        private void salexsskd_Click_1(object sender, EventArgs e)
        {
            ReceiptForm1 = new ReceiptForm();
            ReceiptForm1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(ReceiptForm1);    //将窗体一加入容器panel2
        }

        

        private void saleddsp_Click(object sender, EventArgs e)
        {
            examineForm1 = new ExamineForm();
            examineForm1.Show();   //将窗体一进行显示
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(examineForm1);    //将窗体一加入容器panel2
        }

        private void saletuihuo_Click(object sender, EventArgs e)
        {
            returnForm1 = new ReturnForm();
            returnForm1.Show();
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(returnForm1);    //将窗体一加入容器panel2
        }

        private void salefh_Click(object sender, EventArgs e)
        {
            delievery = new Delievery ();
            delievery.Show();
            panel.Controls.Clear();    //清空原容器上的控件
            panel.Controls.Add(delievery);    //将窗体一加入容器panel2
        }

        

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Second;
using WinFormsApp1.二级菜单;
using WinFormsApp1.工作界面;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public static Form2 form;
        //工作平台

        public workplat1 plat1;
        //二级菜单
        public workplatform work1;
        public basecon basecon1;
        public systemcon systemcon1;
        public Plan Plan1;
        public caigou2 caigou21;
        public sale sale1;
        public warehouse_usercontrol warehouse_Usercontrol1;
        public Form2()
        {
            InitializeComponent();
            form = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            work1 = new workplatform();    //实例化work1
            plat1 = new workplat1();
            work1.Show();   //将窗体一进行显示
            panel1.Controls.Clear();    //清空原容器上的控件
            panel1.Controls.Add(work1);    //将窗体一加入容器panel1
            plat1.Show();   //将窗体一进行显示
            panel2.Controls.Clear();    //清空原容器上的控件
            panel2.Controls.Add(plat1);    //将窗体一加入容器panel2
                                           //修改其显示为当前时间
            this.toolStripStatusLabel3.Text = "系统当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            //对timer1进行相关设置
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            work1.Show();   //将窗体一进行显示
            panel1.Controls.Clear();    //清空原容器上的控件
            panel1.Controls.Add(work1);    //将窗体一加入容器panel1
            plat1.Show();   //将窗体一进行显示
            panel2.Controls.Clear();    //清空原容器上的控件
            panel2.Controls.Add(plat1);    //将窗体一加入容器panel2
        }
        private void button3_Click(object sender, EventArgs e)
        {
            basecon1 = new basecon();
            basecon1.Show();
            panel1.Controls.Clear();    //清空原容器上的控件
            panel1.Controls.Add(basecon1);    //将窗体一加入容器panel1
            panel2.Controls.Clear();    //清空原容器上的控件
        }
        private void 主菜单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = "系统当前时间：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Plan1 = new Plan();
            basecon1.Show();
            panel1.Controls.Clear();    //清空原容器上的控件
            panel1.Controls.Add(Plan1);    //将窗体一加入容器panel1
            panel2.Controls.Clear();    //清空原容器上的控件
        }

        private void button5_Click(object sender, EventArgs e)
        {
            caigou21 = new caigou2();
            basecon1.Show();
            panel1.Controls.Clear();    //清空原容器上的控件
            panel1.Controls.Add(caigou21);    //将窗体一加入容器panel1
            panel2.Controls.Clear();    //清空原容器上的控件
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sale1 = new sale();
            basecon1.Show();
            panel1.Controls.Clear();    //清空原容器上的控件
            panel1.Controls.Add(sale1);    //将窗体一加入容器panel1
            panel2.Controls.Clear();    //清空原容器上的控件
        }

        private void button7_Click(object sender, EventArgs e)
        {
            warehouse_Usercontrol1 = new warehouse_usercontrol();
            basecon1.Show();
            panel1.Controls.Clear();    //清空原容器上的控件
            panel1.Controls.Add(warehouse_Usercontrol1);    //将窗体一加入容器panel1
            panel2.Controls.Clear();    //清空原容器上的控件
        }

        private void button8_Click(object sender, EventArgs e)
        {
            systemcon1 = new systemcon();
            basecon1.Show();
            panel1.Controls.Clear();    //清空原容器上的控件
            panel1.Controls.Add(systemcon1);    //将窗体一加入容器panel1
            panel2.Controls.Clear();    //清空原容器上的控件
        }
    }
}

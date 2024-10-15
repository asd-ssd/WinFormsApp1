using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class warehouse_usercontrol : UserControl
    {
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
    }
}

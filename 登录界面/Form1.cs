using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public login login1;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            login1 = new login();
            login1.Show();
            panel1.Controls.Clear();    //���ԭ�����ϵĿؼ�
            panel1.Controls.Add(login1);    //������һ��������panel1
        }
    }
}

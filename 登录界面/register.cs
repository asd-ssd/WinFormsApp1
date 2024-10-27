using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace WinFormsApp1
{
    public partial class register : Form
    {
        public TextBox textBox = login.login1.username_text;
        public TextBox passtextBox = login.login1.password_text;
        public register()
        {
            InitializeComponent();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void AddUser()
        {
            SqlConnection conn = connection();
            conn.Open();
            string savedSalt = GenerateSalt();
            string hashedInputPassword = HashPassword(textBox3.Text.Trim(), savedSalt);
            string creattime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            // 使用参数化查询来避免SQL注入问题
            string strda = "INSERT INTO 用户信息表 (用户名, 密码, 密码盐, 员工编号,创建时间) VALUES (@username, @password, @salt, @employeeID, @createtime)";
            SqlCommand comm = new SqlCommand(strda, conn);

            // 添加参数
            comm.Parameters.AddWithValue("@username", textBox1.Text.Trim());
            comm.Parameters.AddWithValue("@password", hashedInputPassword);
            comm.Parameters.AddWithValue("@salt", savedSalt);
            comm.Parameters.AddWithValue("@employeeID", textBox2.Text.Trim());
            comm.Parameters.AddWithValue("@createtime", creattime);
            comm.ExecuteNonQuery();


            // 为用户添加默认角色 0 到 UserRole 表
            string userName = textBox1.Text.Trim();
            int defaultRoleId = 0; // 默认角色编号为 0

            string roleInsertQuery = "INSERT INTO UserRole (用户编号, 角色编号) VALUES (@username, @roleID)";
            SqlCommand roleInsertCommand = new SqlCommand(roleInsertQuery, conn);

            // 添加参数
            roleInsertCommand.Parameters.AddWithValue("@username", userName);
            roleInsertCommand.Parameters.AddWithValue("@roleID", defaultRoleId);

            // 执行插入角色关联的命令
            roleInsertCommand.ExecuteNonQuery();
            conn.Close();
        }
        public static string GenerateSalt()
        {
            // 生成一个128位的盐（16字节）
            byte[] saltBytes = new byte[16];

            // 使用 RandomNumberGenerator 生成随机盐
            RandomNumberGenerator.Fill(saltBytes);

            return Convert.ToBase64String(saltBytes); // 将盐转换为Base64字符串
        }
        public static string HashPassword(string password, string salt)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // 将密码和盐连接在一起进行哈希
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password + salt));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // 将字节转换为十六进制字符串
                }

                return builder.ToString(); // 返回哈希后的字符串
            }
        }
        public bool Is_duplicate()
        {
            string strda = "select 用户名 from 用户信息表";
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strda, conn);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (textBox1.Text.Trim() == dt.Rows[i]["用户名"].ToString())
                {

                    return true;
                }
            }
            return false;
        }
        public bool  Is_emp()
        {
            string strda = "select 员工编号 from 员工信息表";
            SqlConnection conn = connection();
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strda, conn);
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (textBox2.Text.Trim() == dt.Rows[i]["员工编号"].ToString())
                {

                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() != textBox4.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Is_duplicate())
            {
                MessageBox.Show("用户名已存在，请修改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Is_emp())
            {
                MessageBox.Show("员工编号不存在，请修改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                AddUser();
                textBox.Text = textBox1.Text;
                passtextBox.Clear();
                MessageBox.Show("注册成功！");
                this.Close();
            }
        }

        private void register_Load(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*'; // 隐藏密码
            textBox4.PasswordChar = '*'; // 隐藏密码
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

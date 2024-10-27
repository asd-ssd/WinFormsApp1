using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;
using WinFormsApp1.登录界面;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class Editpassword : Form
    {
        private const int CodeLength = 4; // 验证码的长度
        private string V = "";
        private string verificationCode = ""; // 当前验证码
        public string username = ConfigurationManager.AppSettings["用户名"].ToString();
        public Editpassword()
        {
            InitializeComponent();
            UpdateVerificationCode();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateVerificationCode();
        }
        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Persist Security Info=True;User ID=hhr;Password=aa1628381531";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        private void Editpass()
        {
            if (textBox3.Text.Trim() != textBox4.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = connection();
                conn.Open();
                string savedSalt = GenerateSalt();
                string hashedInputPassword = HashPassword(textBox3.Text.Trim(), savedSalt);
                // 使用参数化查询来避免SQL注入问题
                string strda = $"UPDATE 用户信息表 SET 密码 = @password, 密码盐 = @salt WHERE 用户名 = @username";
                SqlCommand comm = new SqlCommand(strda, conn);
                // 添加参数
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@password", hashedInputPassword);
                comm.Parameters.AddWithValue("@salt", savedSalt);
                comm.ExecuteNonQuery();
                conn.Close();
            }

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
        private void UpdateVerificationCode() // 创建或更新验证码
        {
            verificationCode = VerificationCode.CreateRandomCode(CodeLength); // 随机生成验证码
            if (verificationCode == V) return; // 如果验证码为空，不处理
            VerificationCode.CreateImage(verificationCode, pictureBox1); // 在图片上显示验证码
        }

        private bool CaptchaVerification() // 验证码校验
        {
            if (!string.IsNullOrEmpty(textBox2.Text.Trim())) // 检查输入的验证码是否为空
            {
                if (textBox2.Text.Trim().ToLower() == verificationCode.ToLower()) // 忽略大小写进行验证码验证
                {
                    return true; // 验证通过
                }
                else
                {
                    MessageBox.Show("验证码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UpdateVerificationCode(); // 验证码错误后重新生成新的验证码
                    textBox2.Text = V; // 清空输入框
                    textBox2.Focus(); // 聚焦输入框
                    return false;
                }
            }
            else
            {
                MessageBox.Show("请输入验证码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateVerificationCode(); // 验证码为空时重新生成验证码
                textBox2.Text = V; // 清空输入框
                textBox2.Focus(); // 聚焦输入框
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CaptchaVerification() && EditFlag())
            {
                Editpass();
                SysLogService.AddSysLog(new SysLog("修改账户密码", "触发", LogTye.操作记录, login.login1.userid));
                MessageBox.Show("修改密码成功！");
                this.Close();
            };
        }

        private bool EditFlag()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                // 使用参数化查询，防止SQL注入
                string sql = "SELECT * FROM 用户信息表 WHERE 用户名 = @LoginID";
                SqlParameter[] parameters = {
                    new SqlParameter("@LoginID", username)
                };
                SqlConnection con = connection();
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                con.Close();
                DataRow dataRow = dataTable.Rows[0];
                string savedHashedPassword = dataRow["密码"].ToString();
                string savedSalt = dataRow["密码盐"].ToString();
                string hashedInputPassword = HashPassword(textBox1.Text.Trim(), savedSalt);
                if (hashedInputPassword == savedHashedPassword)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("旧密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // 密码错误
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editpassword_Load(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*'; // 隐藏密码
            textBox4.PasswordChar = '*'; // 隐藏密码
        }
    }
}

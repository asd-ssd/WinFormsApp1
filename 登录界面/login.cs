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
using WinFormsApp1.工作界面;
using WinFormsApp1.登录界面;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class login : UserControl
    {
        public static login login1;
        public Panel panel1 = Form1.form1.panel1;
        public register register1;
        int roleID = 0; // 用于存储用户角色ID
        int logonCount = 0; // 登录失败次数计数器
        private const int CodeLength = 4; // 验证码的长度
        private  string V = "";
        private string verificationCode = ""; // 当前验证码
        private int flag = 0;
        public  string userid;
        public login()
        {
            InitializeComponent();
            login1 = this;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            logonCount += 1; // 每点击一次，登录计数器+1
            if (logonCount <= 3)
            {
                // 3次以内直接验证用户名和密码
                if (loginFlag()) EnterSystem();
                else if (logonCount == 3)
                {
                    label1.Visible = true;
                    pictureBox1.Visible = true;
                    textBox1.Visible = true;
                    UpdateVerificationCode(); // 登录3次失败后更新验证码
                }
            }
            else if (CaptchaVerification() && loginFlag()) EnterSystem(); // 超过3次，需要验证码验证通过后再验证用户名和密码
        }



        private void EnterSystem() // 登录成功，进入系统
        {
            RememberMe(); // 如果选择记住密码，则保存用户信息
            userid = username_text.Text.Trim();
            SysLogService.AddSysLog(new SysLog("登录成功", "触发", LogTye.日志信息, userid));
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f1.Hide();
            f2.ShowDialog();
            f1.Dispose();

        }
        private void login_Load_1(object sender, EventArgs e) // 加载时读取用户信息（如果选择了记住密码）
        {

            if (ConfigurationManager.AppSettings["rememberme"] != null && ConfigurationManager.AppSettings["rememberme"].Equals("true"))
            {
                username_text.Text = ConfigurationManager.AppSettings["loginID"]; // 读取保存的用户名
                password_text.Text = ConfigurationManager.AppSettings["passwd"]; // 读取保存的密码
                checkBox1.Checked = true; // 复选框设置为选中
                checkBox2.Checked = false;
                flag = 1;
            }
            password_text.PasswordChar = '*'; // 隐藏密码
        }

        private void UpdateVerificationCode() // 创建或更新验证码
        {
            verificationCode = VerificationCode.CreateRandomCode(CodeLength); // 随机生成验证码
            if (verificationCode == V) return; // 如果验证码为空，不处理
            VerificationCode.CreateImage(verificationCode, pictureBox1); // 在图片上显示验证码
        }

        private bool CaptchaVerification() // 验证码校验
        {
            if (!string.IsNullOrEmpty(textBox1.Text.Trim())) // 检查输入的验证码是否为空
            {
                if (textBox1.Text.Trim().ToLower() == verificationCode.ToLower()) // 忽略大小写进行验证码验证
                {
                    return true; // 验证通过
                }
                else
                {
                    MessageBox.Show("验证码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UpdateVerificationCode(); // 验证码错误后重新生成新的验证码
                    textBox1.Text = V; // 清空输入框
                    textBox1.Focus(); // 聚焦输入框
                    return false;
                }
            }
            else
            {
                MessageBox.Show("请输入验证码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateVerificationCode(); // 验证码为空时重新生成验证码
                textBox1.Text = V; // 清空输入框
                textBox1.Focus(); // 聚焦输入框
                return false;
            }
        }
        
        private void RememberMe() // 保存用户信息
        {
            string loginID = username_text.Text.Trim(); // 获取用户名
            string passwd = password_text.Text.Trim();// 获取密码

            Configuration cf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (checkBox1.Checked) // 如果勾选了“记住我”选项
            {
                cf.AppSettings.Settings["loginID"].Value = loginID; // 保存用户名
                cf.AppSettings.Settings["passwd"].Value = passwd; // 保存加密后的密码
                cf.AppSettings.Settings["rememberme"].Value = "true";
            }
            else // 如果没有勾选
            {
                cf.AppSettings.Settings["loginID"].Value = V; // 清空用户名
                cf.AppSettings.Settings["passwd"].Value = V; // 清空密码
                cf.AppSettings.Settings["rememberme"].Value = "false";
            }
            cf.Save(); // 保存配置文件
        }

        private bool loginFlag() // 验证用户信息，记录roleID并返回true或false
        {
            if (string.IsNullOrEmpty(username_text.Text) || string.IsNullOrEmpty(password_text.Text))
            {
                MessageBox.Show("用户名和密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                // 使用参数化查询，防止SQL注入
                string sql = "SELECT * FROM 用户信息表 WHERE 用户名 = @LoginID";
                SqlParameter[] parameters = {
                    new SqlParameter("@LoginID", username_text.Text.Trim())
                };
                SqlConnection con = connection();
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                con.Close();
                if (dataTable.Rows.Count > 0) // 如果查询结果不为空
                {
                    DataRow dataRow = dataTable.Rows[0];
                    string savedHashedPassword = dataRow["密码"].ToString();
                    string savedSalt = dataRow["密码盐"].ToString();
                    string hashedInputPassword = HashPassword(password_text.Text.Trim(), savedSalt);
                    //string hashedInputPassword = password_text.Text.Trim();
                    if (hashedInputPassword == savedHashedPassword)
                    {
                        // 从 UserRole 表中获取用户名对应的角色编号
                        var userRole = SqlSugarHelper.SqlSugarClient.Queryable<UserRole>()
                            .Where(ur => ur.UserName == username_text.Text.Trim())
                            .First();

                        if (userRole != null)
                        {
                            // 如果找到了对应的角色编号，保存到配置文件
                            int roleId = userRole.RoleId;
                            Configuration cf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                            cf.AppSettings.Settings["角色编号"].Value = roleId.ToString(); // 保存 roleId 到配置文件
                            cf.Save();
                        }
                        return true; // 登录验证通过
                    }
                    else
                    {
                        MessageBox.Show("密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // 密码错误
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // 登录验证失败
                }
            }
        }

        private SqlConnection connection()
        {
            string strconn = "Data Source=DESKTOP-DC8DD5P;Initial Catalog=sss;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        // 密码加密方法，使用SHA256哈希算法
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (logonCount >= 3) UpdateVerificationCode(); // 只有登录失败三次后才显示验证码
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // 切换显示或隐藏密码
            if (checkBox2.Checked)
            {
                password_text.PasswordChar = '\0'; // 显示密码
            }
            else
            {
                password_text.PasswordChar = '*'; // 隐藏密码
            }
            if(flag==1)
            {
                 password_text.Text = V; // 删除密码
            }
            flag = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register1 = new register();
            register1.ShowDialog();
        }
    }
}

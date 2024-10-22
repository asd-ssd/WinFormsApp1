namespace WinFormsApp1
{
    partial class login
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            password_text = new TextBox();
            username_text = new TextBox();
            password = new Label();
            user_name = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(42, 238);
            button1.Name = "button1";
            button1.Size = new Size(381, 52);
            button1.TabIndex = 13;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // password_text
            // 
            password_text.Anchor = AnchorStyles.None;
            password_text.BackColor = Color.Snow;
            password_text.ForeColor = SystemColors.InfoText;
            password_text.Location = new Point(209, 172);
            password_text.Name = "password_text";
            password_text.Size = new Size(183, 30);
            password_text.TabIndex = 11;
            // 
            // username_text
            // 
            username_text.Anchor = AnchorStyles.None;
            username_text.BackColor = Color.Snow;
            username_text.ForeColor = SystemColors.InfoText;
            username_text.Location = new Point(209, 100);
            username_text.Name = "username_text";
            username_text.Size = new Size(183, 30);
            username_text.TabIndex = 10;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.BackColor = Color.Snow;
            password.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            password.ForeColor = SystemColors.InfoText;
            password.Location = new Point(71, 165);
            password.Name = "password";
            password.Size = new Size(85, 44);
            password.TabIndex = 9;
            password.Text = "密码";
            password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // user_name
            // 
            user_name.Anchor = AnchorStyles.None;
            user_name.BackColor = Color.Snow;
            user_name.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            user_name.ForeColor = SystemColors.InfoText;
            user_name.Location = new Point(71, 93);
            user_name.Name = "user_name";
            user_name.Size = new Size(85, 44);
            user_name.TabIndex = 8;
            user_name.Text = "用户名";
            user_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            radioButton1.BackColor = Color.Snow;
            radioButton1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            radioButton1.ForeColor = SystemColors.InfoText;
            radioButton1.Location = new Point(71, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(190, 42);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "管理员";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = Color.Snow;
            radioButton2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            radioButton2.ForeColor = SystemColors.InfoText;
            radioButton2.Location = new Point(184, 39);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(120, 42);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "普通用户";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor =Color.FromArgb(70, 103, 216, 250);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(password_text);
            Controls.Add(username_text);
            Controls.Add(password);
            Controls.Add(user_name);
            Name = "login";
            Size = new Size(469, 314);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox password_text;
        private TextBox username_text;
        private Label password;
        private Label user_name;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}

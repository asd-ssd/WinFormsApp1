namespace WinFormsApp1
{
    partial class adminlogin
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
            admin_mode = new Button();
            password_text = new TextBox();
            username_text = new TextBox();
            password = new Label();
            user_name = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.LightGray;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(152, 319);
            button1.Name = "button1";
            button1.Size = new Size(381, 52);
            button1.TabIndex = 19;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = false;
            // 
            // admin_mode
            // 
            admin_mode.Anchor = AnchorStyles.None;
            admin_mode.BackColor = Color.Aquamarine;
            admin_mode.Location = new Point(495, 170);
            admin_mode.Name = "admin_mode";
            admin_mode.Size = new Size(162, 46);
            admin_mode.TabIndex = 18;
            admin_mode.Text = "普通用户模式";
            admin_mode.UseVisualStyleBackColor = false;
            admin_mode.Click += this.admin_mode_Click;
            // 
            // password_text
            // 
            password_text.Anchor = AnchorStyles.None;
            password_text.BackColor = SystemColors.Info;
            password_text.Location = new Point(252, 207);
            password_text.Name = "password_text";
            password_text.Size = new Size(183, 30);
            password_text.TabIndex = 17;
            // 
            // username_text
            // 
            username_text.Anchor = AnchorStyles.None;
            username_text.BackColor = SystemColors.Info;
            username_text.Location = new Point(252, 134);
            username_text.Name = "username_text";
            username_text.Size = new Size(183, 30);
            username_text.TabIndex = 16;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.BackColor = SystemColors.MenuHighlight;
            password.ForeColor = Color.FromArgb(64, 0, 0);
            password.Location = new Point(142, 200);
            password.Name = "password";
            password.Size = new Size(85, 44);
            password.TabIndex = 15;
            password.Text = "密码";
            password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // user_name
            // 
            user_name.Anchor = AnchorStyles.None;
            user_name.BackColor = SystemColors.MenuHighlight;
            user_name.ForeColor = Color.FromArgb(64, 0, 0);
            user_name.Location = new Point(142, 127);
            user_name.Name = "user_name";
            user_name.Size = new Size(85, 44);
            user_name.TabIndex = 14;
            user_name.Text = "管理员";
            user_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // adminlogin
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(admin_mode);
            Controls.Add(password_text);
            Controls.Add(username_text);
            Controls.Add(password);
            Controls.Add(user_name);
            Name = "adminlogin";
            Size = new Size(799, 512);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button admin_mode;
        private TextBox password_text;
        private TextBox username_text;
        private Label password;
        private Label user_name;
    }
}

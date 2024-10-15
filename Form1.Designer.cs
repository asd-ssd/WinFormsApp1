namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            user_name = new Label();
            password = new Label();
            username_text = new TextBox();
            password_text = new TextBox();
            admin_mode = new Button();
            login = new Button();
            pictureBox1 = new PictureBox();
            find_pass = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // user_name
            // 
            user_name.Anchor = AnchorStyles.None;
            user_name.BackColor = Color.Aquamarine;
            user_name.ForeColor = Color.FromArgb(64, 0, 0);
            user_name.Location = new Point(519, 326);
            user_name.Name = "user_name";
            user_name.Size = new Size(70, 24);
            user_name.TabIndex = 0;
            user_name.Text = "用户名";
            user_name.TextAlign = ContentAlignment.MiddleCenter;
            user_name.Click += label1_Click;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.BackColor = Color.Aquamarine;
            password.ForeColor = Color.FromArgb(64, 0, 0);
            password.Location = new Point(519, 393);
            password.Name = "password";
            password.Size = new Size(70, 24);
            password.TabIndex = 1;
            password.Text = "密码";
            password.TextAlign = ContentAlignment.MiddleCenter;
            password.Click += label2_Click;
            // 
            // username_text
            // 
            username_text.Anchor = AnchorStyles.None;
            username_text.BackColor = SystemColors.Info;
            username_text.Location = new Point(629, 320);
            username_text.Name = "username_text";
            username_text.Size = new Size(183, 30);
            username_text.TabIndex = 2;
            // 
            // password_text
            // 
            password_text.Anchor = AnchorStyles.None;
            password_text.BackColor = SystemColors.Info;
            password_text.Location = new Point(629, 393);
            password_text.Name = "password_text";
            password_text.Size = new Size(183, 30);
            password_text.TabIndex = 3;
            // 
            // admin_mode
            // 
            admin_mode.Anchor = AnchorStyles.None;
            admin_mode.BackColor = SystemColors.MenuHighlight;
            admin_mode.Location = new Point(629, 562);
            admin_mode.Name = "admin_mode";
            admin_mode.Size = new Size(162, 46);
            admin_mode.TabIndex = 4;
            admin_mode.Text = "管理员模式";
            admin_mode.UseVisualStyleBackColor = false;
            admin_mode.Click += button1_Click;
            // 
            // login
            // 
            login.Anchor = AnchorStyles.None;
            login.BackColor = Color.Transparent;
            login.ForeColor = Color.Black;
            login.Location = new Point(519, 476);
            login.Name = "login";
            login.Size = new Size(381, 52);
            login.TabIndex = 5;
            login.Text = "登录";
            login.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(277, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(910, 503);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // find_pass
            // 
            find_pass.Anchor = AnchorStyles.None;
            find_pass.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            find_pass.BackColor = SystemColors.ButtonHighlight;
            find_pass.ForeColor = Color.OrangeRed;
            find_pass.Location = new Point(865, 393);
            find_pass.Name = "find_pass";
            find_pass.Size = new Size(121, 31);
            find_pass.TabIndex = 7;
            find_pass.Text = "找回密码";
            find_pass.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("华文隶书", 41.9999962F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(472, 160);
            label3.Name = "label3";
            label3.Size = new Size(491, 124);
            label3.TabIndex = 9;
            label3.Text = "橘猫管家";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Highlight;
            BackgroundImage = Properties.Resources.ERP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1503, 806);
            Controls.Add(label3);
            Controls.Add(find_pass);
            Controls.Add(login);
            Controls.Add(admin_mode);
            Controls.Add(password_text);
            Controls.Add(username_text);
            Controls.Add(password);
            Controls.Add(user_name);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label user_name;
        private Label password;
        private TextBox username_text;
        private TextBox password_text;
        private Button admin_mode;
        private Button login;
        private PictureBox pictureBox1;
        private Button find_pass;
        private Label label3;
    }
}

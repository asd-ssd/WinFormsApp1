namespace WinFormsApp1
{
    partial class register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label16 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(91, 136);
            label16.Name = "label16";
            label16.Size = new Size(82, 24);
            label16.TabIndex = 150;
            label16.Text = "员工编号";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(207, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 149;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 147;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 146;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 208);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 144;
            label2.Text = "密码";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 67);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 143;
            label1.Text = "用户名";
            // 
            // button2
            // 
            button2.Location = new Point(276, 347);
            button2.Name = "button2";
            button2.Size = new Size(133, 46);
            button2.TabIndex = 156;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(84, 347);
            button1.Name = "button1";
            button1.Size = new Size(133, 46);
            button1.TabIndex = 155;
            button1.Text = "注册";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(207, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 158;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 271);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 157;
            label3.Text = "确认密码";
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 476);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label16);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register";
            Text = "注册";
            Load += register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label16;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
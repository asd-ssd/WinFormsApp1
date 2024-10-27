namespace WinFormsApp1
{
    partial class Editpassword
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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 160;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 159;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 162;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 197);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 164;
            label3.Text = "确认密码";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 134);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 163;
            label2.Text = "新密码";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 79);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 166;
            label1.Text = "旧密码";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 258);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 168;
            label4.Text = "验证码";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 167;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(392, 248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 40);
            pictureBox1.TabIndex = 169;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(97, 353);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 170;
            button1.Text = "确认修改";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(297, 353);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 171;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Editpassword
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 511);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Name = "Editpassword";
            Text = "Editpassword";
            Load += Editpassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}
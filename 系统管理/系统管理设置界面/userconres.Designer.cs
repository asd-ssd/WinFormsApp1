namespace WinFormsApp1
{
    partial class userconres
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
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox12 = new TextBox();
            textBox16 = new TextBox();
            label10 = new Label();
            textBox8 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            label21 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(262, 293);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 30);
            dateTimePicker1.TabIndex = 124;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 295);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 123;
            label5.Text = "创建时间";
            // 
            // button2
            // 
            button2.Location = new Point(428, 526);
            button2.Name = "button2";
            button2.Size = new Size(133, 46);
            button2.TabIndex = 120;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(205, 526);
            button1.Name = "button1";
            button1.Size = new Size(133, 46);
            button1.TabIndex = 119;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(497, 208);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(150, 30);
            textBox12.TabIndex = 118;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(497, 116);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(150, 30);
            textBox16.TabIndex = 117;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(386, 214);
            label10.Name = "label10";
            label10.Size = new Size(82, 24);
            label10.TabIndex = 116;
            label10.Text = "权限类型";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(209, 208);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 30);
            textBox8.TabIndex = 115;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 114;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 211);
            label7.Name = "label7";
            label7.Size = new Size(99, 24);
            label7.TabIndex = 113;
            label7.Text = "关联员工id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 116);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 112;
            label2.Text = "用户名";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 116);
            label1.Name = "label1";
            label1.Size = new Size(65, 24);
            label1.TabIndex = 111;
            label1.Text = "用户ID";
            // 
            // label21
            // 
            label21.BackColor = SystemColors.ActiveBorder;
            label21.ForeColor = SystemColors.ActiveCaptionText;
            label21.Location = new Point(262, 33);
            label21.Name = "label21";
            label21.Size = new Size(217, 39);
            label21.TabIndex = 127;
            label21.Text = "请输入查询条件";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(262, 364);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(201, 30);
            dateTimePicker2.TabIndex = 128;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(214, 289);
            label3.Name = "label3";
            label3.Size = new Size(42, 36);
            label3.TabIndex = 129;
            label3.Text = "从";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(214, 363);
            label4.Name = "label4";
            label4.Size = new Size(42, 36);
            label4.TabIndex = 130;
            label4.Text = "到";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userconres
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 638);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label21);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox12);
            Controls.Add(textBox16);
            Controls.Add(label10);
            Controls.Add(textBox8);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "userconres";
            Text = "userconres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button button2;
        private Button button1;
        private TextBox textBox12;
        private TextBox textBox16;
        private Label label10;
        private TextBox textBox8;
        private TextBox textBox1;
        private Label label7;
        private Label label2;
        private Label label1;
        private Label label21;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
    }
}
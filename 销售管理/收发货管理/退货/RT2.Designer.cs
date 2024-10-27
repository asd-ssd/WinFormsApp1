namespace WinFormsApp1.销售管理.收发货管理.退货
{
    partial class RT2
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
            textBox2 = new DateTimePicker();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            sr11label6 = new Label();
            sr11label5 = new Label();
            sr11label4 = new Label();
            sr11label2 = new Label();
            sr11label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(550, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 30);
            textBox2.TabIndex = 111;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(546, 159);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 30);
            textBox6.TabIndex = 110;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(177, 156);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 30);
            textBox5.TabIndex = 109;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(177, 227);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 108;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 106;
            // 
            // sr11label6
            // 
            sr11label6.AutoSize = true;
            sr11label6.Location = new Point(416, 162);
            sr11label6.Name = "sr11label6";
            sr11label6.Size = new Size(82, 24);
            sr11label6.TabIndex = 105;
            sr11label6.Text = "物料名称";
            // 
            // sr11label5
            // 
            sr11label5.AutoSize = true;
            sr11label5.Location = new Point(58, 159);
            sr11label5.Name = "sr11label5";
            sr11label5.Size = new Size(82, 24);
            sr11label5.TabIndex = 104;
            sr11label5.Text = "订单编号";
            // 
            // sr11label4
            // 
            sr11label4.AutoSize = true;
            sr11label4.Location = new Point(58, 230);
            sr11label4.Name = "sr11label4";
            sr11label4.Size = new Size(64, 24);
            sr11label4.TabIndex = 103;
            sr11label4.Text = "收货人";
            // 
            // sr11label2
            // 
            sr11label2.AutoSize = true;
            sr11label2.Location = new Point(416, 96);
            sr11label2.Name = "sr11label2";
            sr11label2.Size = new Size(82, 24);
            sr11label2.TabIndex = 101;
            sr11label2.Text = "退回日期";
            // 
            // sr11label1
            // 
            sr11label1.AutoSize = true;
            sr11label1.Location = new Point(58, 96);
            sr11label1.Name = "sr11label1";
            sr11label1.Size = new Size(82, 24);
            sr11label1.TabIndex = 100;
            sr11label1.Text = "退回编号";
            // 
            // button1
            // 
            button1.Location = new Point(622, 339);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 112;
            button1.Text = "保存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(333, 156);
            button2.Name = "button2";
            button2.Size = new Size(33, 30);
            button2.TabIndex = 113;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(332, 227);
            button3.Name = "button3";
            button3.Size = new Size(33, 30);
            button3.TabIndex = 114;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // RT2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(sr11label6);
            Controls.Add(sr11label5);
            Controls.Add(sr11label4);
            Controls.Add(sr11label2);
            Controls.Add(sr11label1);
            Name = "RT2";
            Text = "新建";
            Load += RT2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker textBox2;
        private TextBox textBox1;
        private Label sr11label6;
        private Label sr11label5;
        private Label sr11label4;
        private Label sr11label2;
        private Label sr11label1;
        private Button button1;
        private Button button2;
        private Button button3;
        public TextBox textBox6;
        public TextBox textBox5;
        public TextBox textBox4;
    }
}
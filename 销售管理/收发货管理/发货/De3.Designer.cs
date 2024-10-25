namespace WinFormsApp1.销售管理.收发货管理.发货
{
    partial class De3
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
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(267, 322);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 21;
            button1.Text = "确认";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(191, 213);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 30);
            textBox5.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(551, 137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(191, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(551, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 216);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 15;
            label5.Text = "客户编号";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 143);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 14;
            label4.Text = "订单编号";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 143);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 13;
            label3.Text = "发货人";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 76);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 12;
            label2.Text = "仓库编号";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 76);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 11;
            label1.Text = "出库单编号";
            // 
            // button2
            // 
            button2.Location = new Point(471, 322);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 22;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // De3
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "De3";
            Text = "查询";
            Load += De3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
    }
}
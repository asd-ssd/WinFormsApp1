namespace WinFormsApp1
{
    partial class cgsq
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
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Microsoft YaHei UI Light", 14F);
            label7.Location = new Point(44, 261);
            label7.Name = "label7";
            label7.Size = new Size(129, 38);
            label7.TabIndex = 21;
            label7.Text = "商品单价";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Microsoft YaHei UI Light", 14F);
            label6.Location = new Point(44, 356);
            label6.Name = "label6";
            label6.Size = new Size(129, 38);
            label6.TabIndex = 20;
            label6.Text = "采购总价";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 269);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 221);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Microsoft YaHei UI Light", 14F);
            label5.Location = new Point(44, 213);
            label5.Name = "label5";
            label5.Size = new Size(129, 38);
            label5.TabIndex = 15;
            label5.Text = "采购商品";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Microsoft YaHei UI Light", 14F);
            label4.Location = new Point(44, 308);
            label4.Name = "label4";
            label4.Size = new Size(129, 38);
            label4.TabIndex = 14;
            label4.Text = "采购总量";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Microsoft YaHei UI Light", 14F);
            label3.Location = new Point(44, 403);
            label3.Name = "label3";
            label3.Size = new Size(101, 38);
            label3.TabIndex = 13;
            label3.Text = "供货商";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft YaHei UI Light", 14F);
            label2.Location = new Point(44, 164);
            label2.Name = "label2";
            label2.Size = new Size(129, 38);
            label2.TabIndex = 12;
            label2.Text = "申请日期";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft YaHei UI Light", 14F);
            label1.Location = new Point(44, 113);
            label1.Name = "label1";
            label1.Size = new Size(129, 38);
            label1.TabIndex = 11;
            label1.Text = "申请人员";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(224, 316);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 30);
            textBox5.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(3, 14);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 23;
            button1.Text = "保存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(243, 14);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 24;
            button2.Text = "删除";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(125, 14);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 25;
            button3.Text = "修改";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(361, 14);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 26;
            button4.Text = "提交";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(224, 364);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 30);
            textBox6.TabIndex = 27;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(224, 411);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 30);
            textBox7.TabIndex = 28;
            // 
            // cgsq
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "cgsq";
            Size = new Size(490, 489);
            Load += cgsq_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}

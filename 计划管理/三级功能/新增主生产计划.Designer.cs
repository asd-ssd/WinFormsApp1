namespace WinFormsApp1.Forth
{
    partial class 新增主生产计划
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
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            textBox5 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 120);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "物料编号：";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 178);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 3;
            label3.Text = "计划数量：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 236);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 5;
            label5.Text = "计划开始日期：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 236);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 6;
            label6.Text = "计划完成日期：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 294);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 7;
            label7.Text = "备注：";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(382, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(85, 300);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ScrollBars = ScrollBars.Vertical;
            textBox7.Size = new Size(430, 82);
            textBox7.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(171, 413);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(317, 413);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(154, 233);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(393, 233);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(125, 27);
            dateTimePicker2.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 62);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 18;
            label8.Text = "主生产计划编号：";
            label8.Click += label8_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(175, 59);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 27);
            textBox5.TabIndex = 19;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(252, 116);
            button3.Name = "button3";
            button3.Size = new Size(29, 29);
            button3.TabIndex = 20;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 120);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 21;
            label2.Text = "物料来源：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(382, 117);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 178);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 23;
            label4.Text = "物料名称：";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 175);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 24;
            // 
            // 新增主生产计划
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(611, 458);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "新增主生产计划";
            Text = "新增生产计划";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private TextBox textBox5;
        private Button button3;
        public TextBox textBox1;
        private Label label2;
        private Label label4;
        public TextBox textBox2;
        public TextBox textBox4;
    }
}
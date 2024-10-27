namespace WinFormsApp1.仓库管理.移库界面
{
    partial class Ms_add
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
            label14 = new Label();
            button6 = new Button();
            button7 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            button3 = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label5 = new Label();
            textBox15 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            button5 = new Button();
            textBox16 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(211, 389);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 96;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(133, 389);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(69, 20);
            label14.TabIndex = 95;
            label14.Text = "入库时间";
            // 
            // button6
            // 
            button6.Location = new Point(462, 463);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(109, 38);
            button6.TabIndex = 94;
            button6.Text = "返回";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(264, 463);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(109, 38);
            button7.TabIndex = 93;
            button7.Text = "确定";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.02128F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.97872F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 154F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(label1, 3, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 1);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(label11, 0, 0);
            tableLayoutPanel1.Controls.Add(label12, 3, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox15, 1, 4);
            tableLayoutPanel1.Controls.Add(label8, 3, 4);
            tableLayoutPanel1.Controls.Add(textBox3, 4, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(button5, 2, 4);
            tableLayoutPanel1.Controls.Add(textBox16, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBox2, 4, 2);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 4, 1);
            tableLayoutPanel1.Location = new Point(133, 54);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(570, 332);
            tableLayoutPanel1.TabIndex = 98;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 132);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 99;
            label1.Tag = "";
            label1.Text = "现库位号";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(89, 2);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(116, 27);
            textBox4.TabIndex = 85;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 66);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 42;
            label9.Text = "物料编码";
            // 
            // button3
            // 
            button3.Location = new Point(210, 69);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 81;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(2, 132);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 58;
            label10.Tag = "";
            label10.Text = "原库位号";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(2, 0);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 20);
            label11.TabIndex = 84;
            label11.Text = "移库单号";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(287, 66);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 90;
            label12.Text = "物料名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 264);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 79;
            label5.Text = "移库人";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(89, 266);
            textBox15.Margin = new Padding(2);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(116, 27);
            textBox15.TabIndex = 67;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 264);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 59;
            label8.Text = "移库人编号";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(377, 266);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 27);
            textBox3.TabIndex = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 198);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 43;
            label7.Text = "数量";
            // 
            // button5
            // 
            button5.Location = new Point(210, 267);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 83;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(89, 200);
            textBox16.Margin = new Padding(2);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(116, 27);
            textBox16.TabIndex = 66;
            textBox16.TextChanged += textBox16_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 28);
            comboBox1.TabIndex = 100;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(378, 135);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(114, 28);
            comboBox2.TabIndex = 88;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(89, 68);
            textBox5.Margin = new Padding(2);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(116, 27);
            textBox5.TabIndex = 89;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(377, 68);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 27);
            textBox1.TabIndex = 50;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Ms_add
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 553);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label14);
            Controls.Add(button6);
            Controls.Add(button7);
            Name = "Ms_add";
            Text = "Ms_add";
            Load += Ms_add_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Label label14;
        private Button button6;
        private Button button7;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBox2;
        private Label label1;
        private TextBox textBox4;
        private Label label9;
        public TextBox textBox1;
        private Button button3;
        private Label label10;
        private Label label11;
        public TextBox textBox5;
        private Label label12;
        private Label label5;
        public TextBox textBox15;
        private Label label8;
        public TextBox textBox3;
        private Label label7;
        private Button button5;
        public TextBox textBox16;
        private ComboBox comboBox1;
    }
}
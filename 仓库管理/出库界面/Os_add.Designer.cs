namespace WinFormsApp1.仓库管理.出库界面
{
    partial class Os_add
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            textBox2 = new TextBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            button5 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label15 = new Label();
            textBox4 = new TextBox();
            textBox15 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            label16 = new Label();
            label5 = new Label();
            textBox16 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.45946F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.54054F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 119F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.Controls.Add(button4, 5, 3);
            tableLayoutPanel1.Controls.Add(textBox2, 4, 3);
            tableLayoutPanel1.Controls.Add(label8, 3, 3);
            tableLayoutPanel1.Controls.Add(comboBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(button5, 2, 4);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 3, 2);
            tableLayoutPanel1.Controls.Add(label15, 3, 4);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox15, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 1);
            tableLayoutPanel1.Controls.Add(label16, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox16, 4, 2);
            tableLayoutPanel1.Controls.Add(textBox3, 4, 4);
            tableLayoutPanel1.Controls.Add(label7, 3, 1);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 4, 1);
            tableLayoutPanel1.Location = new Point(160, 61);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel1.Size = new Size(693, 398);
            tableLayoutPanel1.TabIndex = 96;
            // 
            // button4
            // 
            button4.Location = new Point(618, 241);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(37, 36);
            button4.TabIndex = 97;
            button4.Text = "...";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(456, 239);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 30);
            textBox2.TabIndex = 97;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 237);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(82, 24);
            label8.TabIndex = 97;
            label8.Text = "订单编号";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(93, 162);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(128, 32);
            comboBox2.TabIndex = 88;
            // 
            // button5
            // 
            button5.Location = new Point(229, 320);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(37, 36);
            button5.TabIndex = 83;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "销售提货", "生产领料", "其他出库" });
            comboBox1.Location = new Point(93, 241);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(128, 32);
            comboBox1.TabIndex = 86;
            comboBox1.Text = "销售提货";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 237);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 24);
            label6.TabIndex = 87;
            label6.Text = "出库类别";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 316);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 79;
            label4.Text = "出库人";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 158);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 43;
            label2.Text = "数量";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(346, 316);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(100, 24);
            label15.TabIndex = 59;
            label15.Text = "出库人编号";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(91, 2);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(131, 30);
            textBox4.TabIndex = 85;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(91, 318);
            textBox15.Margin = new Padding(2);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(131, 30);
            textBox15.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 79);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 42;
            label1.Text = "物料编码";
            // 
            // button3
            // 
            button3.Location = new Point(229, 83);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(37, 36);
            button3.TabIndex = 81;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(2, 158);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(64, 24);
            label16.TabIndex = 58;
            label16.Tag = "";
            label16.Text = "库位号";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 0);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 84;
            label5.Text = "出库单号";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(456, 160);
            textBox16.Margin = new Padding(2);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(149, 30);
            textBox16.TabIndex = 66;
            textBox16.TextChanged += textBox16_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(456, 318);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 30);
            textBox3.TabIndex = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 79);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 24);
            label7.TabIndex = 90;
            label7.Text = "物料名";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(91, 81);
            textBox5.Margin = new Padding(2);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(131, 32);
            textBox5.TabIndex = 89;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(456, 81);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 32);
            textBox1.TabIndex = 50;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 467);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 94;
            label3.Text = "出库时间";
            // 
            // button2
            // 
            button2.Location = new Point(565, 556);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(133, 46);
            button2.TabIndex = 93;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(323, 556);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(133, 46);
            button1.TabIndex = 92;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(258, 467);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(305, 30);
            dateTimePicker1.TabIndex = 95;
            dateTimePicker1.Value = new DateTime(2024, 10, 29, 0, 0, 0, 0);
            // 
            // Os_add
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 664);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Margin = new Padding(4);
            Name = "Os_add";
            Text = "Os_add";
            Load += Os_add_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBox2;
        private Button button5;
        private ComboBox comboBox1;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label15;
        private TextBox textBox4;
        public TextBox textBox15;
        private Label label1;
        public TextBox textBox1;
        private Button button3;
        private Label label16;
        private Label label5;
        public TextBox textBox3;
        public TextBox textBox5;
        private Label label7;
        private Label label3;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        public TextBox textBox2;
        private Label label8;
        private Button button4;
        public TextBox textBox16;
    }
}
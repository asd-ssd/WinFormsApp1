namespace WinFormsApp1.仓库管理.库存盘点界面
{
    partial class count_push_new
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
            dataGridView1 = new DataGridView();
            comboBox2 = new ComboBox();
            button5 = new Button();
            label4 = new Label();
            label15 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            textBox15 = new TextBox();
            label1 = new Label();
            label16 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button7 = new Button();
            label9 = new Label();
            richTextBox1 = new RichTextBox();
            button4 = new Button();
            label10 = new Label();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1056, 425);
            dataGridView1.TabIndex = 59;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(121, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(106, 28);
            comboBox2.TabIndex = 88;
            // 
            // button5
            // 
            button5.Location = new Point(238, 147);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 83;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 144);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 79;
            label4.Text = "盘点人员";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(284, 144);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(84, 20);
            label15.TabIndex = 59;
            label15.Text = "盘点人编号";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(120, 2);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(108, 27);
            textBox4.TabIndex = 85;
            // 
            // button2
            // 
            button2.Location = new Point(822, 202);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(109, 38);
            button2.TabIndex = 98;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(120, 146);
            textBox15.Margin = new Padding(2);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(108, 27);
            textBox15.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 42;
            label1.Text = "物料编码";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(2, 72);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(54, 20);
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
            label5.Size = new Size(69, 20);
            label5.TabIndex = 84;
            label5.Text = "盘点单号";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(374, 146);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 27);
            textBox3.TabIndex = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(284, 36);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 90;
            label7.Text = "物料名";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(120, 38);
            textBox5.Margin = new Padding(2);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(108, 27);
            textBox5.TabIndex = 89;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(374, 38);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 27);
            textBox1.TabIndex = 50;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(641, 202);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(109, 38);
            button1.TabIndex = 97;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(238, 39);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 81;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.27027F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.72973F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.Controls.Add(label8, 3, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(comboBox2, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 3, 1);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 4, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox15, 1, 4);
            tableLayoutPanel1.Controls.Add(button5, 2, 4);
            tableLayoutPanel1.Controls.Add(label15, 3, 4);
            tableLayoutPanel1.Controls.Add(textBox3, 4, 4);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox6, 4, 3);
            tableLayoutPanel1.Controls.Add(label16, 0, 2);
            tableLayoutPanel1.Location = new Point(26, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(567, 184);
            tableLayoutPanel1.TabIndex = 101;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(284, 108);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 110;
            label8.Text = "盘点后更正";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 108);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 110;
            label6.Text = "盘点前库存";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 110);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 27);
            textBox2.TabIndex = 109;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(374, 110);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(108, 27);
            textBox6.TabIndex = 109;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "全部", "当天", "本周", "本月", "本年" });
            comboBox1.Location = new Point(723, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 108;
            comboBox1.Text = "全部";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(618, 78);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 106;
            label2.Text = "最后盘点日期";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(768, 125);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 105;
            label3.Text = "-";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(789, 125);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(142, 27);
            dateTimePicker2.TabIndex = 104;
            dateTimePicker2.Value = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(622, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 27);
            dateTimePicker1.TabIndex = 103;
            dateTimePicker1.Value = new DateTime(2000, 1, 1, 16, 0, 0, 0);
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Desktop;
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(978, 88);
            button7.Name = "button7";
            button7.Size = new Size(85, 57);
            button7.TabIndex = 102;
            button7.Text = "查询";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 205);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 109;
            label9.Text = "备注";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(145, 202);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(149, 67);
            richTextBox1.TabIndex = 111;
            richTextBox1.Text = "";
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Location = new Point(11, 311);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(33, 152);
            button4.TabIndex = 112;
            button4.Text = "选择该行填入";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(622, 32);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 113;
            label10.Tag = "";
            label10.Text = "库位号";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(723, 29);
            textBox7.Margin = new Padding(2);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(108, 27);
            textBox7.TabIndex = 114;
            // 
            // count_push_new
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 748);
            Controls.Add(textBox7);
            Controls.Add(label10);
            Controls.Add(button4);
            Controls.Add(richTextBox1);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "count_push_new";
            Text = "count_push_new";
            Load += count_push_new_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Button button5;
        private Label label4;
        private Label label15;
        private TextBox textBox4;
        private Button button2;
        public TextBox textBox15;
        private Label label1;
        private Label label16;
        private Label label5;
        public TextBox textBox3;
        private Label label7;
        public TextBox textBox5;
        public TextBox textBox1;
        private Button button1;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label6;
        public TextBox textBox2;
        public TextBox textBox6;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button7;
        private Label label9;
        private RichTextBox richTextBox1;
        private Button button4;
        private Label label10;
        public TextBox textBox7;
    }
}
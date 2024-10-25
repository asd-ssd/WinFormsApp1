namespace WinFormsApp1.仓库管理.出库界面
{
    partial class Os
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
            button4 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            button7 = new Button();
            button13 = new Button();
            button12 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(240, 3);
            button4.Name = "button4";
            button4.Size = new Size(73, 80);
            button4.TabIndex = 3;
            button4.Text = "刷新";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button5, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Location = new Point(39, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(397, 87);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(73, 80);
            button1.TabIndex = 0;
            button1.Text = "新增\r\n出库";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(82, 3);
            button2.Name = "button2";
            button2.Size = new Size(73, 80);
            button2.TabIndex = 1;
            button2.Text = "修改\r\n数据";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(319, 3);
            button5.Name = "button5";
            button5.Size = new Size(73, 80);
            button5.TabIndex = 4;
            button5.Text = "导出\r\n打印";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(161, 3);
            button3.Name = "button3";
            button3.Size = new Size(73, 80);
            button3.TabIndex = 2;
            button3.Text = "删除";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1000, 411);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 550);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 15;
            label3.Text = "查询：";
            // 
            // button7
            // 
            button7.Location = new Point(884, 550);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 22;
            button7.Text = "查询";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button13
            // 
            button13.Location = new Point(808, 38);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            button13.TabIndex = 46;
            button13.Text = "取消";
            button13.UseVisualStyleBackColor = true;
            button13.Visible = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(666, 38);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 45;
            button12.Text = "保存";
            button12.UseVisualStyleBackColor = true;
            button12.Visible = false;
            button12.Click += button12_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(388, 562);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(142, 27);
            dateTimePicker2.TabIndex = 56;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(367, 567);
            label11.Name = "label11";
            label11.Size = new Size(15, 20);
            label11.TabIndex = 55;
            label11.Text = "-";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(219, 562);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(142, 27);
            dateTimePicker1.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 567);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 53;
            label5.Text = "出库时间";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 530);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 52;
            label4.Text = "出库单号";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(257, 523);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 571);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 50;
            label2.Text = "物料编号";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(721, 564);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(572, 535);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 48;
            label1.Text = "物料名";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(721, 527);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 47;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(96, 569);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 57;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Os
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(radioButton1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label11);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button7);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Name = "Os";
            Size = new Size(1000, 600);
            Load += Os_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
        private Button button7;
        private Button button5;
        private Button button13;
        private Button button12;
        private DateTimePicker dateTimePicker2;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private RadioButton radioButton1;
    }
}

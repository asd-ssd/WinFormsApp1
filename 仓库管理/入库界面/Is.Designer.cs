namespace WinFormsApp1.仓库管理.入库界面
{
    partial class Is
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
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            button7 = new Button();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            dataGridView2 = new DataGridView();
            button6 = new Button();
            button8 = new Button();
            button9 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            button10 = new Button();
            label10 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button12 = new Button();
            button13 = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 114);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1305, 643);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0004959F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0005016F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0004978F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9985046F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Location = new Point(48, 6);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.Size = new Size(420, 104);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(4, 4);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(89, 96);
            button1.TabIndex = 0;
            button1.Text = "新增\r\n入库";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(319, 4);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(89, 96);
            button4.TabIndex = 3;
            button4.Text = "刷新";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(109, 4);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(89, 96);
            button2.TabIndex = 1;
            button2.Text = "修改\r\n数据";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(214, 4);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(89, 96);
            button3.TabIndex = 2;
            button3.Text = "删除";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 835);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 6;
            label3.Text = "查询：";
            // 
            // button7
            // 
            button7.Location = new Point(1080, 857);
            button7.Margin = new Padding(4, 4, 4, 4);
            button7.Name = "button7";
            button7.Size = new Size(115, 35);
            button7.TabIndex = 22;
            button7.Text = "查询";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 854);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 32;
            label5.Text = "入库时间";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 810);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 30;
            label4.Text = "入库单号";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(315, 802);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 30);
            textBox3.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(700, 859);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 28;
            label2.Text = "物料编号";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(882, 851);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 30);
            textBox2.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(700, 816);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 26;
            label1.Text = "物料名";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(882, 806);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 30);
            textBox1.TabIndex = 25;
            // 
            // button5
            // 
            button5.Location = new Point(123, 3);
            button5.Name = "button5";
            button5.Size = new Size(33, 81);
            button5.TabIndex = 3;
            button5.Text = "导出\r\n打印";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 70);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(73, 14);
            dataGridView2.TabIndex = 33;
            // 
            // button6
            // 
            button6.Location = new Point(83, 3);
            button6.Name = "button6";
            button6.Size = new Size(34, 81);
            button6.TabIndex = 2;
            button6.Text = "删除";
            button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(43, 3);
            button8.Name = "button8";
            button8.Size = new Size(34, 81);
            button8.TabIndex = 1;
            button8.Text = "修改\r\n数据";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(3, 3);
            button9.Name = "button9";
            button9.Size = new Size(34, 81);
            button9.TabIndex = 0;
            button9.Text = "新增\r\n入库";
            button9.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 67);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 44;
            label6.Text = "入库时间";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 70);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(73, 30);
            textBox5.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 67);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 42;
            label7.Text = "入库单号";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(3, 70);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(73, 30);
            textBox6.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 67);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 40;
            label8.Text = "物料编号";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(3, 70);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(73, 30);
            textBox7.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 67);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 38;
            label9.Text = "物料名";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(3, 70);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(73, 30);
            textBox8.TabIndex = 37;
            // 
            // button10
            // 
            button10.Location = new Point(3, 70);
            button10.Name = "button10";
            button10.Size = new Size(73, 14);
            button10.TabIndex = 36;
            button10.Text = "查询";
            button10.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 67);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 35;
            label10.Text = "查询：";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0004959F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0005016F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0004978F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9985046F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(button6, 2, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(450, 854);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(18, 24);
            label11.TabIndex = 41;
            label11.Text = "-";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(269, 848);
            dateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(173, 30);
            dateTimePicker1.TabIndex = 39;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(475, 848);
            dateTimePicker2.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(173, 30);
            dateTimePicker2.TabIndex = 42;
            // 
            // button12
            // 
            button12.Location = new Point(821, 41);
            button12.Margin = new Padding(4, 4, 4, 4);
            button12.Name = "button12";
            button12.Size = new Size(115, 35);
            button12.TabIndex = 43;
            button12.Text = "保存";
            button12.UseVisualStyleBackColor = true;
            button12.Visible = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(995, 41);
            button13.Margin = new Padding(4, 4, 4, 4);
            button13.Name = "button13";
            button13.Size = new Size(115, 35);
            button13.TabIndex = 44;
            button13.Text = "取消";
            button13.UseVisualStyleBackColor = true;
            button13.Visible = false;
            button13.Click += button13_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(120, 857);
            checkBox1.Margin = new Padding(4, 4, 4, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 58;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Is
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBox1);
            Controls.Add(button13);
            Controls.Add(button12);
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
            Controls.Add(button7);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Is";
            Size = new Size(1309, 946);
            Load += Is_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Label label3;
        private Button button4;
        private Button button7;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button5;
        private DataGridView dataGridView2;
        private Button button6;
        private Button button8;
        private Button button9;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
        private Button button10;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        public DataGridView dataGridView1;
        private Button button12;
        private Button button13;
        private CheckBox checkBox1;
    }
}

namespace WinFormsApp1.仓库管理.库存盘点界面
{
    partial class warehouse_count
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
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button7 = new Button();
            label7 = new Label();
            textBox5 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button13 = new Button();
            button12 = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(159, 26);
            button2.Name = "button2";
            button2.Size = new Size(84, 81);
            button2.TabIndex = 1;
            button2.Text = "库存盘点单";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1000, 428);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 42);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 66;
            label5.Text = "库房号";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(337, 45);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 64;
            label4.Text = "库位号";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(337, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 42);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 62;
            label3.Text = "物料编号";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 60;
            label6.Text = "物料名";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 59;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(610, 46);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 58;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(535, 43);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 57;
            label2.Text = "选择日期";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(685, 98);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 56;
            label1.Text = "-";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(706, 98);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(142, 27);
            dateTimePicker2.TabIndex = 55;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(539, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 27);
            dateTimePicker1.TabIndex = 54;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Desktop;
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(895, 61);
            button7.Name = "button7";
            button7.Size = new Size(85, 57);
            button7.TabIndex = 53;
            button7.Text = "查询";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 84);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 68;
            label7.Text = "物料分类";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(102, 87);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 67;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 3, 0);
            tableLayoutPanel1.Controls.Add(textBox4, 3, 1);
            tableLayoutPanel1.Controls.Add(label5, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Location = new Point(19, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.Size = new Size(477, 126);
            tableLayoutPanel1.TabIndex = 69;
            // 
            // button13
            // 
            button13.Location = new Point(751, 39);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            button13.TabIndex = 71;
            button13.Text = "取消";
            button13.UseVisualStyleBackColor = true;
            button13.Visible = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(618, 39);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 70;
            button12.Text = "保存";
            button12.UseVisualStyleBackColor = true;
            button12.Visible = false;
            button12.Click += button12_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button13);
            groupBox1.Controls.Add(button12);
            groupBox1.Location = new Point(3, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1077, 119);
            groupBox1.TabIndex = 72;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(34, 26);
            button1.Name = "button1";
            button1.Size = new Size(84, 81);
            button1.TabIndex = 1;
            button1.Text = "更新\r\n盘点日期";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "全部", "当天", "本周", "本月", "本年" });
            comboBox1.Location = new Point(634, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 73;
            comboBox1.Text = "本月";
            // 
            // warehouse_count
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button7);
            Name = "warehouse_count";
            Size = new Size(1006, 775);
            Load += warehouse_count_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button7;
        private Label label7;
        private TextBox textBox5;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button13;
        private Button button12;
        private GroupBox groupBox1;
        private Button button1;
        private ComboBox comboBox1;
    }
}

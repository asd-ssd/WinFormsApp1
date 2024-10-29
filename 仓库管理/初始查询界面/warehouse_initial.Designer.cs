namespace WinFormsApp1.仓库管理.初始查询界面
{
    partial class warehouse_initial
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
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button8 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button7 = new Button();
            button13 = new Button();
            button12 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 116);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1222, 652);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2856607F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2856655F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2856617F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2842379F));
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button8, 3, 0);
            tableLayoutPanel1.Location = new Point(4, 4);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.Size = new Size(507, 106);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(130, 4);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(93, 97);
            button2.TabIndex = 1;
            button2.Text = "修改\r\n数据";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(4, 4);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(93, 97);
            button1.TabIndex = 0;
            button1.Text = "新增\r\n数据";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(256, 4);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(93, 97);
            button3.TabIndex = 2;
            button3.Text = "删除";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button8
            // 
            button8.Location = new Point(382, 4);
            button8.Margin = new Padding(4, 4, 4, 4);
            button8.Name = "button8";
            button8.Size = new Size(94, 97);
            button8.TabIndex = 6;
            button8.Text = "刷新";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 839);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 18;
            label4.Text = "库位号";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(269, 830);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 30);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 852);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 16;
            label3.Text = "查询：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(535, 889);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 15;
            label2.Text = "物料编号";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(629, 881);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 30);
            textBox2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(535, 835);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 13;
            label1.Text = "物料名";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(629, 830);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 30);
            textBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 889);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 24);
            label5.TabIndex = 20;
            label5.Text = "库房号";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(269, 881);
            textBox4.Margin = new Padding(4, 4, 4, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(152, 30);
            textBox4.TabIndex = 19;
            // 
            // button7
            // 
            button7.Location = new Point(972, 856);
            button7.Margin = new Padding(4, 4, 4, 4);
            button7.Name = "button7";
            button7.Size = new Size(115, 35);
            button7.TabIndex = 21;
            button7.Text = "查询";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button13
            // 
            button13.Location = new Point(1035, 38);
            button13.Margin = new Padding(4, 4, 4, 4);
            button13.Name = "button13";
            button13.Size = new Size(115, 35);
            button13.TabIndex = 46;
            button13.Text = "取消";
            button13.UseVisualStyleBackColor = true;
            button13.Visible = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(862, 38);
            button12.Margin = new Padding(4, 4, 4, 4);
            button12.Name = "button12";
            button12.Size = new Size(115, 35);
            button12.TabIndex = 45;
            button12.Text = "保存";
            button12.UseVisualStyleBackColor = true;
            button12.Visible = false;
            button12.Click += button12_Click;
            // 
            // warehouse_initial
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button7);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "warehouse_initial";
            Size = new Size(1222, 960);
            Load += warehouse_initial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox4;
        private Button button7;
        private Button button8;
        private Button button13;
        private Button button12;
        public DataGridView dataGridView1;
    }
}

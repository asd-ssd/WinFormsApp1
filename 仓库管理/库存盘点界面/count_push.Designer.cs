namespace WinFormsApp1.仓库管理.库存盘点界面
{
    partial class count_push
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
            button8 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1000, 344);
            dataGridView1.TabIndex = 14;
            // 
            // button8
            // 
            button8.Location = new Point(237, 3);
            button8.Name = "button8";
            button8.Size = new Size(71, 81);
            button8.TabIndex = 15;
            button8.Text = "盘点单\r\n查询";
            button8.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2858887F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28589F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2858858F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.290226F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2855282F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285533F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2810478F));
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button5, 4, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button8, 3, 0);
            tableLayoutPanel1.Controls.Add(button4, 6, 0);
            tableLayoutPanel1.Controls.Add(button6, 5, 0);
            tableLayoutPanel1.Location = new Point(31, 7);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(546, 89);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(469, 3);
            button4.Name = "button4";
            button4.Size = new Size(74, 81);
            button4.TabIndex = 3;
            button4.Text = "导出\r\n打印";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(315, 3);
            button5.Name = "button5";
            button5.Size = new Size(71, 81);
            button5.TabIndex = 4;
            button5.Text = "下一页";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(392, 3);
            button6.Name = "button6";
            button6.Size = new Size(71, 81);
            button6.TabIndex = 5;
            button6.Text = "上一页";
            button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(72, 81);
            button1.TabIndex = 0;
            button1.Text = "新增\r\n盘点";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(81, 3);
            button2.Name = "button2";
            button2.Size = new Size(72, 81);
            button2.TabIndex = 1;
            button2.Text = "修改\r\n盘点\r\n状态";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(159, 3);
            button3.Name = "button3";
            button3.Size = new Size(71, 81);
            button3.TabIndex = 16;
            button3.Text = "盘点单\r\n查询";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 116);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 39;
            label2.Text = "盘点日期";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 113);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 38;
            label1.Text = "-";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(413, 111);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(136, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 36;
            // 
            // button7
            // 
            button7.Location = new Point(702, 109);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 35;
            button7.Text = "查询";
            button7.UseVisualStyleBackColor = true;
            // 
            // count_push
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button7);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "count_push";
            Size = new Size(997, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button8;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button4;
        private Button button5;
        private Button button1;
        private Button button2;
        private Button button6;
        private Button button3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button7;
    }
}

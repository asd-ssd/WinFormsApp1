﻿namespace WinFormsApp1.仓库管理.出库界面
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button7 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(300, 3);
            button4.Name = "button4";
            button4.Size = new Size(92, 81);
            button4.TabIndex = 3;
            button4.Text = "导出\r\n打印";
            button4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9981289F));
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Location = new Point(39, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(397, 87);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(201, 3);
            button3.Name = "button3";
            button3.Size = new Size(92, 81);
            button3.TabIndex = 2;
            button3.Text = "删除";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(102, 3);
            button2.Name = "button2";
            button2.Size = new Size(92, 81);
            button2.TabIndex = 1;
            button2.Text = "修改\r\n数据";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(92, 81);
            button1.TabIndex = 0;
            button1.Text = "新增\r\n出库";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1000, 411);
            dataGridView1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 535);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 17;
            label4.Text = "出库单号";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 528);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 16;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 572);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 14;
            label2.Text = "物料编号";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(487, 565);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 536);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 12;
            label1.Text = "物料名";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(487, 528);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // button7
            // 
            button7.Location = new Point(884, 550);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 22;
            button7.Text = "查询";
            button7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 572);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 24;
            label5.Text = "出库时间";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(240, 565);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 23;
            // 
            // Os
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button7);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Os";
            Size = new Size(1000, 600);
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
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button7;
        private Label label5;
        private TextBox textBox4;
    }
}

namespace WinFormsApp1.计划管理.三级
{
    partial class 车间作业
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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            textBox3 = new TextBox();
            checkBox5 = new CheckBox();
            textBox1 = new TextBox();
            checkBox4 = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1688, 50);
            panel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(188, 0);
            button3.Name = "button3";
            button3.Size = new Size(94, 50);
            button3.TabIndex = 2;
            button3.Text = "删除";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(94, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 50);
            button2.TabIndex = 1;
            button2.Text = "修改";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(94, 50);
            button4.TabIndex = 3;
            button4.Text = "刷新";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(checkBox5);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(checkBox4);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(1688, 120);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(577, 66);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "查询";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(381, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 27);
            textBox3.TabIndex = 11;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(311, 69);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(76, 24);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "单号：";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 27);
            textBox1.TabIndex = 8;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(51, 69);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(76, 24);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "产品：";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(531, 25);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(140, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 25);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 5;
            label2.Text = "到";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(341, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(140, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 25);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 3;
            label1.Text = "从";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(251, 25);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(76, 24);
            checkBox3.TabIndex = 1;
            checkBox3.Text = "日期：";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(151, 25);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 24);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "已完成";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(51, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "未完成";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1688, 966);
            dataGridView1.TabIndex = 7;
            // 
            // 车间作业
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "车间作业";
            Size = new Size(1688, 1136);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Panel panel2;
        private Button button1;
        private TextBox textBox3;
        private CheckBox checkBox5;
        private TextBox textBox1;
        private CheckBox checkBox4;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
    }
}

namespace WinFormsApp1.仓库管理.库存盘点界面
{
    partial class count_issue
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
            label4 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label6 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 23);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 65;
            label4.Text = "库存盘点号";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 16);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 95);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 63;
            label2.Text = "物料编号";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 58);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 61;
            label1.Text = "物料名";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 60;
            // 
            // button7
            // 
            button7.Location = new Point(828, 42);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 59;
            button7.Text = "查询";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1064, 479);
            dataGridView1.TabIndex = 71;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "全部", "当天", "本周", "本月", "本年" });
            comboBox1.Location = new Point(565, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 113;
            comboBox1.Text = "全部";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 35);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 112;
            label3.Text = "盘点日期";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(616, 90);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 111;
            label6.Text = "-";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(637, 90);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(142, 27);
            dateTimePicker3.TabIndex = 110;
            dateTimePicker3.Value = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(470, 90);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(139, 27);
            dateTimePicker4.TabIndex = 109;
            dateTimePicker4.Value = new DateTime(2000, 1, 1, 16, 0, 0, 0);
            // 
            // count_issue
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 703);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker4);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button7);
            Name = "count_issue";
            Text = "count_issue";
            Load += count_issue_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button7;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label6;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
    }
}
﻿namespace WinFormsApp1.仓库管理.库存盘点界面
{
    partial class count_add
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
            textBox3 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(320, 244);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 30);
            textBox3.TabIndex = 94;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 246);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 93;
            label4.Text = "入库类别";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(320, 305);
            dateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(305, 30);
            dateTimePicker1.TabIndex = 92;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 305);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 91;
            label3.Text = "入库时间";
            // 
            // button2
            // 
            button2.Location = new Point(556, 395);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(133, 46);
            button2.TabIndex = 90;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(314, 395);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(133, 46);
            button1.TabIndex = 89;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(625, 176);
            textBox15.Margin = new Padding(2);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(149, 30);
            textBox15.TabIndex = 88;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(625, 100);
            textBox16.Margin = new Padding(2);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(149, 30);
            textBox16.TabIndex = 87;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(515, 179);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(64, 24);
            label15.TabIndex = 86;
            label15.Text = "入库人";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(207, 179);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(64, 24);
            label16.TabIndex = 85;
            label16.Tag = "";
            label16.Text = "库位号";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(313, 176);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 30);
            textBox2.TabIndex = 84;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(313, 103);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 30);
            textBox1.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(515, 103);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 82;
            label2.Text = "数量";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 103);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 81;
            label1.Text = "物料名";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 502);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1222, 475);
            dataGridView1.TabIndex = 95;
            // 
            // count_add
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 1028);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox15);
            Controls.Add(textBox16);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "count_add";
            Text = "count_add";
            Load += count_add_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button button2;
        private Button button1;
        private TextBox textBox15;
        private TextBox textBox16;
        private Label label15;
        private Label label16;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
﻿namespace WinFormsApp1.计划管理.三级功能
{
    partial class 工序排程
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.Location = new Point(282, 0);
            button4.Name = "button4";
            button4.Size = new Size(94, 40);
            button4.TabIndex = 3;
            button4.Text = "取消";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(188, 0);
            button3.Name = "button3";
            button3.Size = new Size(94, 40);
            button3.TabIndex = 2;
            button3.Text = "下达派工单";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(94, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 40);
            button2.TabIndex = 1;
            button2.Text = "全不选";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 0;
            button1.Text = "全选";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 410);
            dataGridView1.TabIndex = 1;
            // 
            // 工序排程
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "工序排程";
            Text = "工序排程";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
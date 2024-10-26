namespace WinFormsApp1.计划管理.三级功能
{
    partial class 领料
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
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 40);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 0;
            button1.Text = "生成领料单";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 410);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 386);
            dataGridView1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 0;
            label4.Text = "领料明细";
            // 
            // 领料
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "领料";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "领料";
            Load += 领料_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Label label4;
        public DataGridView dataGridView1;
    }
}
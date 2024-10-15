namespace WinFormsApp1.Forth
{
    partial class MRP生成
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
            panel2 = new Panel();
            label1 = new Label();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            button7 = new Button();
            button8 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 74);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(857, 439);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(857, 35);
            label1.TabIndex = 0;
            label1.Text = "物料需求计划表";
            label1.Click += label1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(41, 22);
            button5.Name = "button5";
            button5.Size = new Size(159, 30);
            button5.TabIndex = 4;
            button5.Text = "需求计算";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(857, 354);
            dataGridView1.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(600, 399);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 2;
            button7.Text = "全选";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(730, 399);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 3;
            button8.Text = "全不选";
            button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(656, 22);
            button4.Name = "button4";
            button4.Size = new Size(159, 30);
            button4.TabIndex = 3;
            button4.Text = "采购计划生成";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(451, 22);
            button3.Name = "button3";
            button3.Size = new Size(159, 30);
            button3.TabIndex = 2;
            button3.Text = "车间生产计划生成";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(246, 22);
            button1.Name = "button1";
            button1.Size = new Size(159, 30);
            button1.TabIndex = 5;
            button1.Text = "保存需求";
            button1.UseVisualStyleBackColor = true;
            // 
            // MRP生成
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(857, 513);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MRP生成";
            Text = "MRP生成";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button5;
        private DataGridView dataGridView1;
        private Button button8;
        private Button button7;
        private Button button4;
        private Button button3;
        private Button button1;
    }
}
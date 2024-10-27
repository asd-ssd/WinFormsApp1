namespace WinFormsApp1.工作界面
{
    partial class workplat1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            replybutton = new Button();
            button3 = new Button();
            deletebutton = new Button();
            compeletebutton = new Button();
            button1 = new Button();
            dataGridViewTasks = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Controls.Add(dataGridViewTasks, 0, 1);
            tableLayoutPanel3.Controls.Add(panel2, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 771F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 290F));
            tableLayoutPanel3.Size = new Size(1688, 1136);
            tableLayoutPanel3.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(replybutton);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(deletebutton);
            panel1.Controls.Add(compeletebutton);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1682, 69);
            panel1.TabIndex = 2;
            // 
            // replybutton
            // 
            replybutton.Location = new Point(464, 6);
            replybutton.Name = "replybutton";
            replybutton.Size = new Size(112, 62);
            replybutton.TabIndex = 6;
            replybutton.Text = "回复";
            replybutton.UseVisualStyleBackColor = true;
            replybutton.Click += replybutton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(345, 4);
            button3.Name = "button3";
            button3.Size = new Size(113, 62);
            button3.TabIndex = 5;
            button3.Text = "发布任务";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(231, 0);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(108, 65);
            deletebutton.TabIndex = 4;
            deletebutton.Text = "删除";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // compeletebutton
            // 
            compeletebutton.Location = new Point(117, 2);
            compeletebutton.Name = "compeletebutton";
            compeletebutton.Size = new Size(108, 65);
            compeletebutton.TabIndex = 3;
            compeletebutton.Text = "完成";
            compeletebutton.UseVisualStyleBackColor = true;
            compeletebutton.Click += compeletebutton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(108, 65);
            button1.TabIndex = 0;
            button1.Text = "刷新";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewTasks.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Dock = DockStyle.Fill;
            dataGridViewTasks.Location = new Point(3, 78);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 62;
            dataGridViewTasks.Size = new Size(1682, 765);
            dataGridViewTasks.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(richTextBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 849);
            panel2.Name = "panel2";
            panel2.Size = new Size(1682, 284);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(757, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 24);
            label1.TabIndex = 1;
            label1.Text = "任务具体内容";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(-3, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1685, 245);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // workplat1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(tableLayoutPanel3);
            Name = "workplat1";
            Size = new Size(1688, 1136);
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Button deletebutton;
        private Button compeletebutton;
        private Button button1;
        private Button button3;
        private Panel panel2;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button replybutton;
        public DataGridView dataGridViewTasks;
    }
}

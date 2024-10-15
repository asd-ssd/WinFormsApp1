
namespace WinFormsApp1
{
    partial class workplatform
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
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label12 = new Label();
            label14 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.LightSteelBlue;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button1, 0, 9);
            tableLayoutPanel2.Controls.Add(label13, 0, 5);
            tableLayoutPanel2.Controls.Add(label11, 0, 3);
            tableLayoutPanel2.Controls.Add(label10, 0, 2);
            tableLayoutPanel2.Controls.Add(label9, 0, 1);
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 4);
            tableLayoutPanel2.Controls.Add(label14, 0, 7);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 8);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.847545F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.976744F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.751938F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.45994854F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.268734F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6382427F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.16795874F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7002583F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(351, 777);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(71, 708);
            button1.Name = "button1";
            button1.Size = new Size(209, 51);
            button1.TabIndex = 17;
            button1.Text = "查询";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(8, 302);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(335, 62);
            label13.TabIndex = 5;
            label13.Text = "日期范围";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Microsoft YaHei UI", 10.5F);
            label11.Location = new Point(8, 190);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(335, 58);
            label11.TabIndex = 3;
            label11.Text = "逾期事项（0）";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Microsoft YaHei UI", 10.5F);
            label10.Location = new Point(8, 135);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(335, 52);
            label10.TabIndex = 2;
            label10.Text = "已完成（0）";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Microsoft YaHei UI", 10.5F);
            label9.Location = new Point(8, 81);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(335, 51);
            label9.TabIndex = 1;
            label9.Text = "未完成（0）";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label8.Location = new Point(8, 3);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(335, 75);
            label8.TabIndex = 0;
            label8.Text = "所有事项";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label12.Location = new Point(8, 251);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(335, 48);
            label12.TabIndex = 4;
            label12.Text = "查询";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(8, 517);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(335, 38);
            label14.TabIndex = 6;
            label14.Text = "关键词";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(100, 609);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 7;
            // 
            // workplatform
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(tableLayoutPanel2);
            Name = "workplatform";
            Size = new Size(351, 777);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Label label13;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label12;
        private Label label14;
        private TextBox textBox1;
    }
}

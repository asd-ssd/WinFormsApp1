
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
            myedbutton = new Button();
            mypublishbutton = new Button();
            compeletebutton = new Button();
            panel2 = new Panel();
            label3 = new Label();
            dateTimePicker3 = new DateTimePicker();
            uncompeletebutton = new Button();
            resbutton = new Button();
            label8 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            allbutton = new Button();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.LightSteelBlue;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(myedbutton, 0, 5);
            tableLayoutPanel2.Controls.Add(mypublishbutton, 0, 4);
            tableLayoutPanel2.Controls.Add(compeletebutton, 0, 3);
            tableLayoutPanel2.Controls.Add(panel2, 0, 8);
            tableLayoutPanel2.Controls.Add(uncompeletebutton, 0, 2);
            tableLayoutPanel2.Controls.Add(resbutton, 0, 9);
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 6);
            tableLayoutPanel2.Controls.Add(panel1, 0, 7);
            tableLayoutPanel2.Controls.Add(allbutton, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.909361F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.851936F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.265196F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.749911F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.265196F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.02541637F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0559874F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8773546F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8773527F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1222878F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(351, 777);
            tableLayoutPanel2.TabIndex = 16;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // myedbutton
            // 
            myedbutton.Dock = DockStyle.Fill;
            myedbutton.Location = new Point(6, 324);
            myedbutton.Name = "myedbutton";
            myedbutton.Size = new Size(339, 46);
            myedbutton.TabIndex = 25;
            myedbutton.Text = "我执行的";
            myedbutton.UseVisualStyleBackColor = true;
            myedbutton.Click += myedbutton_Click;
            // 
            // mypublishbutton
            // 
            mypublishbutton.Dock = DockStyle.Fill;
            mypublishbutton.Location = new Point(6, 260);
            mypublishbutton.Name = "mypublishbutton";
            mypublishbutton.Size = new Size(339, 55);
            mypublishbutton.TabIndex = 24;
            mypublishbutton.Text = "我发布的";
            mypublishbutton.UseVisualStyleBackColor = true;
            mypublishbutton.Click += mypublishbutton_Click;
            // 
            // compeletebutton
            // 
            compeletebutton.Dock = DockStyle.Fill;
            compeletebutton.Location = new Point(6, 207);
            compeletebutton.Name = "compeletebutton";
            compeletebutton.Size = new Size(339, 44);
            compeletebutton.TabIndex = 23;
            compeletebutton.Text = "已完成";
            compeletebutton.UseVisualStyleBackColor = true;
            compeletebutton.Click += compeletebutton_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dateTimePicker3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(6, 569);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 104);
            panel2.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MintCream;
            label3.Location = new Point(132, 10);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 3;
            label3.Text = "结束时间";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(27, 52);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(300, 30);
            dateTimePicker3.TabIndex = 0;
            // 
            // uncompeletebutton
            // 
            uncompeletebutton.Dock = DockStyle.Fill;
            uncompeletebutton.Location = new Point(6, 143);
            uncompeletebutton.Name = "uncompeletebutton";
            uncompeletebutton.Size = new Size(339, 55);
            uncompeletebutton.TabIndex = 20;
            uncompeletebutton.Text = "未完成";
            uncompeletebutton.UseVisualStyleBackColor = true;
            uncompeletebutton.Click += uncompeletebutton_Click;
            // 
            // resbutton
            // 
            resbutton.Anchor = AnchorStyles.None;
            resbutton.Location = new Point(71, 701);
            resbutton.Name = "resbutton";
            resbutton.Size = new Size(209, 51);
            resbutton.TabIndex = 17;
            resbutton.Text = "查询";
            resbutton.UseVisualStyleBackColor = true;
            resbutton.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label8.Location = new Point(8, 3);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(335, 73);
            label8.TabIndex = 0;
            label8.Text = "所有事项";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label12.Location = new Point(8, 376);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(335, 74);
            label12.TabIndex = 4;
            label12.Text = "查询";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(6, 456);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 104);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MintCream;
            label1.Location = new Point(132, 15);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 2;
            label1.Text = "开始时间";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 30);
            dateTimePicker1.TabIndex = 0;
            // 
            // allbutton
            // 
            allbutton.Dock = DockStyle.Fill;
            allbutton.Location = new Point(6, 82);
            allbutton.Name = "allbutton";
            allbutton.Size = new Size(339, 52);
            allbutton.TabIndex = 19;
            allbutton.Text = "全部";
            allbutton.UseVisualStyleBackColor = true;
            allbutton.Click += allbutton_Click;
            // 
            // workplatform
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(tableLayoutPanel2);
            Name = "workplatform";
            Size = new Size(351, 777);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button resbutton;
        private Label label8;
        private Label label12;
        private Panel panel1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Label label3;
        private DateTimePicker dateTimePicker3;
        private Button uncompeletebutton;
        private Button allbutton;
        private Button compeletebutton;
        private Button myedbutton;
        private Button mypublishbutton;
    }
}

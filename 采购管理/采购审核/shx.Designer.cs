using System.Windows.Forms;

namespace WinFormsApp1.采购管理.采购审核
{
    partial class shx
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
            button2 = new Button();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button1 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(240, 3);
            button4.Name = "button4";
            button4.Size = new Size(112, 92);
            button4.TabIndex = 45;
            button4.Text = "保存";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 92);
            button2.TabIndex = 43;
            button2.Text = "查询";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 445);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1222, 235);
            dataGridView2.TabIndex = 47;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // button3
            // 
            button3.Location = new Point(358, 3);
            button3.Name = "button3";
            button3.Size = new Size(112, 92);
            button3.TabIndex = 48;
            button3.Text = "审核";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1222, 223);
            dataGridView1.TabIndex = 49;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // button5
            // 
            button5.Location = new Point(121, 3);
            button5.Name = "button5";
            button5.Size = new Size(112, 92);
            button5.TabIndex = 50;
            button5.Text = "刷新";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1107, 374);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 51;
            button1.Text = "删除";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1107, 686);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 52;
            button6.Text = "删除";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(3, 116);
            label1.Name = "label1";
            label1.Size = new Size(84, 26);
            label1.TabIndex = 53;
            label1.Text = "驳回订单";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(0, 416);
            label2.Name = "label2";
            label2.Size = new Size(84, 26);
            label2.TabIndex = 54;
            label2.Text = "通过订单";
            // 
            // shx
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(dataGridView2);
            Controls.Add(button4);
            Controls.Add(button2);
            Name = "shx";
            Size = new Size(1222, 720);
            Load += shx_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button2;
        public DataGridView dataGridView2;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button6;
        private Label label1;
        private Label label2;
        public DataGridView dataGridView1;
    }
}

using System.Windows.Forms;

namespace WinFormsApp1.销售管理
{
    partial class ReceiptForm
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
            rsearch = new Button();
            rdelete = new Button();
            redit = new Button();
            rcreat = new Button();
            rfdataGridView1 = new DataGridView();
            rcancel = new Button();
            redit2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)rfdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // rsearch
            // 
            rsearch.BackColor = SystemColors.GradientInactiveCaption;
            rsearch.Location = new Point(482, 42);
            rsearch.Name = "rsearch";
            rsearch.Size = new Size(138, 40);
            rsearch.TabIndex = 66;
            rsearch.Text = "查询";
            rsearch.UseVisualStyleBackColor = false;
            rsearch.Click += rsearch_Click;
            // 
            // rdelete
            // 
            rdelete.BackColor = SystemColors.GradientInactiveCaption;
            rdelete.Location = new Point(338, 42);
            rdelete.Name = "rdelete";
            rdelete.Size = new Size(138, 40);
            rdelete.TabIndex = 65;
            rdelete.Text = "删除";
            rdelete.UseVisualStyleBackColor = false;
            rdelete.Click += rdelete_Click;
            // 
            // redit
            // 
            redit.BackColor = SystemColors.GradientInactiveCaption;
            redit.Location = new Point(194, 42);
            redit.Name = "redit";
            redit.Size = new Size(138, 40);
            redit.TabIndex = 64;
            redit.Text = "修改";
            redit.UseVisualStyleBackColor = false;
            redit.Click += redit_Click;
            // 
            // rcreat
            // 
            rcreat.BackColor = SystemColors.GradientInactiveCaption;
            rcreat.Location = new Point(50, 42);
            rcreat.Name = "rcreat";
            rcreat.Size = new Size(138, 40);
            rcreat.TabIndex = 63;
            rcreat.Text = "新建";
            rcreat.UseVisualStyleBackColor = false;
            rcreat.Click += rcreat_Click;
            // 
            // rfdataGridView1
            // 
            rfdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rfdataGridView1.Location = new Point(50, 187);
            rfdataGridView1.Name = "rfdataGridView1";
            rfdataGridView1.RowHeadersWidth = 62;
            rfdataGridView1.Size = new Size(1248, 694);
            rfdataGridView1.TabIndex = 68;
            rfdataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // rcancel
            // 
            rcancel.BackColor = SystemColors.GradientInactiveCaption;
            rcancel.Location = new Point(194, 97);
            rcancel.Name = "rcancel";
            rcancel.Size = new Size(138, 40);
            rcancel.TabIndex = 77;
            rcancel.Text = "取消修改";
            rcancel.UseVisualStyleBackColor = false;
            rcancel.Visible = false;
            rcancel.Click += rcancel_Click;
            // 
            // redit2
            // 
            redit2.BackColor = SystemColors.GradientInactiveCaption;
            redit2.Location = new Point(50, 97);
            redit2.Name = "redit2";
            redit2.Size = new Size(138, 40);
            redit2.TabIndex = 76;
            redit2.Text = "修改完成";
            redit2.UseVisualStyleBackColor = false;
            redit2.Visible = false;
            redit2.Click += redit2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Location = new Point(626, 42);
            button1.Name = "button1";
            button1.Size = new Size(138, 40);
            button1.TabIndex = 78;
            button1.Text = "刷新";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(rcancel);
            Controls.Add(redit2);
            Controls.Add(rfdataGridView1);
            Controls.Add(rsearch);
            Controls.Add(rdelete);
            Controls.Add(redit);
            Controls.Add(rcreat);
            Name = "ReceiptForm";
            Size = new Size(1688, 1136);
            Load += ReceiptForm_Load;
            ((System.ComponentModel.ISupportInitialize)rfdataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button rsearch;
        private Button rdelete;
        private Button redit;
        private Button rcreat;
        private Button rcancel;
        private Button redit2;
        public DataGridView rfdataGridView1;
        private Button button1;
    }
}

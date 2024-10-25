namespace WinFormsApp1.销售管理
{
    partial class ExamineForm
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
            ecreat = new Button();
            exdataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)exdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ecreat
            // 
            ecreat.BackColor = SystemColors.GradientInactiveCaption;
            ecreat.Location = new Point(50, 30);
            ecreat.Name = "ecreat";
            ecreat.Size = new Size(100, 40);
            ecreat.TabIndex = 1;
            ecreat.Text = "审核";
            ecreat.UseVisualStyleBackColor = false;
            ecreat.Click += ecreat_Click;
            // 
            // exdataGridView1
            // 
            exdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            exdataGridView1.Location = new Point(50, 130);
            exdataGridView1.Name = "exdataGridView1";
            exdataGridView1.RowHeadersWidth = 62;
            exdataGridView1.Size = new Size(1550, 940);
            exdataGridView1.TabIndex = 4;
            // 
            // ExamineForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(exdataGridView1);
            Controls.Add(ecreat);
            Name = "ExamineForm";
            Size = new Size(1688, 1136);
            Load += ExamineForm_Load;
            ((System.ComponentModel.ISupportInitialize)exdataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ecreat;
        private DataGridView exdataGridView1;
    }
}

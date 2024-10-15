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
            beizhu4 = new Label();
            beizhu5 = new Label();
            SuspendLayout();
            // 
            // rsearch
            // 
            rsearch.BackColor = SystemColors.GradientInactiveCaption;
            rsearch.Location = new Point(390, 42);
            rsearch.Name = "rsearch";
            rsearch.Size = new Size(100, 40);
            rsearch.TabIndex = 66;
            rsearch.Text = "查询";
            rsearch.UseVisualStyleBackColor = false;
            // 
            // rdelete
            // 
            rdelete.BackColor = SystemColors.GradientInactiveCaption;
            rdelete.Location = new Point(284, 42);
            rdelete.Name = "rdelete";
            rdelete.Size = new Size(100, 40);
            rdelete.TabIndex = 65;
            rdelete.Text = "删除";
            rdelete.UseVisualStyleBackColor = false;
            // 
            // redit
            // 
            redit.BackColor = SystemColors.GradientInactiveCaption;
            redit.Location = new Point(178, 42);
            redit.Name = "redit";
            redit.Size = new Size(100, 40);
            redit.TabIndex = 64;
            redit.Text = "修改";
            redit.UseVisualStyleBackColor = false;
            // 
            // rcreat
            // 
            rcreat.BackColor = SystemColors.GradientInactiveCaption;
            rcreat.Location = new Point(73, 42);
            rcreat.Name = "rcreat";
            rcreat.Size = new Size(100, 40);
            rcreat.TabIndex = 63;
            rcreat.Text = "新建";
            rcreat.UseVisualStyleBackColor = false;
            // 
            // beizhu4
            // 
            beizhu4.AutoSize = true;
            beizhu4.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            beizhu4.Location = new Point(138, 277);
            beizhu4.Name = "beizhu4";
            beizhu4.Size = new Size(353, 37);
            beizhu4.TabIndex = 67;
            beizhu4.Text = "点击收款单后跳转到此页面";
            // 
            // beizhu5
            // 
            beizhu5.AutoSize = true;
            beizhu5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            beizhu5.Location = new Point(356, 369);
            beizhu5.Name = "beizhu5";
            beizhu5.Size = new Size(110, 31);
            beizhu5.TabIndex = 68;
            beizhu5.Text = "待做表格";
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(beizhu5);
            Controls.Add(beizhu4);
            Controls.Add(rsearch);
            Controls.Add(rdelete);
            Controls.Add(redit);
            Controls.Add(rcreat);
            Name = "ReceiptForm";
            Size = new Size(1688, 1136);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rsearch;
        private Button rdelete;
        private Button redit;
        private Button rcreat;
        private Label beizhu4;
        private Label beizhu5;
    }
}

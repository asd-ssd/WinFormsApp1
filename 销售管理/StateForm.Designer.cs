namespace WinFormsApp1.销售管理
{
    partial class StateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateForm));
            lrtj = new Button();
            xltj = new Button();
            khxl = new Button();
            jgbd = new Button();
            SuspendLayout();
            // 
            // lrtj
            // 
            lrtj.BackgroundImage = (Image)resources.GetObject("lrtj.BackgroundImage");
            lrtj.BackgroundImageLayout = ImageLayout.Zoom;
            lrtj.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lrtj.Location = new Point(57, 30);
            lrtj.Name = "lrtj";
            lrtj.Size = new Size(113, 109);
            lrtj.TabIndex = 0;
            lrtj.Text = "销售利润统计";
            lrtj.TextAlign = ContentAlignment.BottomCenter;
            lrtj.UseVisualStyleBackColor = true;
            // 
            // xltj
            // 
            xltj.BackgroundImage = (Image)resources.GetObject("xltj.BackgroundImage");
            xltj.BackgroundImageLayout = ImageLayout.Zoom;
            xltj.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            xltj.Location = new Point(176, 30);
            xltj.Name = "xltj";
            xltj.Size = new Size(113, 109);
            xltj.TabIndex = 1;
            xltj.Text = "产品销量统计";
            xltj.TextAlign = ContentAlignment.BottomCenter;
            xltj.UseVisualStyleBackColor = true;
            // 
            // khxl
            // 
            khxl.BackgroundImage = (Image)resources.GetObject("khxl.BackgroundImage");
            khxl.BackgroundImageLayout = ImageLayout.Zoom;
            khxl.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            khxl.Location = new Point(295, 30);
            khxl.Name = "khxl";
            khxl.Size = new Size(113, 109);
            khxl.TabIndex = 2;
            khxl.Text = "客户销量统计";
            khxl.TextAlign = ContentAlignment.BottomCenter;
            khxl.UseVisualStyleBackColor = true;
            // 
            // jgbd
            // 
            jgbd.BackgroundImage = (Image)resources.GetObject("jgbd.BackgroundImage");
            jgbd.BackgroundImageLayout = ImageLayout.Zoom;
            jgbd.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            jgbd.Location = new Point(414, 30);
            jgbd.Name = "jgbd";
            jgbd.Size = new Size(113, 109);
            jgbd.TabIndex = 3;
            jgbd.Text = "销售价格波动";
            jgbd.TextAlign = ContentAlignment.BottomCenter;
            jgbd.UseVisualStyleBackColor = true;
            // 
            // StateForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(jgbd);
            Controls.Add(khxl);
            Controls.Add(xltj);
            Controls.Add(lrtj);
            Name = "StateForm";
            Size = new Size(1688, 1136);
            ResumeLayout(false);
        }

        #endregion

        private Button lrtj;
        private Button xltj;
        private Button khxl;
        private Button jgbd;
    }
}

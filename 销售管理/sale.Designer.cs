namespace WinFormsApp1
{
    partial class sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sale));
            client = new Button();
            xsdd = new Button();
            sfh = new Button();
            bbfx = new Button();
            xsyc = new Button();
            SuspendLayout();
            // 
            // client
            // 
            client.BackColor = Color.White;
            client.BackgroundImage = (Image)resources.GetObject("client.BackgroundImage");
            client.BackgroundImageLayout = ImageLayout.Zoom;
            client.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            client.Location = new Point(116, 23);
            client.Name = "client";
            client.Size = new Size(80, 105);
            client.TabIndex = 0;
            client.Text = "客户管理";
            client.TextAlign = ContentAlignment.BottomCenter;
            client.UseVisualStyleBackColor = false;
            // 
            // xsdd
            // 
            xsdd.BackgroundImage = (Image)resources.GetObject("xsdd.BackgroundImage");
            xsdd.BackgroundImageLayout = ImageLayout.Zoom;
            xsdd.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            xsdd.Location = new Point(116, 134);
            xsdd.Name = "xsdd";
            xsdd.Size = new Size(80, 105);
            xsdd.TabIndex = 1;
            xsdd.Text = "销售订单";
            xsdd.TextAlign = ContentAlignment.BottomCenter;
            xsdd.UseVisualStyleBackColor = true;
            // 
            // sfh
            // 
            sfh.BackgroundImage = (Image)resources.GetObject("sfh.BackgroundImage");
            sfh.BackgroundImageLayout = ImageLayout.Zoom;
            sfh.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            sfh.Location = new Point(116, 245);
            sfh.Name = "sfh";
            sfh.Size = new Size(80, 105);
            sfh.TabIndex = 2;
            sfh.Text = "收发货";
            sfh.TextAlign = ContentAlignment.BottomCenter;
            sfh.UseVisualStyleBackColor = true;
            // 
            // bbfx
            // 
            bbfx.BackgroundImage = (Image)resources.GetObject("bbfx.BackgroundImage");
            bbfx.BackgroundImageLayout = ImageLayout.Zoom;
            bbfx.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            bbfx.Location = new Point(116, 356);
            bbfx.Name = "bbfx";
            bbfx.Size = new Size(80, 105);
            bbfx.TabIndex = 3;
            bbfx.Text = "报表分析";
            bbfx.TextAlign = ContentAlignment.BottomCenter;
            bbfx.UseVisualStyleBackColor = true;
            // 
            // xsyc
            // 
            xsyc.BackgroundImage = (Image)resources.GetObject("xsyc.BackgroundImage");
            xsyc.BackgroundImageLayout = ImageLayout.Zoom;
            xsyc.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            xsyc.Location = new Point(116, 467);
            xsyc.Name = "xsyc";
            xsyc.Size = new Size(80, 105);
            xsyc.TabIndex = 4;
            xsyc.Text = "销售预测";
            xsyc.TextAlign = ContentAlignment.BottomCenter;
            xsyc.UseVisualStyleBackColor = true;
            // 
            // sale
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(xsyc);
            Controls.Add(bbfx);
            Controls.Add(sfh);
            Controls.Add(xsdd);
            Controls.Add(client);
            Name = "sale";
            Size = new Size(351, 777);
            ResumeLayout(false);
        }

        #endregion

        private Button client;
        private Button xsdd;
        private Button sfh;
        private Button bbfx;
        private Button xsyc;
    }
}

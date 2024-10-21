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
            salelable1 = new Label();
            salelabel4 = new Label();
            salelabel2 = new Label();
            xsskd = new Button();
            salelable3 = new Label();
            tuihuo = new Button();
            xsyc = new Button();
            ddsp = new Button();
            SuspendLayout();
            // 
            // client
            // 
            client.BackColor = Color.White;
            client.BackgroundImage = (Image)resources.GetObject("client.BackgroundImage");
            client.BackgroundImageLayout = ImageLayout.Zoom;
            client.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            client.Location = new Point(17, 68);
            client.Name = "client";
            client.Size = new Size(92, 105);
            client.TabIndex = 0;
            client.Text = "客户资料";
            client.TextAlign = ContentAlignment.BottomCenter;
            client.UseVisualStyleBackColor = false;
            client.Click += client_Click;
            // 
            // xsdd
            // 
            xsdd.BackgroundImage = (Image)resources.GetObject("xsdd.BackgroundImage");
            xsdd.BackgroundImageLayout = ImageLayout.Zoom;
            xsdd.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            xsdd.Location = new Point(17, 234);
            xsdd.Name = "xsdd";
            xsdd.Size = new Size(92, 105);
            xsdd.TabIndex = 1;
            xsdd.Text = "销售订单";
            xsdd.TextAlign = ContentAlignment.BottomCenter;
            xsdd.UseVisualStyleBackColor = true;
            xsdd.Click += xsdd_Click;
            // 
            // sfh
            // 
            sfh.BackgroundImage = (Image)resources.GetObject("sfh.BackgroundImage");
            sfh.BackgroundImageLayout = ImageLayout.Zoom;
            sfh.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            sfh.Location = new Point(17, 395);
            sfh.Name = "sfh";
            sfh.Size = new Size(92, 105);
            sfh.TabIndex = 2;
            sfh.Text = "发货";
            sfh.TextAlign = ContentAlignment.BottomCenter;
            sfh.UseVisualStyleBackColor = true;
            sfh.Click += sfh_Click;
            // 
            // bbfx
            // 
            bbfx.BackgroundImage = (Image)resources.GetObject("bbfx.BackgroundImage");
            bbfx.BackgroundImageLayout = ImageLayout.Zoom;
            bbfx.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            bbfx.Location = new Point(17, 566);
            bbfx.Name = "bbfx";
            bbfx.Size = new Size(92, 105);
            bbfx.TabIndex = 3;
            bbfx.Text = "报表分析";
            bbfx.TextAlign = ContentAlignment.BottomCenter;
            bbfx.UseVisualStyleBackColor = true;
            bbfx.Click += bbfx_Click;
            // 
            // salelable1
            // 
            salelable1.AutoSize = true;
            salelable1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            salelable1.ForeColor = SystemColors.HotTrack;
            salelable1.Location = new Point(17, 27);
            salelable1.Name = "salelable1";
            salelable1.Size = new Size(96, 28);
            salelable1.TabIndex = 4;
            salelable1.Text = "客户管理";
            // 
            // salelabel4
            // 
            salelabel4.AutoSize = true;
            salelabel4.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            salelabel4.ForeColor = SystemColors.HotTrack;
            salelabel4.Location = new Point(17, 524);
            salelabel4.Name = "salelabel4";
            salelabel4.Size = new Size(96, 28);
            salelabel4.TabIndex = 5;
            salelabel4.Text = "报表中心";
            // 
            // salelabel2
            // 
            salelabel2.AutoSize = true;
            salelabel2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            salelabel2.ForeColor = SystemColors.HotTrack;
            salelabel2.Location = new Point(17, 192);
            salelabel2.Name = "salelabel2";
            salelabel2.Size = new Size(138, 28);
            salelabel2.TabIndex = 6;
            salelabel2.Text = "销售订单管理";
            // 
            // xsskd
            // 
            xsskd.BackgroundImage = (Image)resources.GetObject("xsskd.BackgroundImage");
            xsskd.BackgroundImageLayout = ImageLayout.Zoom;
            xsskd.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            xsskd.Location = new Point(214, 234);
            xsskd.Name = "xsskd";
            xsskd.Size = new Size(93, 105);
            xsskd.TabIndex = 8;
            xsskd.Text = "销售收款单";
            xsskd.TextAlign = ContentAlignment.BottomLeft;
            xsskd.UseVisualStyleBackColor = true;
            xsskd.UseWaitCursor = true;
            xsskd.Click += xsskd_Click;
            // 
            // salelable3
            // 
            salelable3.AutoSize = true;
            salelable3.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            salelable3.ForeColor = SystemColors.HotTrack;
            salelable3.Location = new Point(17, 352);
            salelable3.Name = "salelable3";
            salelable3.Size = new Size(117, 28);
            salelable3.TabIndex = 9;
            salelable3.Text = "收发货管理";
            // 
            // tuihuo
            // 
            tuihuo.BackgroundImage = (Image)resources.GetObject("tuihuo.BackgroundImage");
            tuihuo.BackgroundImageLayout = ImageLayout.Zoom;
            tuihuo.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tuihuo.Location = new Point(116, 395);
            tuihuo.Name = "tuihuo";
            tuihuo.Size = new Size(92, 105);
            tuihuo.TabIndex = 10;
            tuihuo.Text = "退货";
            tuihuo.TextAlign = ContentAlignment.BottomCenter;
            tuihuo.UseVisualStyleBackColor = true;
            // 
            // xsyc
            // 
            xsyc.BackgroundImage = (Image)resources.GetObject("xsyc.BackgroundImage");
            xsyc.BackgroundImageLayout = ImageLayout.Zoom;
            xsyc.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            xsyc.Location = new Point(116, 566);
            xsyc.Name = "xsyc";
            xsyc.Size = new Size(92, 105);
            xsyc.TabIndex = 11;
            xsyc.Text = "销售预测";
            xsyc.TextAlign = ContentAlignment.BottomCenter;
            xsyc.UseVisualStyleBackColor = true;
            // 
            // ddsp
            // 
            ddsp.BackgroundImage = (Image)resources.GetObject("ddsp.BackgroundImage");
            ddsp.BackgroundImageLayout = ImageLayout.Zoom;
            ddsp.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ddsp.Location = new Point(115, 234);
            ddsp.Name = "ddsp";
            ddsp.Size = new Size(93, 105);
            ddsp.TabIndex = 12;
            ddsp.Text = "订单审批";
            ddsp.TextAlign = ContentAlignment.BottomCenter;
            ddsp.UseVisualStyleBackColor = true;
            ddsp.UseWaitCursor = true;
            // 
            // sale
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(ddsp);
            Controls.Add(xsyc);
            Controls.Add(tuihuo);
            Controls.Add(salelable3);
            Controls.Add(xsskd);
            Controls.Add(salelabel2);
            Controls.Add(salelabel4);
            Controls.Add(salelable1);
            Controls.Add(bbfx);
            Controls.Add(sfh);
            Controls.Add(xsdd);
            Controls.Add(client);
            Name = "sale";
            Size = new Size(351, 777);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button client;
        private Button xsdd;
        private Button sfh;
        private Button bbfx;
        private Label salelable1;
        private Label salelabel4;
        private Label salelabel2;
        private Button xsskd;
        private Label salelable3;
        private Button tuihuo;
        private Button xsyc;
        private Button ddsp;
    }
}

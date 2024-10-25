namespace WinFormsApp1.销售管理
{
    partial class SaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            saleddsp = new Button();
            saletuihuo = new Button();
            saleformlable3 = new Label();
            salexsskd = new Button();
            saleformlabel2 = new Label();
            saleformlabel4 = new Label();
            saleformlable1 = new Label();
            salekehu = new Button();
            salefh = new Button();
            salexsdd = new Button();
            saleclient = new Button();
            salelirun = new Button();
            salechanpin = new Button();
            SuspendLayout();
            // 
            // saleddsp
            // 
            saleddsp.BackgroundImage = (Image)resources.GetObject("saleddsp.BackgroundImage");
            saleddsp.BackgroundImageLayout = ImageLayout.Zoom;
            saleddsp.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            saleddsp.Location = new Point(125, 235);
            saleddsp.Name = "saleddsp";
            saleddsp.Size = new Size(93, 105);
            saleddsp.TabIndex = 24;
            saleddsp.Text = "订单审批";
            saleddsp.TextAlign = ContentAlignment.BottomCenter;
            saleddsp.UseVisualStyleBackColor = true;
            saleddsp.UseWaitCursor = true;
            saleddsp.Click += saleddsp_Click;
            // 
            // saletuihuo
            // 
            saletuihuo.BackgroundImage = (Image)resources.GetObject("saletuihuo.BackgroundImage");
            saletuihuo.BackgroundImageLayout = ImageLayout.Zoom;
            saletuihuo.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            saletuihuo.Location = new Point(126, 396);
            saletuihuo.Name = "saletuihuo";
            saletuihuo.Size = new Size(92, 105);
            saletuihuo.TabIndex = 22;
            saletuihuo.Text = "退货";
            saletuihuo.TextAlign = ContentAlignment.BottomCenter;
            saletuihuo.UseVisualStyleBackColor = true;
            saletuihuo.Click += saletuihuo_Click;
            // 
            // saleformlable3
            // 
            saleformlable3.AutoSize = true;
            saleformlable3.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            saleformlable3.ForeColor = SystemColors.HotTrack;
            saleformlable3.Location = new Point(27, 353);
            saleformlable3.Name = "saleformlable3";
            saleformlable3.Size = new Size(117, 28);
            saleformlable3.TabIndex = 21;
            saleformlable3.Text = "收发货管理";
            // 
            // salexsskd
            // 
            salexsskd.BackgroundImage = (Image)resources.GetObject("salexsskd.BackgroundImage");
            salexsskd.BackgroundImageLayout = ImageLayout.Zoom;
            salexsskd.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            salexsskd.Location = new Point(224, 235);
            salexsskd.Name = "salexsskd";
            salexsskd.Size = new Size(93, 105);
            salexsskd.TabIndex = 20;
            salexsskd.Text = "销售收款单";
            salexsskd.TextAlign = ContentAlignment.BottomLeft;
            salexsskd.UseVisualStyleBackColor = true;
            salexsskd.UseWaitCursor = true;
            salexsskd.Click += salexsskd_Click_1;
            // 
            // saleformlabel2
            // 
            saleformlabel2.AutoSize = true;
            saleformlabel2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            saleformlabel2.ForeColor = SystemColors.HotTrack;
            saleformlabel2.Location = new Point(27, 193);
            saleformlabel2.Name = "saleformlabel2";
            saleformlabel2.Size = new Size(138, 28);
            saleformlabel2.TabIndex = 19;
            saleformlabel2.Text = "销售订单管理";
            // 
            // saleformlabel4
            // 
            saleformlabel4.AutoSize = true;
            saleformlabel4.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            saleformlabel4.ForeColor = SystemColors.HotTrack;
            saleformlabel4.Location = new Point(27, 525);
            saleformlabel4.Name = "saleformlabel4";
            saleformlabel4.Size = new Size(96, 28);
            saleformlabel4.TabIndex = 18;
            saleformlabel4.Text = "报表分析";
            // 
            // saleformlable1
            // 
            saleformlable1.AutoSize = true;
            saleformlable1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            saleformlable1.ForeColor = SystemColors.HotTrack;
            saleformlable1.Location = new Point(27, 28);
            saleformlable1.Name = "saleformlable1";
            saleformlable1.Size = new Size(96, 28);
            saleformlable1.TabIndex = 17;
            saleformlable1.Text = "客户管理";
            // 
            // salekehu
            // 
            salekehu.BackgroundImage = (Image)resources.GetObject("salekehu.BackgroundImage");
            salekehu.BackgroundImageLayout = ImageLayout.Zoom;
            salekehu.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            salekehu.Location = new Point(126, 566);
            salekehu.Name = "salekehu";
            salekehu.Size = new Size(92, 105);
            salekehu.TabIndex = 16;
            salekehu.Text = "客户销量";
            salekehu.TextAlign = ContentAlignment.BottomCenter;
            salekehu.UseVisualStyleBackColor = true;
            salekehu.Click += salekehu_Click;
            // 
            // salefh
            // 
            salefh.BackgroundImage = (Image)resources.GetObject("salefh.BackgroundImage");
            salefh.BackgroundImageLayout = ImageLayout.Zoom;
            salefh.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            salefh.Location = new Point(27, 396);
            salefh.Name = "salefh";
            salefh.Size = new Size(92, 105);
            salefh.TabIndex = 15;
            salefh.Text = "发货";
            salefh.TextAlign = ContentAlignment.BottomCenter;
            salefh.UseVisualStyleBackColor = true;
            salefh.Click += salefh_Click;
            // 
            // salexsdd
            // 
            salexsdd.BackgroundImage = (Image)resources.GetObject("salexsdd.BackgroundImage");
            salexsdd.BackgroundImageLayout = ImageLayout.Zoom;
            salexsdd.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            salexsdd.Location = new Point(27, 235);
            salexsdd.Name = "salexsdd";
            salexsdd.Size = new Size(92, 105);
            salexsdd.TabIndex = 14;
            salexsdd.Text = "销售订单";
            salexsdd.TextAlign = ContentAlignment.BottomCenter;
            salexsdd.UseVisualStyleBackColor = true;
            salexsdd.Click += salexsdd_Click;
            // 
            // saleclient
            // 
            saleclient.BackColor = Color.White;
            saleclient.BackgroundImage = (Image)resources.GetObject("saleclient.BackgroundImage");
            saleclient.BackgroundImageLayout = ImageLayout.Zoom;
            saleclient.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            saleclient.Location = new Point(27, 69);
            saleclient.Name = "saleclient";
            saleclient.Size = new Size(92, 105);
            saleclient.TabIndex = 13;
            saleclient.Text = "客户资料";
            saleclient.TextAlign = ContentAlignment.BottomCenter;
            saleclient.UseVisualStyleBackColor = false;
            saleclient.Click += saleclient_Click;
            // 
            // salelirun
            // 
            salelirun.BackgroundImage = (Image)resources.GetObject("salelirun.BackgroundImage");
            salelirun.BackgroundImageLayout = ImageLayout.Zoom;
            salelirun.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            salelirun.Location = new Point(27, 567);
            salelirun.Name = "salelirun";
            salelirun.Size = new Size(92, 105);
            salelirun.TabIndex = 25;
            salelirun.Text = "销售利润";
            salelirun.TextAlign = ContentAlignment.BottomCenter;
            salelirun.UseVisualStyleBackColor = true;
            salelirun.Click += salelirun_Click;
            // 
            // salechanpin
            // 
            salechanpin.BackgroundImage = (Image)resources.GetObject("salechanpin.BackgroundImage");
            salechanpin.BackgroundImageLayout = ImageLayout.Zoom;
            salechanpin.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            salechanpin.Location = new Point(225, 568);
            salechanpin.Name = "salechanpin";
            salechanpin.Size = new Size(92, 104);
            salechanpin.TabIndex = 26;
            salechanpin.Text = "产品销量";
            salechanpin.TextAlign = ContentAlignment.BottomCenter;
            salechanpin.UseVisualStyleBackColor = true;
            salechanpin.Click += salechanpin_Click;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(salechanpin);
            Controls.Add(salelirun);
            Controls.Add(saleddsp);
            Controls.Add(saletuihuo);
            Controls.Add(saleformlable3);
            Controls.Add(salexsskd);
            Controls.Add(saleformlabel2);
            Controls.Add(saleformlabel4);
            Controls.Add(saleformlable1);
            Controls.Add(salekehu);
            Controls.Add(salefh);
            Controls.Add(salexsdd);
            Controls.Add(saleclient);
            Name = "SaleForm";
            Size = new Size(351, 777);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saleddsp;
        private Button saletuihuo;
        private Label saleformlable3;
        private Button salexsskd;
        private Label saleformlabel2;
        private Label saleformlabel4;
        private Label saleformlable1;
        private Button salekehu;
        private Button salefh;
        private Button salexsdd;
        private Button saleclient;
        private Button salelirun;
        private Button salechanpin;
    }
}

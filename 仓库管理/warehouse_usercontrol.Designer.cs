namespace WinFormsApp1
{
    partial class warehouse_usercontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(warehouse_usercontrol));
            warehouse_in = new Button();
            warehouse_move = new Button();
            warehouse_edit = new Button();
            warehouse_inquiry = new Button();
            warehouse_out = new Button();
            saleformlable1 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // warehouse_in
            // 
            warehouse_in.BackgroundImage = (Image)resources.GetObject("warehouse_in.BackgroundImage");
            warehouse_in.BackgroundImageLayout = ImageLayout.Zoom;
            warehouse_in.Font = new Font("宋体", 7.5F);
            warehouse_in.Location = new Point(3, 419);
            warehouse_in.Name = "warehouse_in";
            warehouse_in.Size = new Size(80, 105);
            warehouse_in.TabIndex = 2;
            warehouse_in.Text = "物料入库";
            warehouse_in.TextAlign = ContentAlignment.BottomCenter;
            warehouse_in.UseVisualStyleBackColor = true;
            warehouse_in.Click += warehouse_in_Click;
            // 
            // warehouse_move
            // 
            warehouse_move.BackgroundImage = (Image)resources.GetObject("warehouse_move.BackgroundImage");
            warehouse_move.BackgroundImageLayout = ImageLayout.Zoom;
            warehouse_move.Font = new Font("宋体", 7.5F);
            warehouse_move.Location = new Point(203, 419);
            warehouse_move.Name = "warehouse_move";
            warehouse_move.Size = new Size(80, 105);
            warehouse_move.TabIndex = 4;
            warehouse_move.Text = "物料移库";
            warehouse_move.TextAlign = ContentAlignment.BottomCenter;
            warehouse_move.UseVisualStyleBackColor = true;
            warehouse_move.Click += warehouse_move_Click;
            // 
            // warehouse_edit
            // 
            warehouse_edit.BackgroundImage = (Image)resources.GetObject("warehouse_edit.BackgroundImage");
            warehouse_edit.BackgroundImageLayout = ImageLayout.Zoom;
            warehouse_edit.Font = new Font("宋体", 7.5F);
            warehouse_edit.Location = new Point(3, 221);
            warehouse_edit.Name = "warehouse_edit";
            warehouse_edit.Size = new Size(80, 105);
            warehouse_edit.TabIndex = 5;
            warehouse_edit.Text = "库存盘点";
            warehouse_edit.TextAlign = ContentAlignment.BottomCenter;
            warehouse_edit.UseVisualStyleBackColor = true;
            warehouse_edit.Click += warehouse_edit_Click;
            // 
            // warehouse_inquiry
            // 
            warehouse_inquiry.BackgroundImage = Properties.Resource1.Receiving_goods_query;
            warehouse_inquiry.BackgroundImageLayout = ImageLayout.Zoom;
            warehouse_inquiry.Font = new Font("宋体", 7.5F);
            warehouse_inquiry.Location = new Point(3, 37);
            warehouse_inquiry.Name = "warehouse_inquiry";
            warehouse_inquiry.Size = new Size(80, 105);
            warehouse_inquiry.TabIndex = 0;
            warehouse_inquiry.Text = "查询与维护";
            warehouse_inquiry.TextAlign = ContentAlignment.BottomCenter;
            warehouse_inquiry.UseVisualStyleBackColor = true;
            warehouse_inquiry.Click += warehouse_inquiry_Click_1;
            // 
            // warehouse_out
            // 
            warehouse_out.BackgroundImage = (Image)resources.GetObject("warehouse_out.BackgroundImage");
            warehouse_out.BackgroundImageLayout = ImageLayout.Zoom;
            warehouse_out.Font = new Font("宋体", 7.5F);
            warehouse_out.Location = new Point(101, 419);
            warehouse_out.Name = "warehouse_out";
            warehouse_out.Size = new Size(80, 105);
            warehouse_out.TabIndex = 3;
            warehouse_out.Text = "物料出库";
            warehouse_out.TextAlign = ContentAlignment.BottomCenter;
            warehouse_out.UseVisualStyleBackColor = true;
            warehouse_out.Click += warehouse_out_Click;
            // 
            // saleformlable1
            // 
            saleformlable1.AutoSize = true;
            saleformlable1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            saleformlable1.ForeColor = SystemColors.Desktop;
            saleformlable1.Location = new Point(3, 0);
            saleformlable1.Margin = new Padding(2, 0, 2, 0);
            saleformlable1.Name = "saleformlable1";
            saleformlable1.Size = new Size(84, 25);
            saleformlable1.TabIndex = 18;
            saleformlable1.Text = "库存维护";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(-1, 180);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 19;
            label1.Text = "库存盘点";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(3, 381);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 21;
            label3.Text = "库存操作";
            // 
            // warehouse_usercontrol
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(saleformlable1);
            Controls.Add(warehouse_move);
            Controls.Add(warehouse_in);
            Controls.Add(warehouse_out);
            Controls.Add(warehouse_inquiry);
            Controls.Add(warehouse_edit);
            Name = "warehouse_usercontrol";
            Size = new Size(436, 777);
            Load += warehouse_usercontrol_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button warehouse_in;
        private Button warehouse_move;
        private Button warehouse_edit;
        private Button warehouse_inquiry;
        private Button warehouse_out;
        private Label saleformlable1;
        private Label label1;
        private Label label3;
    }
}

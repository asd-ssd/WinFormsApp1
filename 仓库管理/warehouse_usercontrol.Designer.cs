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
            warehouse_move = new Button();
            warehouse_in = new Button();
            warehouse_edit = new Button();
            warehouse_out = new Button();
            warehouse_inquiry = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // warehouse_move
            // 
            warehouse_move.BackgroundImage = (Image)resources.GetObject("warehouse_move.BackgroundImage");
            warehouse_move.BackgroundImageLayout = ImageLayout.Zoom;
            warehouse_move.Location = new Point(4, 636);
            warehouse_move.Margin = new Padding(4, 4, 4, 4);
            warehouse_move.Name = "warehouse_move";
            warehouse_move.Size = new Size(98, 126);
            warehouse_move.TabIndex = 4;
            warehouse_move.Text = "物料移库";
            warehouse_move.TextAlign = ContentAlignment.BottomCenter;
            warehouse_move.UseVisualStyleBackColor = true;
            // 
            // warehouse_in
            // 
            warehouse_in.BackgroundImage = (Image)resources.GetObject("warehouse_in.BackgroundImage");
            warehouse_in.BackgroundImageLayout = ImageLayout.Zoom;
            warehouse_in.Location = new Point(4, 320);
            warehouse_in.Margin = new Padding(4, 4, 4, 4);
            warehouse_in.Name = "warehouse_in";
            warehouse_in.Size = new Size(98, 126);
            warehouse_in.TabIndex = 2;
            warehouse_in.Text = "物料入库";
            warehouse_in.TextAlign = ContentAlignment.BottomCenter;
            warehouse_in.UseVisualStyleBackColor = true;
            // 
            // warehouse_edit
            // 
            warehouse_edit.BackgroundImage = (Image)resources.GetObject("warehouse_edit.BackgroundImage");
            warehouse_edit.BackgroundImageLayout = ImageLayout.Zoom;
            warehouse_edit.Location = new Point(4, 162);
            warehouse_edit.Margin = new Padding(4, 4, 4, 4);
            warehouse_edit.Name = "warehouse_edit";
            warehouse_edit.Size = new Size(98, 126);
            warehouse_edit.TabIndex = 5;
            warehouse_edit.Text = "仓库维护";
            warehouse_edit.TextAlign = ContentAlignment.BottomCenter;
            warehouse_edit.UseVisualStyleBackColor = true;
            // 
            // warehouse_out
            // 
            warehouse_out.BackgroundImage = (Image)resources.GetObject("warehouse_out.BackgroundImage");
            warehouse_out.BackgroundImageLayout = ImageLayout.Zoom;
            warehouse_out.Location = new Point(4, 478);
            warehouse_out.Margin = new Padding(4, 4, 4, 4);
            warehouse_out.Name = "warehouse_out";
            warehouse_out.Size = new Size(98, 126);
            warehouse_out.TabIndex = 3;
            warehouse_out.Text = "物料出库";
            warehouse_out.TextAlign = ContentAlignment.BottomCenter;
            warehouse_out.UseVisualStyleBackColor = true;
            // 
            // warehouse_inquiry
            // 
            warehouse_inquiry.BackgroundImage = Properties.Resource1.Receiving_goods_query;
            warehouse_inquiry.BackgroundImageLayout = ImageLayout.Zoom;
            warehouse_inquiry.Location = new Point(4, 4);
            warehouse_inquiry.Margin = new Padding(4, 4, 4, 4);
            warehouse_inquiry.Name = "warehouse_inquiry";
            warehouse_inquiry.Size = new Size(98, 126);
            warehouse_inquiry.TabIndex = 0;
            warehouse_inquiry.Text = "库存查询";
            warehouse_inquiry.TextAlign = ContentAlignment.BottomCenter;
            warehouse_inquiry.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(warehouse_in, 0, 2);
            tableLayoutPanel1.Controls.Add(warehouse_move, 0, 4);
            tableLayoutPanel1.Controls.Add(warehouse_edit, 0, 1);
            tableLayoutPanel1.Controls.Add(warehouse_inquiry, 0, 0);
            tableLayoutPanel1.Controls.Add(warehouse_out, 0, 3);
            tableLayoutPanel1.ForeColor = SystemColors.ControlText;
            tableLayoutPanel1.Location = new Point(153, 60);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(110, 790);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // warehouse_usercontrol
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "warehouse_usercontrol";
            Size = new Size(429, 932);
            Load += warehouse_usercontrol_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button warehouse_move;
        private Button warehouse_in;
        private Button warehouse_edit;
        private Button warehouse_out;
        private Button warehouse_inquiry;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

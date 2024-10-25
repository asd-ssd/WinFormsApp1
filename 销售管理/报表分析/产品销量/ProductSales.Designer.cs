namespace WinFormsApp1.销售管理.报表分析.产品销量
{
    partial class ProductSales
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
            productsalesGridView1 = new DataGridView();
            productsalesbutton1 = new Button();
            productsalesTimePicker2 = new DateTimePicker();
            productsalesTimePicker1 = new DateTimePicker();
            productsaleslabel3 = new Label();
            productsaleslabel2 = new Label();
            productsaleslabel1 = new Label();
            ((System.ComponentModel.ISupportInitialize)productsalesGridView1).BeginInit();
            SuspendLayout();
            // 
            // productsalesGridView1
            // 
            productsalesGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsalesGridView1.Location = new Point(50, 130);
            productsalesGridView1.Name = "productsalesGridView1";
            productsalesGridView1.RowHeadersWidth = 62;
            productsalesGridView1.Size = new Size(1550, 940);
            productsalesGridView1.TabIndex = 20;
            // 
            // productsalesbutton1
            // 
            productsalesbutton1.Location = new Point(962, 58);
            productsalesbutton1.Name = "productsalesbutton1";
            productsalesbutton1.Size = new Size(112, 34);
            productsalesbutton1.TabIndex = 19;
            productsalesbutton1.Text = "查询";
            productsalesbutton1.UseVisualStyleBackColor = true;
            // 
            // productsalesTimePicker2
            // 
            productsalesTimePicker2.Location = new Point(628, 58);
            productsalesTimePicker2.Name = "productsalesTimePicker2";
            productsalesTimePicker2.Size = new Size(300, 30);
            productsalesTimePicker2.TabIndex = 18;
            // 
            // productsalesTimePicker1
            // 
            productsalesTimePicker1.Location = new Point(253, 58);
            productsalesTimePicker1.Name = "productsalesTimePicker1";
            productsalesTimePicker1.Size = new Size(300, 30);
            productsalesTimePicker1.TabIndex = 17;
            // 
            // productsaleslabel3
            // 
            productsaleslabel3.AutoSize = true;
            productsaleslabel3.Location = new Point(586, 58);
            productsaleslabel3.Name = "productsaleslabel3";
            productsaleslabel3.Size = new Size(28, 24);
            productsaleslabel3.TabIndex = 16;
            productsaleslabel3.Text = "至";
            // 
            // productsaleslabel2
            // 
            productsaleslabel2.AutoSize = true;
            productsaleslabel2.Location = new Point(219, 56);
            productsaleslabel2.Name = "productsaleslabel2";
            productsaleslabel2.Size = new Size(28, 24);
            productsaleslabel2.TabIndex = 15;
            productsaleslabel2.Text = "从";
            // 
            // productsaleslabel1
            // 
            productsaleslabel1.AutoSize = true;
            productsaleslabel1.Location = new Point(135, 56);
            productsaleslabel1.Name = "productsaleslabel1";
            productsaleslabel1.Size = new Size(46, 24);
            productsaleslabel1.TabIndex = 14;
            productsaleslabel1.Text = "日期";
            // 
            // ProductSales
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(productsalesGridView1);
            Controls.Add(productsalesbutton1);
            Controls.Add(productsalesTimePicker2);
            Controls.Add(productsalesTimePicker1);
            Controls.Add(productsaleslabel3);
            Controls.Add(productsaleslabel2);
            Controls.Add(productsaleslabel1);
            Name = "ProductSales";
            Size = new Size(1688, 1136);
            ((System.ComponentModel.ISupportInitialize)productsalesGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productsalesGridView1;
        private Button productsalesbutton1;
        private DateTimePicker productsalesTimePicker2;
        private DateTimePicker productsalesTimePicker1;
        private Label productsaleslabel3;
        private Label productsaleslabel2;
        private Label productsaleslabel1;
    }
}

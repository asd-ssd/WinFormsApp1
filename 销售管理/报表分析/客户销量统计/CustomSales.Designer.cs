namespace WinFormsApp1.销售管理.报表分析.客户销量统计
{
    partial class CustomSales
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
            clientsalesGridView1 = new DataGridView();
            clientsalesbutton1 = new Button();
            clientsalesTimePicker2 = new DateTimePicker();
            clientsalesTimePicker1 = new DateTimePicker();
            clientsaleslabel3 = new Label();
            clientsaleslabel2 = new Label();
            clientsaleslabel1 = new Label();
            ((System.ComponentModel.ISupportInitialize)clientsalesGridView1).BeginInit();
            SuspendLayout();
            // 
            // clientsalesGridView1
            // 
            clientsalesGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsalesGridView1.Location = new Point(50, 130);
            clientsalesGridView1.Name = "clientsalesGridView1";
            clientsalesGridView1.RowHeadersWidth = 62;
            clientsalesGridView1.Size = new Size(1550, 940);
            clientsalesGridView1.TabIndex = 13;
            // 
            // clientsalesbutton1
            // 
            clientsalesbutton1.Location = new Point(943, 48);
            clientsalesbutton1.Name = "clientsalesbutton1";
            clientsalesbutton1.Size = new Size(112, 34);
            clientsalesbutton1.TabIndex = 12;
            clientsalesbutton1.Text = "查询";
            clientsalesbutton1.UseVisualStyleBackColor = true;
            // 
            // clientsalesTimePicker2
            // 
            clientsalesTimePicker2.Location = new Point(609, 48);
            clientsalesTimePicker2.Name = "clientsalesTimePicker2";
            clientsalesTimePicker2.Size = new Size(300, 30);
            clientsalesTimePicker2.TabIndex = 11;
            // 
            // clientsalesTimePicker1
            // 
            clientsalesTimePicker1.Location = new Point(234, 48);
            clientsalesTimePicker1.Name = "clientsalesTimePicker1";
            clientsalesTimePicker1.Size = new Size(300, 30);
            clientsalesTimePicker1.TabIndex = 10;
            // 
            // clientsaleslabel3
            // 
            clientsaleslabel3.AutoSize = true;
            clientsaleslabel3.Location = new Point(567, 48);
            clientsaleslabel3.Name = "clientsaleslabel3";
            clientsaleslabel3.Size = new Size(28, 24);
            clientsaleslabel3.TabIndex = 9;
            clientsaleslabel3.Text = "至";
            // 
            // clientsaleslabel2
            // 
            clientsaleslabel2.AutoSize = true;
            clientsaleslabel2.Location = new Point(200, 46);
            clientsaleslabel2.Name = "clientsaleslabel2";
            clientsaleslabel2.Size = new Size(28, 24);
            clientsaleslabel2.TabIndex = 8;
            clientsaleslabel2.Text = "从";
            // 
            // clientsaleslabel1
            // 
            clientsaleslabel1.AutoSize = true;
            clientsaleslabel1.Location = new Point(116, 46);
            clientsaleslabel1.Name = "clientsaleslabel1";
            clientsaleslabel1.Size = new Size(46, 24);
            clientsaleslabel1.TabIndex = 7;
            clientsaleslabel1.Text = "日期";
            // 
            // CustomSales
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clientsalesGridView1);
            Controls.Add(clientsalesbutton1);
            Controls.Add(clientsalesTimePicker2);
            Controls.Add(clientsalesTimePicker1);
            Controls.Add(clientsaleslabel3);
            Controls.Add(clientsaleslabel2);
            Controls.Add(clientsaleslabel1);
            Name = "CustomSales";
            Size = new Size(1688, 1136);
            ((System.ComponentModel.ISupportInitialize)clientsalesGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView clientsalesGridView1;
        private Button clientsalesbutton1;
        private DateTimePicker clientsalesTimePicker2;
        private DateTimePicker clientsalesTimePicker1;
        private Label clientsaleslabel3;
        private Label clientsaleslabel2;
        private Label clientsaleslabel1;
    }
}

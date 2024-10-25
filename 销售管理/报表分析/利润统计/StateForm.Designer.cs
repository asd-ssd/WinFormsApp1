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
            profitlabel1 = new Label();
            profitlabel2 = new Label();
            profitlabel3 = new Label();
            profitdateTimePicker1 = new DateTimePicker();
            profitdateTimePicker2 = new DateTimePicker();
            profitbutton1 = new Button();
            profitdataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)profitdataGridView1).BeginInit();
            SuspendLayout();
            // 
            // profitlabel1
            // 
            profitlabel1.AutoSize = true;
            profitlabel1.Location = new Point(122, 75);
            profitlabel1.Name = "profitlabel1";
            profitlabel1.Size = new Size(46, 24);
            profitlabel1.TabIndex = 0;
            profitlabel1.Text = "日期";
            // 
            // profitlabel2
            // 
            profitlabel2.AutoSize = true;
            profitlabel2.Location = new Point(206, 75);
            profitlabel2.Name = "profitlabel2";
            profitlabel2.Size = new Size(28, 24);
            profitlabel2.TabIndex = 1;
            profitlabel2.Text = "从";
            // 
            // profitlabel3
            // 
            profitlabel3.AutoSize = true;
            profitlabel3.Location = new Point(573, 77);
            profitlabel3.Name = "profitlabel3";
            profitlabel3.Size = new Size(28, 24);
            profitlabel3.TabIndex = 2;
            profitlabel3.Text = "至";
            // 
            // profitdateTimePicker1
            // 
            profitdateTimePicker1.Location = new Point(240, 77);
            profitdateTimePicker1.Name = "profitdateTimePicker1";
            profitdateTimePicker1.Size = new Size(300, 30);
            profitdateTimePicker1.TabIndex = 3;
            // 
            // profitdateTimePicker2
            // 
            profitdateTimePicker2.Location = new Point(615, 77);
            profitdateTimePicker2.Name = "profitdateTimePicker2";
            profitdateTimePicker2.Size = new Size(300, 30);
            profitdateTimePicker2.TabIndex = 4;
            // 
            // profitbutton1
            // 
            profitbutton1.Location = new Point(949, 77);
            profitbutton1.Name = "profitbutton1";
            profitbutton1.Size = new Size(112, 34);
            profitbutton1.TabIndex = 5;
            profitbutton1.Text = "查询";
            profitbutton1.UseVisualStyleBackColor = true;
            // 
            // profitdataGridView1
            // 
            profitdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            profitdataGridView1.Location = new Point(50, 130);
            profitdataGridView1.Name = "profitdataGridView1";
            profitdataGridView1.RowHeadersWidth = 62;
            profitdataGridView1.Size = new Size(1550, 940);
            profitdataGridView1.TabIndex = 6;
            // 
            // StateForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(profitdataGridView1);
            Controls.Add(profitbutton1);
            Controls.Add(profitdateTimePicker2);
            Controls.Add(profitdateTimePicker1);
            Controls.Add(profitlabel3);
            Controls.Add(profitlabel2);
            Controls.Add(profitlabel1);
            Name = "StateForm";
            Size = new Size(1688, 1136);
            ((System.ComponentModel.ISupportInitialize)profitdataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label profitlabel1;
        private Label profitlabel2;
        private Label profitlabel3;
        private DateTimePicker profitdateTimePicker1;
        private DateTimePicker profitdateTimePicker2;
        private Button profitbutton1;
        private DataGridView profitdataGridView1;
    }
}

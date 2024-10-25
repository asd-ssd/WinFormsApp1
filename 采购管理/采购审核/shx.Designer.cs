using System.Windows.Forms;

namespace WinFormsApp1.采购管理.采购审核
{
    partial class shx
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
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(240, 3);
            button4.Name = "button4";
            button4.Size = new Size(112, 92);
            button4.TabIndex = 45;
            button4.Text = "保存";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 92);
            button2.TabIndex = 43;
            button2.Text = "查询";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(122, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 92);
            button1.TabIndex = 42;
            button1.Text = "审核";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 101);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1222, 494);
            dataGridView2.TabIndex = 47;
            dataGridView2.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // shx
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "shx";
            Size = new Size(1222, 720);
            Load += shx_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button2;
        private Button button1;
        public DataGridView dataGridView2;
    }
}

namespace WinFormsApp1
{
    partial class caigou2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caigou2));
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button6.Location = new Point(107, 584);
            button6.Name = "button6";
            button6.Size = new Size(124, 139);
            button6.TabIndex = 13;
            button6.Text = "供应商";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button3.Location = new Point(107, 408);
            button3.Name = "button3";
            button3.Size = new Size(124, 139);
            button3.TabIndex = 11;
            button3.Text = "退货";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(107, 56);
            button2.Name = "button2";
            button2.Size = new Size(124, 139);
            button2.TabIndex = 10;
            button2.Text = "采购";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(107, 232);
            button1.Name = "button1";
            button1.Size = new Size(124, 139);
            button1.TabIndex = 15;
            button1.Text = "采购审核";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // caigou2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "caigou2";
            Size = new Size(351, 777);
            Load += caigou2_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}

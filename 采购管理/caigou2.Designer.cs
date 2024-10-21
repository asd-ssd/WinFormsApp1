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
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Font = new Font("宋体", 7.5F);
            button7.Location = new Point(134, 560);
            button7.Name = "button7";
            button7.Size = new Size(80, 105);
            button7.TabIndex = 14;
            button7.Text = "订单查询";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Font = new Font("宋体", 7.5F);
            button6.Location = new Point(134, 449);
            button6.Name = "button6";
            button6.Size = new Size(80, 105);
            button6.TabIndex = 13;
            button6.Text = "供应商";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Font = new Font("宋体", 7.5F);
            button5.Location = new Point(134, 338);
            button5.Name = "button5";
            button5.Size = new Size(80, 105);
            button5.TabIndex = 12;
            button5.Text = "采购接收";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Font = new Font("宋体", 7.5F);
            button3.Location = new Point(134, 227);
            button3.Name = "button3";
            button3.Size = new Size(80, 105);
            button3.TabIndex = 11;
            button3.Text = "退货";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Font = new Font("宋体", 7.5F);
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(134, 116);
            button2.Name = "button2";
            button2.Size = new Size(80, 105);
            button2.TabIndex = 10;
            button2.Text = "采购";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // caigou2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "caigou2";
            Size = new Size(351, 777);
            ResumeLayout(false);
        }

        #endregion
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button2;
    }
}

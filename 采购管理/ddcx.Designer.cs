namespace WinFormsApp1.采购管理
{
    partial class ddcx
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(67, 45);
            label1.Name = "label1";
            label1.Size = new Size(84, 26);
            label1.TabIndex = 0;
            label1.Text = "订单编号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(174, 45);
            label2.Name = "label2";
            label2.Size = new Size(84, 26);
            label2.TabIndex = 1;
            label2.Text = "采购人员";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(275, 45);
            label3.Name = "label3";
            label3.Size = new Size(84, 26);
            label3.TabIndex = 2;
            label3.Text = "采购商品";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(396, 47);
            label4.Name = "label4";
            label4.Size = new Size(84, 26);
            label4.TabIndex = 3;
            label4.Text = "采购数量";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(518, 47);
            label5.Name = "label5";
            label5.Size = new Size(84, 26);
            label5.TabIndex = 4;
            label5.Text = "采购单价";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(625, 47);
            label6.Name = "label6";
            label6.Size = new Size(84, 26);
            label6.TabIndex = 5;
            label6.Text = "采购总价";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(740, 47);
            label7.Name = "label7";
            label7.Size = new Size(48, 26);
            label7.TabIndex = 6;
            label7.Text = "状态";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(866, 47);
            label8.Name = "label8";
            label8.Size = new Size(66, 26);
            label8.TabIndex = 7;
            label8.Text = "供应商";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonHighlight;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(1007, 47);
            label9.Name = "label9";
            label9.Size = new Size(84, 26);
            label9.TabIndex = 8;
            label9.Text = "审核人员";
            label9.Click += label9_Click;
            // 
            // ddcx
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ddcx";
            Size = new Size(1688, 1136);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}

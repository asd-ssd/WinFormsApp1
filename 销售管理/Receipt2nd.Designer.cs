namespace WinFormsApp1.销售管理
{
    partial class Receipt2nd
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
            beizhu6 = new Label();
            r2saveas = new Button();
            r2save = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // beizhu6
            // 
            beizhu6.AutoSize = true;
            beizhu6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            beizhu6.Location = new Point(322, 46);
            beizhu6.Name = "beizhu6";
            beizhu6.Size = new Size(398, 31);
            beizhu6.TabIndex = 98;
            beizhu6.Text = "收款单点击新增、修改后转到此页面";
            // 
            // r2saveas
            // 
            r2saveas.BackColor = SystemColors.GradientInactiveCaption;
            r2saveas.Location = new Point(170, 36);
            r2saveas.Name = "r2saveas";
            r2saveas.Size = new Size(100, 40);
            r2saveas.TabIndex = 97;
            r2saveas.Text = "保存新增";
            r2saveas.UseVisualStyleBackColor = false;
            // 
            // r2save
            // 
            r2save.BackColor = SystemColors.GradientInactiveCaption;
            r2save.Location = new Point(64, 36);
            r2save.Name = "r2save";
            r2save.Size = new Size(100, 40);
            r2save.TabIndex = 96;
            r2save.Text = "保存";
            r2save.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 116);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 99;
            label1.Text = "收款单编号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 116);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 100;
            label2.Text = "收款日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 172);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 101;
            label3.Text = "收款人";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 172);
            label4.Name = "label4";
            label4.Size = new Size(46, 24);
            label4.TabIndex = 102;
            label4.Text = "客户";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 228);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 103;
            label5.Text = "收款金额";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 104;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 105;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(467, 30);
            textBox3.TabIndex = 106;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(487, 113);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 107;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(487, 172);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 30);
            textBox5.TabIndex = 108;
            // 
            // Receipt2nd
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(beizhu6);
            Controls.Add(r2saveas);
            Controls.Add(r2save);
            Name = "Receipt2nd";
            Size = new Size(1688, 1136);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label beizhu6;
        private Button r2saveas;
        private Button r2save;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}

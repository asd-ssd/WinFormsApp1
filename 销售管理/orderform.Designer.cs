namespace WinFormsApp1
{
    partial class orderform
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
            sdelete = new Button();
            sedit = new Button();
            screat = new Button();
            ssearch = new Button();
            olabel1 = new Label();
            olabel2 = new Label();
            olabel3 = new Label();
            odateTimePicker1 = new DateTimePicker();
            odateTimePicker2 = new DateTimePicker();
            beizhu1 = new Label();
            button1 = new Button();
            beizhu3 = new Label();
            SuspendLayout();
            // 
            // sdelete
            // 
            sdelete.BackColor = SystemColors.GradientInactiveCaption;
            sdelete.Location = new Point(261, 30);
            sdelete.Name = "sdelete";
            sdelete.Size = new Size(100, 40);
            sdelete.TabIndex = 7;
            sdelete.Text = "删除";
            sdelete.UseVisualStyleBackColor = false;
            // 
            // sedit
            // 
            sedit.BackColor = SystemColors.GradientInactiveCaption;
            sedit.Location = new Point(155, 30);
            sedit.Name = "sedit";
            sedit.Size = new Size(100, 40);
            sedit.TabIndex = 6;
            sedit.Text = "修改";
            sedit.UseVisualStyleBackColor = false;
            // 
            // screat
            // 
            screat.BackColor = SystemColors.GradientInactiveCaption;
            screat.Location = new Point(50, 30);
            screat.Name = "screat";
            screat.Size = new Size(100, 40);
            screat.TabIndex = 5;
            screat.Text = "新建";
            screat.UseVisualStyleBackColor = false;
            // 
            // ssearch
            // 
            ssearch.BackColor = SystemColors.GradientInactiveCaption;
            ssearch.Location = new Point(367, 30);
            ssearch.Name = "ssearch";
            ssearch.Size = new Size(100, 40);
            ssearch.TabIndex = 62;
            ssearch.Text = "查询";
            ssearch.UseVisualStyleBackColor = false;
            // 
            // olabel1
            // 
            olabel1.AutoSize = true;
            olabel1.Location = new Point(110, 121);
            olabel1.Name = "olabel1";
            olabel1.Size = new Size(82, 24);
            olabel1.TabIndex = 64;
            olabel1.Text = "订单日期";
            // 
            // olabel2
            // 
            olabel2.AutoSize = true;
            olabel2.Location = new Point(215, 120);
            olabel2.Name = "olabel2";
            olabel2.Size = new Size(28, 24);
            olabel2.TabIndex = 65;
            olabel2.Text = "从";
            // 
            // olabel3
            // 
            olabel3.AutoSize = true;
            olabel3.Location = new Point(456, 121);
            olabel3.Name = "olabel3";
            olabel3.Size = new Size(28, 24);
            olabel3.TabIndex = 66;
            olabel3.Text = "至";
            // 
            // odateTimePicker1
            // 
            odateTimePicker1.Location = new Point(249, 115);
            odateTimePicker1.Name = "odateTimePicker1";
            odateTimePicker1.Size = new Size(201, 30);
            odateTimePicker1.TabIndex = 73;
            // 
            // odateTimePicker2
            // 
            odateTimePicker2.Location = new Point(490, 115);
            odateTimePicker2.Name = "odateTimePicker2";
            odateTimePicker2.Size = new Size(300, 30);
            odateTimePicker2.TabIndex = 74;
            // 
            // beizhu1
            // 
            beizhu1.AutoSize = true;
            beizhu1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            beizhu1.Location = new Point(260, 221);
            beizhu1.Name = "beizhu1";
            beizhu1.Size = new Size(129, 37);
            beizhu1.TabIndex = 75;
            beizhu1.Text = "待做表格";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(814, 111);
            button1.Name = "button1";
            button1.Size = new Size(60, 34);
            button1.TabIndex = 76;
            button1.Text = "查询";
            button1.UseVisualStyleBackColor = false;
            // 
            // beizhu3
            // 
            beizhu3.AutoSize = true;
            beizhu3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            beizhu3.Location = new Point(144, 173);
            beizhu3.Name = "beizhu3";
            beizhu3.Size = new Size(278, 31);
            beizhu3.TabIndex = 77;
            beizhu3.Text = "点击销售订单后到此界面";
            // 
            // orderform
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(beizhu3);
            Controls.Add(button1);
            Controls.Add(beizhu1);
            Controls.Add(odateTimePicker2);
            Controls.Add(odateTimePicker1);
            Controls.Add(olabel3);
            Controls.Add(olabel2);
            Controls.Add(olabel1);
            Controls.Add(ssearch);
            Controls.Add(sdelete);
            Controls.Add(sedit);
            Controls.Add(screat);
            Name = "orderform";
            Size = new Size(1688, 1136);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button sdelete;
        private Button sedit;
        private Button screat;
        private Button ssearch;
        private Label olabel1;
        private Label olabel2;
        private Label olabel3;
        private DateTimePicker odateTimePicker1;
        private DateTimePicker odateTimePicker2;
        private Label beizhu1;
        private Button button1;
        private Label beizhu3;
    }
}

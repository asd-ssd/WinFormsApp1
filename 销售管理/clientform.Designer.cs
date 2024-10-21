namespace WinFormsApp1
{
    partial class clientform
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
            ccreat = new Button();
            cedit = new Button();
            cdelete = new Button();
            csave = new Button();
            csaveas = new Button();
            cgphone = new Label();
            csaleman = new Label();
            caddress = new Label();
            cphone = new Label();
            ctextBox7 = new TextBox();
            ctextBox6 = new TextBox();
            ctextBox4 = new TextBox();
            ctextBox3 = new TextBox();
            ctextBox2 = new TextBox();
            ccnumber = new Label();
            ccname = new Label();
            ctextBox1 = new TextBox();
            ctype = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ccreat
            // 
            ccreat.BackColor = SystemColors.GradientInactiveCaption;
            ccreat.Location = new Point(50, 30);
            ccreat.Name = "ccreat";
            ccreat.Size = new Size(100, 40);
            ccreat.TabIndex = 0;
            ccreat.Text = "新建";
            ccreat.UseVisualStyleBackColor = false;
            // 
            // cedit
            // 
            cedit.BackColor = SystemColors.GradientInactiveCaption;
            cedit.Location = new Point(156, 30);
            cedit.Name = "cedit";
            cedit.Size = new Size(100, 40);
            cedit.TabIndex = 1;
            cedit.Text = "修改";
            cedit.UseVisualStyleBackColor = false;
            // 
            // cdelete
            // 
            cdelete.BackColor = SystemColors.GradientInactiveCaption;
            cdelete.Location = new Point(262, 30);
            cdelete.Name = "cdelete";
            cdelete.Size = new Size(100, 40);
            cdelete.TabIndex = 2;
            cdelete.Text = "删除";
            cdelete.UseVisualStyleBackColor = false;
            // 
            // csave
            // 
            csave.BackColor = SystemColors.GradientInactiveCaption;
            csave.Location = new Point(368, 30);
            csave.Name = "csave";
            csave.Size = new Size(100, 40);
            csave.TabIndex = 3;
            csave.Text = "保存";
            csave.UseVisualStyleBackColor = false;
            // 
            // csaveas
            // 
            csaveas.BackColor = SystemColors.GradientInactiveCaption;
            csaveas.Location = new Point(474, 30);
            csaveas.Name = "csaveas";
            csaveas.Size = new Size(100, 40);
            csaveas.TabIndex = 4;
            csaveas.Text = "保存新增";
            csaveas.UseVisualStyleBackColor = false;
            // 
            // cgphone
            // 
            cgphone.AutoSize = true;
            cgphone.Location = new Point(383, 158);
            cgphone.Name = "cgphone";
            cgphone.Size = new Size(82, 24);
            cgphone.TabIndex = 36;
            cgphone.Text = "公司电话";
            // 
            // csaleman
            // 
            csaleman.AutoSize = true;
            csaleman.Location = new Point(65, 206);
            csaleman.Name = "csaleman";
            csaleman.Size = new Size(64, 24);
            csaleman.TabIndex = 35;
            csaleman.Text = "业务员";
            // 
            // caddress
            // 
            caddress.AutoSize = true;
            caddress.Location = new Point(65, 260);
            caddress.Name = "caddress";
            caddress.Size = new Size(46, 24);
            caddress.TabIndex = 34;
            caddress.Text = "地址";
            // 
            // cphone
            // 
            cphone.AutoSize = true;
            cphone.Location = new Point(65, 158);
            cphone.Name = "cphone";
            cphone.Size = new Size(82, 24);
            cphone.TabIndex = 33;
            cphone.Text = "联系电话";
            // 
            // ctextBox7
            // 
            ctextBox7.Location = new Point(153, 257);
            ctextBox7.Name = "ctextBox7";
            ctextBox7.Size = new Size(468, 30);
            ctextBox7.TabIndex = 32;
            // 
            // ctextBox6
            // 
            ctextBox6.Location = new Point(471, 158);
            ctextBox6.Name = "ctextBox6";
            ctextBox6.Size = new Size(150, 30);
            ctextBox6.TabIndex = 31;
            // 
            // ctextBox4
            // 
            ctextBox4.Location = new Point(153, 206);
            ctextBox4.Name = "ctextBox4";
            ctextBox4.Size = new Size(150, 30);
            ctextBox4.TabIndex = 30;
            // 
            // ctextBox3
            // 
            ctextBox3.Location = new Point(153, 158);
            ctextBox3.Name = "ctextBox3";
            ctextBox3.Size = new Size(150, 30);
            ctextBox3.TabIndex = 29;
            // 
            // ctextBox2
            // 
            ctextBox2.Location = new Point(471, 106);
            ctextBox2.Name = "ctextBox2";
            ctextBox2.Size = new Size(150, 30);
            ctextBox2.TabIndex = 28;
            // 
            // ccnumber
            // 
            ccnumber.AutoSize = true;
            ccnumber.Location = new Point(383, 109);
            ccnumber.Name = "ccnumber";
            ccnumber.Size = new Size(82, 24);
            ccnumber.TabIndex = 27;
            ccnumber.Text = "客户编号";
            // 
            // ccname
            // 
            ccname.AutoSize = true;
            ccname.Location = new Point(65, 109);
            ccname.Name = "ccname";
            ccname.Size = new Size(82, 24);
            ccname.TabIndex = 26;
            ccname.Text = "客户名称";
            // 
            // ctextBox1
            // 
            ctextBox1.Location = new Point(153, 109);
            ctextBox1.Name = "ctextBox1";
            ctextBox1.Size = new Size(150, 30);
            ctextBox1.TabIndex = 25;
            // 
            // ctype
            // 
            ctype.AutoSize = true;
            ctype.Location = new Point(65, 306);
            ctype.Name = "ctype";
            ctype.Size = new Size(82, 24);
            ctype.TabIndex = 37;
            ctype.Text = "客户类型";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 306);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 38;
            // 
            // clientform
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(ctype);
            Controls.Add(cgphone);
            Controls.Add(csaleman);
            Controls.Add(caddress);
            Controls.Add(cphone);
            Controls.Add(ctextBox7);
            Controls.Add(ctextBox6);
            Controls.Add(ctextBox4);
            Controls.Add(ctextBox3);
            Controls.Add(ctextBox2);
            Controls.Add(ccnumber);
            Controls.Add(ccname);
            Controls.Add(ctextBox1);
            Controls.Add(csaveas);
            Controls.Add(csave);
            Controls.Add(cdelete);
            Controls.Add(cedit);
            Controls.Add(ccreat);
            Name = "clientform";
            Size = new Size(1688, 1136);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ccreat;
        private Button cedit;
        private Button cdelete;
        private Button csave;
        private Button csaveas;
        private Label cgphone;
        private Label csaleman;
        private Label caddress;
        private Label cphone;
        private TextBox ctextBox7;
        private TextBox ctextBox6;
        private TextBox ctextBox4;
        private TextBox ctextBox3;
        private TextBox ctextBox2;
        private Label ccnumber;
        private Label ccname;
        private TextBox ctextBox1;
        private Label ctype;
        private TextBox textBox1;
    }
}

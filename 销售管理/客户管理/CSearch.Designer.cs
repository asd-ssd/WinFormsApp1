namespace WinFormsApp1.销售管理.客户管理
{
    partial class CSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cs = new Button();
            cflabel5 = new Label();
            cflabel4 = new Label();
            cflabel3 = new Label();
            cflabel2 = new Label();
            cflabel1 = new Label();
            c11label1 = new Label();
            c12textBox5 = new TextBox();
            c12textBox4 = new TextBox();
            c12textBox3 = new TextBox();
            c12textBox2 = new TextBox();
            c12textBox1 = new TextBox();
            cscancel = new Button();
            SuspendLayout();
            // 
            // cs
            // 
            cs.Location = new Point(303, 273);
            cs.Name = "cs";
            cs.Size = new Size(112, 34);
            cs.TabIndex = 42;
            cs.Text = "查询";
            cs.UseVisualStyleBackColor = true;
            cs.Click += cs_Click;
            // 
            // cflabel5
            // 
            cflabel5.AutoSize = true;
            cflabel5.Location = new Point(65, 119);
            cflabel5.Name = "cflabel5";
            cflabel5.Size = new Size(46, 24);
            cflabel5.TabIndex = 41;
            cflabel5.Text = "地址";
            // 
            // cflabel4
            // 
            cflabel4.AutoSize = true;
            cflabel4.Location = new Point(466, 119);
            cflabel4.Name = "cflabel4";
            cflabel4.Size = new Size(82, 24);
            cflabel4.TabIndex = 40;
            cflabel4.Text = "公司电话";
            // 
            // cflabel3
            // 
            cflabel3.AutoSize = true;
            cflabel3.Location = new Point(466, 172);
            cflabel3.Name = "cflabel3";
            cflabel3.Size = new Size(64, 24);
            cflabel3.TabIndex = 39;
            cflabel3.Text = "联系人";
            // 
            // cflabel2
            // 
            cflabel2.AutoSize = true;
            cflabel2.Location = new Point(466, 64);
            cflabel2.Name = "cflabel2";
            cflabel2.Size = new Size(82, 24);
            cflabel2.TabIndex = 38;
            cflabel2.Text = "客户名称";
            // 
            // cflabel1
            // 
            cflabel1.AutoSize = true;
            cflabel1.Location = new Point(65, 61);
            cflabel1.Name = "cflabel1";
            cflabel1.Size = new Size(82, 24);
            cflabel1.TabIndex = 37;
            cflabel1.Text = "客户编号";
            // 
            // c11label1
            // 
            c11label1.AutoSize = true;
            c11label1.Location = new Point(65, 61);
            c11label1.Name = "c11label1";
            c11label1.Size = new Size(0, 24);
            c11label1.TabIndex = 36;
            // 
            // c12textBox5
            // 
            c12textBox5.Location = new Point(208, 119);
            c12textBox5.Name = "c12textBox5";
            c12textBox5.Size = new Size(150, 30);
            c12textBox5.TabIndex = 35;
            // 
            // c12textBox4
            // 
            c12textBox4.Location = new Point(612, 110);
            c12textBox4.Name = "c12textBox4";
            c12textBox4.Size = new Size(150, 30);
            c12textBox4.TabIndex = 34;
            // 
            // c12textBox3
            // 
            c12textBox3.Location = new Point(612, 169);
            c12textBox3.Name = "c12textBox3";
            c12textBox3.Size = new Size(150, 30);
            c12textBox3.TabIndex = 33;
            // 
            // c12textBox2
            // 
            c12textBox2.Location = new Point(612, 61);
            c12textBox2.Name = "c12textBox2";
            c12textBox2.Size = new Size(150, 30);
            c12textBox2.TabIndex = 32;
            // 
            // c12textBox1
            // 
            c12textBox1.Location = new Point(208, 61);
            c12textBox1.Name = "c12textBox1";
            c12textBox1.Size = new Size(150, 30);
            c12textBox1.TabIndex = 31;
            // 
            // cscancel
            // 
            cscancel.Location = new Point(448, 273);
            cscancel.Name = "cscancel";
            cscancel.Size = new Size(112, 34);
            cscancel.TabIndex = 43;
            cscancel.Text = "取消查询";
            cscancel.UseVisualStyleBackColor = true;
            cscancel.Click += cscancel_Click;
            // 
            // CSearch
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cscancel);
            Controls.Add(cs);
            Controls.Add(cflabel5);
            Controls.Add(cflabel4);
            Controls.Add(cflabel3);
            Controls.Add(cflabel2);
            Controls.Add(cflabel1);
            Controls.Add(c11label1);
            Controls.Add(c12textBox5);
            Controls.Add(c12textBox4);
            Controls.Add(c12textBox3);
            Controls.Add(c12textBox2);
            Controls.Add(c12textBox1);
            Name = "CSearch";
            Text = "查询";
            Load += CSearch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cs;
        private Label cflabel5;
        private Label cflabel4;
        private Label cflabel3;
        private Label cflabel2;
        private Label cflabel1;
        private Label c11label1;
        private TextBox c12textBox5;
        private TextBox c12textBox4;
        private TextBox c12textBox3;
        private TextBox c12textBox2;
        private TextBox c12textBox1;
        private Button cscancel;
    }
}
namespace WinFormsApp1.销售管理.客户管理
{
    partial class client2
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
            cflabel5 = new Label();
            cflabel4 = new Label();
            cflabel3 = new Label();
            cflabel2 = new Label();
            cflabel1 = new Label();
            c11label1 = new Label();
            c11textBox5 = new TextBox();
            c11textBox4 = new TextBox();
            c11textBox3 = new TextBox();
            c11textBox2 = new TextBox();
            c11textBox1 = new TextBox();
            cnew = new Button();
            SuspendLayout();
            // 
            // cflabel5
            // 
            cflabel5.AutoSize = true;
            cflabel5.Location = new Point(47, 156);
            cflabel5.Name = "cflabel5";
            cflabel5.Size = new Size(46, 24);
            cflabel5.TabIndex = 29;
            cflabel5.Text = "地址";
            // 
            // cflabel4
            // 
            cflabel4.AutoSize = true;
            cflabel4.Location = new Point(448, 109);
            cflabel4.Name = "cflabel4";
            cflabel4.Size = new Size(82, 24);
            cflabel4.TabIndex = 28;
            cflabel4.Text = "公司电话";
            // 
            // cflabel3
            // 
            cflabel3.AutoSize = true;
            cflabel3.Location = new Point(47, 106);
            cflabel3.Name = "cflabel3";
            cflabel3.Size = new Size(82, 24);
            cflabel3.TabIndex = 27;
            cflabel3.Text = "联系电话";
            // 
            // cflabel2
            // 
            cflabel2.AutoSize = true;
            cflabel2.Location = new Point(448, 54);
            cflabel2.Name = "cflabel2";
            cflabel2.Size = new Size(82, 24);
            cflabel2.TabIndex = 26;
            cflabel2.Text = "客户名称";
            // 
            // cflabel1
            // 
            cflabel1.AutoSize = true;
            cflabel1.Location = new Point(47, 51);
            cflabel1.Name = "cflabel1";
            cflabel1.Size = new Size(82, 24);
            cflabel1.TabIndex = 25;
            cflabel1.Text = "客户编号";
            // 
            // c11label1
            // 
            c11label1.AutoSize = true;
            c11label1.Location = new Point(47, 51);
            c11label1.Name = "c11label1";
            c11label1.Size = new Size(0, 24);
            c11label1.TabIndex = 24;
            // 
            // c11textBox5
            // 
            c11textBox5.Location = new Point(190, 156);
            c11textBox5.Name = "c11textBox5";
            c11textBox5.Size = new Size(150, 30);
            c11textBox5.TabIndex = 23;
            // 
            // c11textBox4
            // 
            c11textBox4.Location = new Point(594, 100);
            c11textBox4.Name = "c11textBox4";
            c11textBox4.Size = new Size(150, 30);
            c11textBox4.TabIndex = 22;
            // 
            // c11textBox3
            // 
            c11textBox3.Location = new Point(190, 100);
            c11textBox3.Name = "c11textBox3";
            c11textBox3.Size = new Size(150, 30);
            c11textBox3.TabIndex = 21;
            // 
            // c11textBox2
            // 
            c11textBox2.Location = new Point(594, 51);
            c11textBox2.Name = "c11textBox2";
            c11textBox2.Size = new Size(150, 30);
            c11textBox2.TabIndex = 20;
            // 
            // c11textBox1
            // 
            c11textBox1.Location = new Point(190, 51);
            c11textBox1.Name = "c11textBox1";
            c11textBox1.Size = new Size(150, 30);
            c11textBox1.TabIndex = 19;
            // 
            // cnew
            // 
            cnew.Location = new Point(632, 292);
            cnew.Name = "cnew";
            cnew.Size = new Size(112, 34);
            cnew.TabIndex = 30;
            cnew.Text = "保存";
            cnew.UseVisualStyleBackColor = true;
            cnew.Click += cnew_Click;
            // 
            // client2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cnew);
            Controls.Add(cflabel5);
            Controls.Add(cflabel4);
            Controls.Add(cflabel3);
            Controls.Add(cflabel2);
            Controls.Add(cflabel1);
            Controls.Add(c11label1);
            Controls.Add(c11textBox5);
            Controls.Add(c11textBox4);
            Controls.Add(c11textBox3);
            Controls.Add(c11textBox2);
            Controls.Add(c11textBox1);
            Name = "client2";
            Text = "新建";
            Load += client2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cflabel5;
        private Label cflabel4;
        private Label cflabel3;
        private Label cflabel2;
        private Label cflabel1;
        private Label c11label1;
        private TextBox c11textBox5;
        private TextBox c11textBox4;
        private TextBox c11textBox3;
        private TextBox c11textBox2;
        private TextBox c11textBox1;
        private Button cnew;
    }
}
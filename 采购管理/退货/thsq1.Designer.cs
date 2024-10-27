namespace WinFormsApp1.采购管理
{
    partial class thsq1
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
            button4 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(1107, 570);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 125;
            button4.Text = "提交";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(533, 249);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 159);
            textBox5.TabIndex = 118;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(533, 187);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 30);
            textBox4.TabIndex = 117;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(533, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 30);
            textBox1.TabIndex = 115;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonHighlight;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Location = new Point(367, 249);
            label11.Name = "label11";
            label11.Size = new Size(84, 26);
            label11.TabIndex = 112;
            label11.Text = "退货原因";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(367, 187);
            label10.Name = "label10";
            label10.Size = new Size(84, 26);
            label10.TabIndex = 111;
            label10.Text = "订单编号";
            label10.Click += label10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(367, 127);
            label1.Name = "label1";
            label1.Size = new Size(84, 26);
            label1.TabIndex = 108;
            label1.Text = "退货人员";
            // 
            // button2
            // 
            button2.Location = new Point(797, 185);
            button2.Name = "button2";
            button2.Size = new Size(36, 34);
            button2.TabIndex = 126;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(797, 125);
            button3.Name = "button3";
            button3.Size = new Size(36, 34);
            button3.TabIndex = 127;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // thsq1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 616);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label1);
            Name = "thsq1";
            Text = "thsq1";
            Load += thsq1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private TextBox textBox5;
        private Label label11;
        private Label label10;
        private Label label1;
        private Button button2;
        private Button button3;
        public TextBox textBox1;
        public TextBox textBox4;
    }
}
namespace WinFormsApp1.采购管理.退货
{
    partial class thcxy
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
            button2 = new Button();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label10 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(654, 280);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "查询";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(322, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 30);
            textBox4.TabIndex = 123;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 30);
            textBox1.TabIndex = 122;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonHighlight;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(156, 142);
            label10.Name = "label10";
            label10.Size = new Size(84, 26);
            label10.TabIndex = 120;
            label10.Text = "订单编号";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(156, 82);
            label1.Name = "label1";
            label1.Size = new Size(84, 26);
            label1.TabIndex = 119;
            label1.Text = "退货人员";
            // 
            // thcxy
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 325);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "thcxy";
            Text = "thcxy";
            Load += thcxy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label10;
        private Label label1;
    }
}
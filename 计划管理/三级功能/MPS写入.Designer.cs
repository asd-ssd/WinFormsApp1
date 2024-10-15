namespace WinFormsApp1.Forth
{
    partial class MPS写入
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 97);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "产品编号：";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 100);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "产品名称：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 167);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 3;
            label3.Text = "计划数量：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 170);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 247);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 5;
            label5.Text = "开始日期：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 238);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 6;
            label6.Text = "计划完成日期：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 303);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 7;
            label7.Text = "备注：";
            // 
            // MPS写入
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "MPS写入";
            Text = "MPS写入";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
namespace WinFormsApp1.基础管理.基础信息管理工作界面
{
    partial class parttree
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
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox6 = new TextBox();
            label8 = new Label();
            label13 = new Label();
            label16 = new Label();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(262, 386);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 30);
            textBox5.TabIndex = 113;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 112;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 315);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 111;
            label2.Text = "部门负责人";
            // 
            // button2
            // 
            button2.Location = new Point(327, 535);
            button2.Name = "button2";
            button2.Size = new Size(135, 57);
            button2.TabIndex = 110;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(111, 535);
            button1.Name = "button1";
            button1.Size = new Size(135, 57);
            button1.TabIndex = 109;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(262, 447);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 30);
            textBox6.TabIndex = 108;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(110, 386);
            label8.Name = "label8";
            label8.Size = new Size(136, 24);
            label8.TabIndex = 107;
            label8.Text = "负责人联系电话";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(137, 453);
            label13.Name = "label13";
            label13.Size = new Size(82, 24);
            label13.TabIndex = 106;
            label13.Text = "部门层级";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(137, 192);
            label16.Name = "label16";
            label16.Size = new Size(82, 24);
            label16.TabIndex = 105;
            label16.Text = "部门名称";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 312);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 104;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 103;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 102;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 253);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 101;
            label4.Text = "部门位置";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 124);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 100;
            label1.Text = "上级部门";
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ActiveBorder;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(169, 36);
            label9.Name = "label9";
            label9.Size = new Size(217, 39);
            label9.TabIndex = 129;
            label9.Text = "请输入查询条件";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // parttree
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 713);
            ControlBox = false;
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label13);
            Controls.Add(label16);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "parttree";
            Text = "部门查询";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox3;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textBox6;
        private Label label8;
        private Label label13;
        private Label label16;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label1;
        private Label label9;
    }
}
﻿namespace WinFormsApp1.基础信息管理设置界面
{
    partial class partset
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

            textBox6 = new TextBox();
            label8 = new Label();
            textBox14 = new TextBox();
            label13 = new Label();
            label16 = new Label();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(244, 337);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 30);
            textBox6.TabIndex = 94;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(153, 340);
            label8.Name = "label8";
            label8.Size = new Size(46, 24);
            label8.TabIndex = 93;
            label8.Text = "电话";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(244, 420);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(150, 30);
            textBox14.TabIndex = 92;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(119, 423);
            label13.Name = "label13";
            label13.Size = new Size(82, 24);
            label13.TabIndex = 90;
            label13.Text = "部门编号";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(119, 173);
            label16.Name = "label16";
            label16.Size = new Size(82, 24);
            label16.TabIndex = 89;
            label16.Text = "部门名称";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(244, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 86;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 85;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 84;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 256);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 82;
            label4.Text = "部门位置";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 82);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 80;
            label1.Text = "上级部门";
            // 
            // button1
            // 
            button1.Location = new Point(103, 510);
            button1.Name = "button1";
            button1.Size = new Size(135, 57);
            button1.TabIndex = 95;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(310, 510);
            button2.Name = "button2";
            button2.Size = new Size(135, 57);
            button2.TabIndex = 96;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            // 
            // partset
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 659);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(textBox14);
            Controls.Add(label13);
            Controls.Add(label16);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "partset";
            Text = "部门设置";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private Label label8;
        private TextBox textBox14;
        private Label label13;
        private Label label16;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}
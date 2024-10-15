namespace WinFormsApp1.仓库管理.初始查询界面
{
    partial class warehouse_initial_add
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
            button1 = new Button();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            label15 = new Label();
            label16 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(458, 275);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(109, 38);
            button2.TabIndex = 100;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(260, 275);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(109, 38);
            button1.TabIndex = 99;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(510, 172);
            textBox15.Margin = new Padding(2);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(123, 27);
            textBox15.TabIndex = 98;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(510, 108);
            textBox16.Margin = new Padding(2);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(123, 27);
            textBox16.TabIndex = 97;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(420, 174);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(54, 20);
            label15.TabIndex = 96;
            label15.Text = "添加人";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(168, 174);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(54, 20);
            label16.TabIndex = 95;
            label16.Tag = "";
            label16.Text = "库位号";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(255, 172);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 27);
            textBox2.TabIndex = 94;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 111);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 27);
            textBox1.TabIndex = 93;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 111);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 92;
            label2.Text = "数量";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 111);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 91;
            label1.Text = "物料名";
            // 
            // warehouse_initial_add
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox15);
            Controls.Add(textBox16);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "warehouse_initial_add";
            Text = "warehouse_initial_add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox15;
        private TextBox textBox16;
        private Label label15;
        private Label label16;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}
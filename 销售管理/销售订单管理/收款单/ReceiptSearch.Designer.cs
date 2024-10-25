namespace WinFormsApp1.销售管理.销售订单管理.收款单
{
    partial class ReceiptSearch
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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            r2money = new Label();
            r2client = new Label();
            r2people = new Label();
            r2date = new Label();
            r2number = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 226);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 117;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(482, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 116;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 115;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 114;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(482, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 30);
            dateTimePicker1.TabIndex = 113;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(272, 313);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 112;
            button1.Text = "查询";
            button1.UseVisualStyleBackColor = false;
            button1.Click += r2save_Click;
            // 
            // r2money
            // 
            r2money.AutoSize = true;
            r2money.Location = new Point(19, 229);
            r2money.Name = "r2money";
            r2money.Size = new Size(118, 24);
            r2money.TabIndex = 111;
            r2money.Text = "本次收款金额";
            // 
            // r2client
            // 
            r2client.AutoSize = true;
            r2client.Location = new Point(394, 167);
            r2client.Name = "r2client";
            r2client.Size = new Size(46, 24);
            r2client.TabIndex = 110;
            r2client.Text = "客户";
            r2client.TextAlign = ContentAlignment.TopCenter;
            // 
            // r2people
            // 
            r2people.AutoSize = true;
            r2people.Location = new Point(19, 167);
            r2people.Name = "r2people";
            r2people.Size = new Size(64, 24);
            r2people.TabIndex = 109;
            r2people.Text = "收款人";
            // 
            // r2date
            // 
            r2date.AutoSize = true;
            r2date.Location = new Point(394, 97);
            r2date.Name = "r2date";
            r2date.Size = new Size(82, 24);
            r2date.TabIndex = 108;
            r2date.Text = "收款日期";
            // 
            // r2number
            // 
            r2number.AutoSize = true;
            r2number.Location = new Point(19, 97);
            r2number.Name = "r2number";
            r2number.Size = new Size(100, 24);
            r2number.TabIndex = 107;
            r2number.Text = "收款单编号";
            // 
            // button2
            // 
            button2.Location = new Point(409, 313);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 118;
            button2.Text = "取消查询";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ReceiptSearch
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 444);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(r2money);
            Controls.Add(r2client);
            Controls.Add(r2people);
            Controls.Add(r2date);
            Controls.Add(r2number);
            Name = "ReceiptSearch";
            Text = "查询收款单";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label r2money;
        private Label r2client;
        private Label r2people;
        private Label r2date;
        private Label r2number;
        private Button button2;
    }
}
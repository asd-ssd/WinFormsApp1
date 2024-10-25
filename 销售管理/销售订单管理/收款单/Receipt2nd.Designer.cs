namespace WinFormsApp1.销售管理
{
    partial class Receipt2nd
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
            r2number = new Label();
            r2date = new Label();
            r2people = new Label();
            r2client = new Label();
            r2money = new Label();
            r2save = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // r2number
            // 
            r2number.AutoSize = true;
            r2number.Location = new Point(89, 113);
            r2number.Name = "r2number";
            r2number.Size = new Size(100, 24);
            r2number.TabIndex = 0;
            r2number.Text = "收款单编号";
            r2number.Click += r2number_Click;
            // 
            // r2date
            // 
            r2date.AutoSize = true;
            r2date.Location = new Point(464, 113);
            r2date.Name = "r2date";
            r2date.Size = new Size(82, 24);
            r2date.TabIndex = 1;
            r2date.Text = "收款日期";
            r2date.Click += r2date_Click;
            // 
            // r2people
            // 
            r2people.AutoSize = true;
            r2people.Location = new Point(89, 183);
            r2people.Name = "r2people";
            r2people.Size = new Size(64, 24);
            r2people.TabIndex = 2;
            r2people.Text = "收款人";
            // 
            // r2client
            // 
            r2client.AutoSize = true;
            r2client.Location = new Point(464, 183);
            r2client.Name = "r2client";
            r2client.Size = new Size(46, 24);
            r2client.TabIndex = 3;
            r2client.Text = "客户";
            r2client.TextAlign = ContentAlignment.TopCenter;
            // 
            // r2money
            // 
            r2money.AutoSize = true;
            r2money.Location = new Point(89, 245);
            r2money.Name = "r2money";
            r2money.Size = new Size(118, 24);
            r2money.TabIndex = 4;
            r2money.Text = "本次收款金额";
            // 
            // r2save
            // 
            r2save.BackColor = SystemColors.ControlLightLight;
            r2save.Location = new Point(752, 323);
            r2save.Name = "r2save";
            r2save.Size = new Size(100, 40);
            r2save.TabIndex = 99;
            r2save.Text = "保存";
            r2save.UseVisualStyleBackColor = false;
            r2save.Click += r2save_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(552, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 30);
            dateTimePicker1.TabIndex = 102;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 103;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 104;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(552, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 105;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(236, 242);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 106;
            // 
            // Receipt2nd
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 844);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(r2save);
            Controls.Add(r2money);
            Controls.Add(r2client);
            Controls.Add(r2people);
            Controls.Add(r2date);
            Controls.Add(r2number);
            Name = "Receipt2nd";
            Text = "新建收款单";
            Load += Receipt2nd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label r2number;
        private Label r2date;
        private Label r2people;
        private Label r2client;
        private Label r2money;
        private Button r2save;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
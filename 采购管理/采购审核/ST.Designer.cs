namespace WinFormsApp1.采购管理.采购审核
{
    partial class ST
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
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox8 = new TextBox();
            label3 = new Label();
            textBox9 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(975, 609);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "查询";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1093, 609);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "确认";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 30);
            textBox2.TabIndex = 118;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Location = new Point(123, 45);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 117;
            label2.Text = "订单编号";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(839, 216);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(216, 30);
            textBox7.TabIndex = 115;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(839, 158);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(216, 30);
            textBox6.TabIndex = 114;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(839, 104);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(216, 30);
            textBox5.TabIndex = 113;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(839, 51);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 30);
            textBox4.TabIndex = 112;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 30);
            textBox3.TabIndex = 111;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 30);
            textBox1.TabIndex = 110;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ButtonFace;
            label13.Location = new Point(673, 216);
            label13.Name = "label13";
            label13.Size = new Size(64, 24);
            label13.TabIndex = 109;
            label13.Text = "供应商";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonFace;
            label12.Location = new Point(673, 158);
            label12.Name = "label12";
            label12.Size = new Size(82, 24);
            label12.TabIndex = 108;
            label12.Text = "采购总价";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonFace;
            label11.Location = new Point(673, 104);
            label11.Name = "label11";
            label11.Size = new Size(82, 24);
            label11.TabIndex = 107;
            label11.Text = "采购数量";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonFace;
            label10.Location = new Point(673, 51);
            label10.Name = "label10";
            label10.Size = new Size(82, 24);
            label10.TabIndex = 106;
            label10.Text = "商品单价";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Location = new Point(123, 216);
            label9.Name = "label9";
            label9.Size = new Size(82, 24);
            label9.TabIndex = 105;
            label9.Text = "采购商品";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(123, 105);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 103;
            label1.Text = "申请人员";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1193, 279);
            dataGridView1.TabIndex = 119;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(289, 268);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(216, 30);
            textBox8.TabIndex = 121;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Location = new Point(123, 268);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 120;
            label3.Text = "商品编号";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(289, 158);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(216, 30);
            textBox9.TabIndex = 123;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Location = new Point(123, 162);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 122;
            label4.Text = "员工编号";
            // 
            // ST
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 655);
            Controls.Add(textBox9);
            Controls.Add(label4);
            Controls.Add(textBox8);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ST";
            Text = "ST";
            Load += ST_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        public TextBox textBox8;
        public TextBox textBox9;
    }
}
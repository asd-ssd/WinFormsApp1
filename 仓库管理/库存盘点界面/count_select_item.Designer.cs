namespace WinFormsApp1.仓库管理.库存盘点界面
{
    partial class count_select_item
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
            button7 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(644, 21);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(109, 38);
            button2.TabIndex = 93;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(496, 21);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(109, 38);
            button1.TabIndex = 92;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(359, 16);
            button7.Name = "button7";
            button7.Size = new Size(47, 43);
            button7.TabIndex = 91;
            button7.Text = "查询";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 43);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 90;
            label2.Text = "物料编号";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 89;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 10);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 88;
            label1.Text = "物料名";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 87;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(746, 379);
            dataGridView1.TabIndex = 86;
            // 
            // count_select_item
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 466);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "count_select_item";
            Text = "count_select_item";
            //Load += count_select_item_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button7;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}
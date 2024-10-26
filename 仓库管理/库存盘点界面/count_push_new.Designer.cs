namespace WinFormsApp1.仓库管理.库存盘点界面
{
    partial class count_push_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(count_push_new));
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button11 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(144, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 65;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 37);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 64;
            label2.Text = "最后盘点日期";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 39);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 63;
            label1.Text = "-";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(444, 37);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 62;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(167, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 61;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1000, 403);
            dataGridView1.TabIndex = 59;
            // 
            // button11
            // 
            button11.Location = new Point(700, 21);
            button11.Name = "button11";
            button11.Size = new Size(73, 81);
            button11.TabIndex = 66;
            button11.Text = "导出\r\n打印";
            button11.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(25, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 61);
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 108);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 84;
            label3.Text = "确定要删除该行数据吗？";
            // 
            // count_push_new
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 538);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(button11);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Name = "count_push_new";
            Text = "count_push_new";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button button11;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
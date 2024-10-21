namespace WinFormsApp1.仓库管理.初始查询界面
{
    partial class warehouse_initial_delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(warehouse_initial_delete));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(104, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 61);
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 103);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 82;
            label1.Text = "确定要删除该行数据吗？";
            // 
            // button2
            // 
            button2.Location = new Point(299, 200);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(109, 38);
            button2.TabIndex = 81;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(101, 200);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(109, 38);
            button1.TabIndex = 80;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            // 
            // warehouse_initial_delete
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 292);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "warehouse_initial_delete";
            Text = "warehouse_initial_delete";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}
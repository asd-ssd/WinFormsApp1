namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("华文隶书", 41.9999962F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(461, 25);
            label3.Name = "label3";
            label3.Size = new Size(491, 124);
            label3.TabIndex = 9;
            label3.Text = "橘猫管家";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(492, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 314);
            panel1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Highlight;
            BackgroundImage = Properties.Resources.ERP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1503, 806);
            Controls.Add(panel1);
            Controls.Add(label3);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        public Panel panel1;
    }
}

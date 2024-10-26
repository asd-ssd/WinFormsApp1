namespace WinFormsApp1
{
    partial class BOMcraftset
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
            tableLayoutPanel1 = new TableLayoutPanel();
            clbCrafts = new CheckedListBox();
            lstBOMs = new ListBox();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.8217049F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.1782951F));
            tableLayoutPanel1.Controls.Add(clbCrafts, 1, 0);
            tableLayoutPanel1.Controls.Add(lstBOMs, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 86);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(645, 656);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // clbCrafts
            // 
            clbCrafts.CheckOnClick = true;
            clbCrafts.Dock = DockStyle.Fill;
            clbCrafts.FormattingEnabled = true;
            clbCrafts.Location = new Point(305, 3);
            clbCrafts.Name = "clbCrafts";
            clbCrafts.Size = new Size(337, 650);
            clbCrafts.TabIndex = 0;
            // 
            // lstBOMs
            // 
            lstBOMs.Dock = DockStyle.Fill;
            lstBOMs.FormattingEnabled = true;
            lstBOMs.ItemHeight = 24;
            lstBOMs.Location = new Point(3, 3);
            lstBOMs.Name = "lstBOMs";
            lstBOMs.Size = new Size(296, 650);
            lstBOMs.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(346, 6);
            button2.Name = "button2";
            button2.Size = new Size(126, 55);
            button2.TabIndex = 5;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(121, 6);
            button1.Name = "button1";
            button1.Size = new Size(126, 55);
            button1.TabIndex = 4;
            button1.Text = "保存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BOMcraftset
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 742);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BOMcraftset";
            Text = "绑定工艺路线";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CheckedListBox clbCrafts;
        private ListBox lstBOMs;
        private Button button2;
        private Button button1;
    }
}
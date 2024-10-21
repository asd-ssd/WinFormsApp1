namespace WinFormsApp1.基础管理.基础信息管理工作界面
{
    partial class parttree
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
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.AllowDrop = true;
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(573, 713);
            treeView1.TabIndex = 0;
            // 
            // parttree
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 713);
            Controls.Add(treeView1);
            Name = "parttree";
            Text = "parttree";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
    }
}
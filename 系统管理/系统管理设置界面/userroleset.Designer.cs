namespace WinFormsApp1
{
    partial class userroleset
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
            clbRoles = new CheckedListBox();
            lstUsers = new ListBox();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.8217049F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.1782951F));
            tableLayoutPanel1.Controls.Add(clbRoles, 1, 0);
            tableLayoutPanel1.Controls.Add(lstUsers, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 86);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(645, 656);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // clbRoles
            // 
            clbRoles.CheckOnClick = true;
            clbRoles.Dock = DockStyle.Fill;
            clbRoles.FormattingEnabled = true;
            clbRoles.Location = new Point(305, 3);
            clbRoles.Name = "clbRoles";
            clbRoles.Size = new Size(337, 650);
            clbRoles.TabIndex = 0;
            clbRoles.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // lstUsers
            // 
            lstUsers.Dock = DockStyle.Fill;
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 24;
            lstUsers.Location = new Point(3, 3);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(296, 650);
            lstUsers.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(121, 12);
            button1.Name = "button1";
            button1.Size = new Size(126, 55);
            button1.TabIndex = 1;
            button1.Text = "保存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(346, 12);
            button2.Name = "button2";
            button2.Size = new Size(126, 55);
            button2.TabIndex = 2;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // userroleset
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 742);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Name = "userroleset";
            Text = "角色赋予";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private CheckedListBox clbRoles;
        private ListBox lstUsers;
    }
}
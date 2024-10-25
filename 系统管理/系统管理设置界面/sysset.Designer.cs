namespace WinFormsApp1.系统管理设置界面
{
    partial class sysset
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
            label1 = new Label();
            label2 = new Label();
            txtRoleGroup = new TextBox();
            txtRoleName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 110);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "角色名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 46);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 1;
            label2.Text = "角色组";
            // 
            // txtRoleGroup
            // 
            txtRoleGroup.Location = new Point(183, 43);
            txtRoleGroup.Name = "txtRoleGroup";
            txtRoleGroup.Size = new Size(150, 30);
            txtRoleGroup.TabIndex = 2;
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(183, 110);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(150, 30);
            txtRoleName.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(76, 170);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(221, 170);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // sysset
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 247);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtRoleName);
            Controls.Add(txtRoleGroup);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "sysset";
            Text = "sysset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRoleGroup;
        private TextBox txtRoleName;
        private Button button1;
        private Button button2;
    }
}
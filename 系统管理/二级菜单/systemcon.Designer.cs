namespace WinFormsApp1.二级菜单
{
    partial class systemcon
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            userconbutton = new Button();
            texconbutton = new Button();
            syswhconbutton = new Button();
            syssetconbutton = new Button();
            SuspendLayout();
            // 
            // userconbutton
            // 
            userconbutton.BackgroundImage = Properties.Resource1.权限管理;
            userconbutton.BackgroundImageLayout = ImageLayout.Zoom;
            userconbutton.Location = new Point(88, 213);
            userconbutton.Margin = new Padding(2);
            userconbutton.Name = "userconbutton";
            userconbutton.Size = new Size(174, 144);
            userconbutton.TabIndex = 1;
            userconbutton.Text = "角色管理";
            userconbutton.TextAlign = ContentAlignment.BottomCenter;
            userconbutton.UseVisualStyleBackColor = true;
            // 
            // texconbutton
            // 
            texconbutton.BackgroundImage = Properties.Resource1.授信详情_操作日志;
            texconbutton.BackgroundImageLayout = ImageLayout.Zoom;
            texconbutton.Location = new Point(88, 402);
            texconbutton.Margin = new Padding(2);
            texconbutton.Name = "texconbutton";
            texconbutton.Size = new Size(174, 148);
            texconbutton.TabIndex = 2;
            texconbutton.Text = "日志信息";
            texconbutton.TextAlign = ContentAlignment.BottomCenter;
            texconbutton.UseVisualStyleBackColor = true;
            // 
            // syswhconbutton
            // 
            syswhconbutton.BackgroundImage = Properties.Resource1.系统维护;
            syswhconbutton.BackgroundImageLayout = ImageLayout.Zoom;
            syswhconbutton.Location = new Point(88, 593);
            syswhconbutton.Margin = new Padding(2);
            syswhconbutton.Name = "syswhconbutton";
            syswhconbutton.Size = new Size(174, 130);
            syswhconbutton.TabIndex = 3;
            syswhconbutton.Text = "权限设置";
            syswhconbutton.TextAlign = ContentAlignment.BottomCenter;
            syswhconbutton.UseVisualStyleBackColor = true;
            syswhconbutton.Click += syswhconbutton_Click;
            // 
            // syssetconbutton
            // 
            syssetconbutton.BackgroundImage = Properties.Resource1.设置用;
            syssetconbutton.BackgroundImageLayout = ImageLayout.Zoom;
            syssetconbutton.Location = new Point(88, 30);
            syssetconbutton.Margin = new Padding(2);
            syssetconbutton.Name = "syssetconbutton";
            syssetconbutton.Size = new Size(174, 145);
            syssetconbutton.TabIndex = 0;
            syssetconbutton.Text = "系统设置";
            syssetconbutton.TextAlign = ContentAlignment.BottomCenter;
            syssetconbutton.UseVisualStyleBackColor = true;
            // 
            // systemcon
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(syswhconbutton);
            Controls.Add(texconbutton);
            Controls.Add(userconbutton);
            Controls.Add(syssetconbutton);
            Margin = new Padding(2);
            Name = "systemcon";
            Size = new Size(351, 778);
            ResumeLayout(false);
        }

        #endregion
        private Button userconbutton;
        private Button texconbutton;
        private Button syswhconbutton;
        private Button syssetconbutton;
    }
}

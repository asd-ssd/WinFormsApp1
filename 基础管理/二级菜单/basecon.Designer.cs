namespace WinFormsApp1
{
    partial class basecon
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
            BOMconbutton = new Button();
            crafconbutton = new Button();
            empconbutton = new Button();
            partconbutton = new Button();
            dicconbutton = new Button();
            SuspendLayout();
            // 
            // BOMconbutton
            // 
            BOMconbutton.BackgroundImage = Properties.Resource1.三洋bom;
            BOMconbutton.BackgroundImageLayout = ImageLayout.Zoom;
            BOMconbutton.Location = new Point(101, 18);
            BOMconbutton.Name = "BOMconbutton";
            BOMconbutton.Size = new Size(149, 126);
            BOMconbutton.TabIndex = 0;
            BOMconbutton.Text = "BOM管理";
            BOMconbutton.TextAlign = ContentAlignment.BottomCenter;
            BOMconbutton.UseVisualStyleBackColor = true;
            BOMconbutton.Click += button1_Click;
            // 
            // crafconbutton
            // 
            crafconbutton.BackgroundImage = Properties.Resource1.工艺路线;
            crafconbutton.BackgroundImageLayout = ImageLayout.Zoom;
            crafconbutton.Location = new Point(101, 175);
            crafconbutton.Name = "crafconbutton";
            crafconbutton.Size = new Size(149, 114);
            crafconbutton.TabIndex = 1;
            crafconbutton.Text = "工艺路线管理";
            crafconbutton.TextAlign = ContentAlignment.BottomCenter;
            crafconbutton.UseVisualStyleBackColor = true;
            // 
            // empconbutton
            // 
            empconbutton.BackgroundImage = Properties.Resource1.员工管理;
            empconbutton.BackgroundImageLayout = ImageLayout.Zoom;
            empconbutton.Location = new Point(101, 320);
            empconbutton.Name = "empconbutton";
            empconbutton.Size = new Size(149, 118);
            empconbutton.TabIndex = 2;
            empconbutton.Text = "员工信息";
            empconbutton.TextAlign = ContentAlignment.BottomCenter;
            empconbutton.UseVisualStyleBackColor = true;
            // 
            // partconbutton
            // 
            partconbutton.BackgroundImage = Properties.Resource1._1部门管理;
            partconbutton.BackgroundImageLayout = ImageLayout.Zoom;
            partconbutton.Location = new Point(101, 466);
            partconbutton.Name = "partconbutton";
            partconbutton.Size = new Size(149, 117);
            partconbutton.TabIndex = 3;
            partconbutton.Text = "企业部门";
            partconbutton.TextAlign = ContentAlignment.BottomCenter;
            partconbutton.UseVisualStyleBackColor = true;
            // 
            // dicconbutton
            // 
            dicconbutton.BackgroundImage = Properties.Resource1.字典管理;
            dicconbutton.BackgroundImageLayout = ImageLayout.Zoom;
            dicconbutton.ForeColor = SystemColors.ControlText;
            dicconbutton.Location = new Point(101, 616);
            dicconbutton.Name = "dicconbutton";
            dicconbutton.Size = new Size(149, 116);
            dicconbutton.TabIndex = 4;
            dicconbutton.Text = "基础字典";
            dicconbutton.TextAlign = ContentAlignment.BottomCenter;
            dicconbutton.UseVisualStyleBackColor = true;
            // 
            // basecon
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(dicconbutton);
            Controls.Add(partconbutton);
            Controls.Add(empconbutton);
            Controls.Add(crafconbutton);
            Controls.Add(BOMconbutton);
            Name = "basecon";
            Size = new Size(351, 777);
            ResumeLayout(false);
        }

        #endregion

        private Button BOMconbutton;
        private Button crafconbutton;
        private Button empconbutton;
        private Button partconbutton;
        private Button dicconbutton;
    }
}

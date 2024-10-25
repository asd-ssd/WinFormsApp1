namespace WinFormsApp1.Second
{
    partial class Plan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plan));
            button_lingliao = new Button();
            button_paigong = new Button();
            button_chejian = new Button();
            panel1 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_lingliao
            // 
            button_lingliao.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(button_lingliao, "button_lingliao");
            button_lingliao.Name = "button_lingliao";
            button_lingliao.UseVisualStyleBackColor = false;
            button_lingliao.Click += button_lingliao_Click;
            // 
            // button_paigong
            // 
            button_paigong.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(button_paigong, "button_paigong");
            button_paigong.Name = "button_paigong";
            button_paigong.UseVisualStyleBackColor = false;
            button_paigong.Click += button_paigong_Click;
            // 
            // button_chejian
            // 
            button_chejian.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(button_chejian, "button_chejian");
            button_chejian.Name = "button_chejian";
            button_chejian.UseVisualStyleBackColor = false;
            button_chejian.Click += button_chejian_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_lingliao);
            panel1.Controls.Add(button_paigong);
            panel1.Controls.Add(button_chejian);
            panel1.Controls.Add(button2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Plan
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.LightSteelBlue;
            Controls.Add(panel1);
            Name = "Plan";
            resources.ApplyResources(this, "$this");
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button_lingliao;
        private Button button_paigong;
        private Button button_chejian;
        private Panel panel1;
        private Button button2;
    }
}

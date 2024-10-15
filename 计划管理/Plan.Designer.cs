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
            button1 = new Button();
            button_lingliao = new Button();
            button_paigong = new Button();
            button_chejian = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.BackgroundImage = Properties.Resources.MRP;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button_lingliao
            // 
            button_lingliao.BackColor = SystemColors.ControlLightLight;
            button_lingliao.BackgroundImage = Properties.Resources.采购管理;
            resources.ApplyResources(button_lingliao, "button_lingliao");
            button_lingliao.Name = "button_lingliao";
            button_lingliao.UseVisualStyleBackColor = false;
            // 
            // button_paigong
            // 
            button_paigong.BackColor = SystemColors.ControlLightLight;
            button_paigong.BackgroundImage = Properties.Resources.派工单管理;
            resources.ApplyResources(button_paigong, "button_paigong");
            button_paigong.Name = "button_paigong";
            button_paigong.UseVisualStyleBackColor = false;
            // 
            // button_chejian
            // 
            button_chejian.BackColor = SystemColors.ControlLightLight;
            button_chejian.BackgroundImage = Properties.Resources.车间计划;
            resources.ApplyResources(button_chejian, "button_chejian");
            button_chejian.Name = "button_chejian";
            button_chejian.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button_lingliao);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button_paigong);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_chejian);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.BackgroundImage = Properties.Resource1.主计划管理;
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
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
        private Button button1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Button button2;
        private Label label5;
    }
}

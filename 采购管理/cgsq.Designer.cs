﻿namespace WinFormsApp1
{
    partial class cgsq
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
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(59, 46);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 29;
            button5.Text = "申请";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(59, 125);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 30;
            button6.Text = "审核";
            button6.UseVisualStyleBackColor = true;
            // 
            // cgsq
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(button6);
            Controls.Add(button5);
            Name = "cgsq";
            Size = new Size(1688, 1136);
            Load += cgsq_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private Button button6;
    }
}

namespace WinFormsApp1
{
    partial class PublishTaskForm
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
            buttonSave = new Button();
            textBoxExecutor = new TextBox();
            textBoxSubject = new ComboBox();
            textBoxType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateExecutionTime = new DateTimePicker();
            textBoxContent = new RichTextBox();
            button1 = new Button();
            dateTimeDedline = new DateTimePicker();
            button2 = new Button();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(162, 645);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "确认发布";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxExecutor
            // 
            textBoxExecutor.Location = new Point(173, 62);
            textBoxExecutor.Name = "textBoxExecutor";
            textBoxExecutor.Size = new Size(150, 30);
            textBoxExecutor.TabIndex = 1;
            // 
            // textBoxSubject
            // 
            textBoxSubject.FormattingEnabled = true;
            textBoxSubject.Location = new Point(173, 137);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(150, 32);
            textBoxSubject.TabIndex = 6;
            // 
            // textBoxType
            // 
            textBoxType.FormattingEnabled = true;
            textBoxType.Location = new Point(459, 54);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(150, 32);
            textBoxType.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 62);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 8;
            label1.Text = "执行人";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 62);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 9;
            label2.Text = "任务类型";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 141);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 10;
            label3.Text = "任务主题";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 141);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 11;
            label4.Text = "执行时间";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 220);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 12;
            label5.Text = "执行期限";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 294);
            label6.Name = "label6";
            label6.Size = new Size(82, 24);
            label6.TabIndex = 13;
            label6.Text = "任务内容";
            // 
            // dateExecutionTime
            // 
            dateExecutionTime.Location = new Point(459, 135);
            dateExecutionTime.Name = "dateExecutionTime";
            dateExecutionTime.Size = new Size(183, 30);
            dateExecutionTime.TabIndex = 14;
            // 
            // textBoxContent
            // 
            textBoxContent.Location = new Point(79, 348);
            textBoxContent.Name = "textBoxContent";
            textBoxContent.Size = new Size(601, 243);
            textBoxContent.TabIndex = 15;
            textBoxContent.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(391, 645);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 16;
            button1.Text = "取消";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimeDedline
            // 
            dateTimeDedline.Location = new Point(173, 220);
            dateTimeDedline.Name = "dateTimeDedline";
            dateTimeDedline.Size = new Size(170, 30);
            dateTimeDedline.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(305, 60);
            button2.Name = "button2";
            button2.Size = new Size(38, 34);
            button2.TabIndex = 18;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PublishTaskForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 706);
            Controls.Add(button2);
            Controls.Add(dateTimeDedline);
            Controls.Add(button1);
            Controls.Add(textBoxContent);
            Controls.Add(dateExecutionTime);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxType);
            Controls.Add(textBoxSubject);
            Controls.Add(textBoxExecutor);
            Controls.Add(buttonSave);
            Name = "PublishTaskForm";
            Text = "PublishTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private ComboBox textBoxSubject;
        private ComboBox textBoxType;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateExecutionTime;
        private RichTextBox textBoxContent;
        private Button button1;
        private DateTimePicker dateTimeDedline;
        private Button button2;
        public TextBox textBoxExecutor;
    }
}
namespace WinFormsApp1
{
    partial class DictionaryManager
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryDescription;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemValue;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemValue;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnUpdateItem;
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
            gbCategories = new GroupBox();
            button1 = new Button();
            btnUpdateCategory = new Button();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            lblCategoryDescription = new Label();
            txtCategoryDescription = new TextBox();
            btnAddCategory = new Button();
            cbCategories = new ComboBox();
            gbItems = new GroupBox();
            btnUpdateItem = new Button();
            lblItemName = new Label();
            txtItemName = new TextBox();
            lblItemValue = new Label();
            txtItemValue = new TextBox();
            lblItemDescription = new Label();
            txtItemDescription = new TextBox();
            btnAddItem = new Button();
            btnDeleteItem = new Button();
            dgvItems = new DataGridView();
            gbCategories.SuspendLayout();
            gbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // gbCategories
            // 
            gbCategories.Controls.Add(button1);
            gbCategories.Controls.Add(btnUpdateCategory);
            gbCategories.Controls.Add(lblCategoryName);
            gbCategories.Controls.Add(txtCategoryName);
            gbCategories.Controls.Add(lblCategoryDescription);
            gbCategories.Controls.Add(txtCategoryDescription);
            gbCategories.Controls.Add(btnAddCategory);
            gbCategories.Controls.Add(cbCategories);
            gbCategories.Location = new Point(12, 12);
            gbCategories.Name = "gbCategories";
            gbCategories.Size = new Size(1113, 200);
            gbCategories.TabIndex = 0;
            gbCategories.TabStop = false;
            gbCategories.Text = "类别管理";
            gbCategories.Enter += gbCategories_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(862, 60);
            button1.Name = "button1";
            button1.Size = new Size(125, 84);
            button1.TabIndex = 7;
            button1.Text = "刷新";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Location = new Point(448, 120);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(96, 48);
            btnUpdateCategory.TabIndex = 6;
            btnUpdateCategory.Text = "更新类别";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(6, 60);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(82, 24);
            lblCategoryName.TabIndex = 1;
            lblCategoryName.Text = "类别名称";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(20, 87);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(370, 30);
            txtCategoryName.TabIndex = 2;
            // 
            // lblCategoryDescription
            // 
            lblCategoryDescription.AutoSize = true;
            lblCategoryDescription.Location = new Point(10, 120);
            lblCategoryDescription.Name = "lblCategoryDescription";
            lblCategoryDescription.Size = new Size(82, 24);
            lblCategoryDescription.TabIndex = 3;
            lblCategoryDescription.Text = "类别描述";
            // 
            // txtCategoryDescription
            // 
            txtCategoryDescription.Location = new Point(20, 147);
            txtCategoryDescription.Name = "txtCategoryDescription";
            txtCategoryDescription.Size = new Size(370, 30);
            txtCategoryDescription.TabIndex = 5;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(448, 25);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(98, 48);
            btnAddCategory.TabIndex = 4;
            btnAddCategory.Text = "添加";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(20, 25);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(370, 32);
            cbCategories.TabIndex = 0;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // gbItems
            // 
            gbItems.Controls.Add(btnUpdateItem);
            gbItems.Controls.Add(lblItemName);
            gbItems.Controls.Add(txtItemName);
            gbItems.Controls.Add(lblItemValue);
            gbItems.Controls.Add(txtItemValue);
            gbItems.Controls.Add(lblItemDescription);
            gbItems.Controls.Add(txtItemDescription);
            gbItems.Controls.Add(btnAddItem);
            gbItems.Controls.Add(btnDeleteItem);
            gbItems.Controls.Add(dgvItems);
            gbItems.Location = new Point(12, 218);
            gbItems.Name = "gbItems";
            gbItems.Size = new Size(1164, 546);
            gbItems.TabIndex = 1;
            gbItems.TabStop = false;
            gbItems.Text = "条目管理";
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Location = new Point(1017, 62);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(96, 37);
            btnUpdateItem.TabIndex = 9;
            btnUpdateItem.Text = "更新条目";
            btnUpdateItem.UseVisualStyleBackColor = true;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(20, 32);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(82, 24);
            lblItemName.TabIndex = 1;
            lblItemName.Text = "条目名称";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(20, 69);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(240, 30);
            txtItemName.TabIndex = 2;
            // 
            // lblItemValue
            // 
            lblItemValue.AutoSize = true;
            lblItemValue.Location = new Point(280, 32);
            lblItemValue.Name = "lblItemValue";
            lblItemValue.Size = new Size(64, 24);
            lblItemValue.TabIndex = 3;
            lblItemValue.Text = "条目值";
            // 
            // txtItemValue
            // 
            txtItemValue.Location = new Point(280, 69);
            txtItemValue.Name = "txtItemValue";
            txtItemValue.Size = new Size(240, 30);
            txtItemValue.TabIndex = 4;
            // 
            // lblItemDescription
            // 
            lblItemDescription.AutoSize = true;
            lblItemDescription.Location = new Point(547, 32);
            lblItemDescription.Name = "lblItemDescription";
            lblItemDescription.Size = new Size(82, 24);
            lblItemDescription.TabIndex = 5;
            lblItemDescription.Text = "条目描述";
            // 
            // txtItemDescription
            // 
            txtItemDescription.Location = new Point(547, 69);
            txtItemDescription.Name = "txtItemDescription";
            txtItemDescription.Size = new Size(240, 30);
            txtItemDescription.TabIndex = 6;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(816, 62);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(85, 37);
            btnAddItem.TabIndex = 7;
            btnAddItem.Text = "添加";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(907, 62);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(91, 37);
            btnDeleteItem.TabIndex = 8;
            btnDeleteItem.Text = "删除";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(20, 129);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 62;
            dgvItems.Size = new Size(1123, 388);
            dgvItems.TabIndex = 0;
            dgvItems.SelectionChanged += dgvItems_SelectionChanged;
            // 
            // DictionaryManager
            // 
            ClientSize = new Size(1188, 762);
            Controls.Add(gbItems);
            Controls.Add(gbCategories);
            Name = "DictionaryManager";
            Text = "基础字典管理";
            Load += DictionaryManager_Load;
            gbCategories.ResumeLayout(false);
            gbCategories.PerformLayout();
            gbItems.ResumeLayout(false);
            gbItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Button button1;
    }
}

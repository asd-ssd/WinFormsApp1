using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;

namespace WinFormsApp1
{
    public partial class DictionaryManager : Form
    {
        public DictionaryManager()
        {
            InitializeComponent();
            cbCategories.SelectedIndex = -1;
            cbCategories.Text = string.Empty;
            LoadDictionaryCategories();
            
        }

        private void LoadDictionaryCategories()
        {
            
            var categories = SqlSugarHelper.SqlSugarClient.Queryable<DictionaryCategory>().ToList();
            cbCategories.DataSource = categories;
            cbCategories.DisplayMember = "CategoryName";
            cbCategories.ValueMember = "CategoryId";
            cbCategories.SelectedIndex = -1;
            
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCategories.SelectedIndex!=-1)
            {
                int categoryId = (int)cbCategories.SelectedValue;
                var items = SqlSugarHelper.SqlSugarClient.Queryable<DictionaryItem>()
                                .Where(item => item.CategoryId == categoryId)
                                .ToList();
                dgvItems.DataSource = items;
                var catagorys = SqlSugarHelper.SqlSugarClient.Queryable<DictionaryCategory>()
                                .Where(item => item.CategoryId == categoryId)
                                .ToList();
                foreach(var catagory in catagorys)
                {
                    txtCategoryName.Text = catagory.CategoryName;
                    txtCategoryDescription.Text = catagory.Description;
                }

                // 设置中文列名
                dgvItems.Columns["ItemId"].HeaderText = "项 ID"; // 如果你有 ItemId 列
                dgvItems.Columns["CategoryId"].HeaderText = "类别 ID"; // 如果你有 CategoryId 列
                dgvItems.Columns["ItemName"].HeaderText = "项目名称";
                dgvItems.Columns["ItemValue"].HeaderText = "项目值";
                dgvItems.Columns["Description"].HeaderText = "描述";
            }
            

        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 1)
            {
                var selectedrow = dgvItems.SelectedRows[0];
                txtItemName.Text = selectedrow.Cells["ItemName"].Value.ToString();
                txtItemValue.Text = selectedrow.Cells["ItemValue"].Value.ToString();
                txtItemDescription.Text = selectedrow.Cells["Description"].Value.ToString();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            string description = txtCategoryDescription.Text;
            var category = new DictionaryCategory { CategoryName = categoryName, Description = description };
            SqlSugarHelper.SqlSugarClient.Insertable(category).ExecuteCommand();
            LoadDictionaryCategories();
            txtCategoryName.Clear();
            txtCategoryDescription.Clear();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (cbCategories.SelectedValue != null)
            {
                int categoryId = (int)cbCategories.SelectedValue;
                var category = SqlSugarHelper.SqlSugarClient.Queryable<DictionaryCategory>().InSingle(categoryId);
                if (category != null)
                {
                    category.CategoryName = txtCategoryName.Text;
                    category.Description = txtCategoryDescription.Text;
                    SqlSugarHelper.SqlSugarClient.Updateable(category).ExecuteCommand();
                    LoadDictionaryCategories();
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int categoryId = (int)cbCategories.SelectedValue;
            string itemName = txtItemName.Text;
            string itemValue = txtItemValue.Text;
            string description = txtItemDescription.Text;
            var item = new DictionaryItem { CategoryId = categoryId, ItemName = itemName, ItemValue = itemValue, Description = description };
            SqlSugarHelper.SqlSugarClient.Insertable(item).ExecuteCommand();
            cbCategories_SelectedIndexChanged(null, null);
            txtItemName.Clear();
            txtItemValue.Clear();
            txtItemDescription.Clear();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                int itemId = (int)dgvItems.SelectedRows[0].Cells["ItemId"].Value;
                var item = SqlSugarHelper.SqlSugarClient.Queryable<DictionaryItem>().InSingle(itemId);

                if (item != null)
                {
                    item.ItemName = txtItemName.Text;
                    item.ItemValue = txtItemValue.Text;
                    item.Description = txtItemDescription.Text;
                    SqlSugarHelper.SqlSugarClient.Updateable(item).ExecuteCommand();
                    cbCategories_SelectedIndexChanged(null, null);
                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int itemId = (int)dgvItems.SelectedRows[0].Cells["ItemId"].Value;
            SqlSugarHelper.SqlSugarClient.Deleteable<DictionaryItem>().In(itemId).ExecuteCommand();
            cbCategories_SelectedIndexChanged(null, null);
        }

   


        //刷新
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDictionaryCategories();
            dgvItems.DataSource = null;
            txtCategoryName.Clear();
            txtCategoryDescription.Clear();
            txtItemName.Clear();
            txtItemValue.Clear();
            txtItemDescription.Clear();

        }

        private void gbCategories_Enter(object sender, EventArgs e)
        {

        }

        private void DictionaryManager_Load(object sender, EventArgs e)
        {
            
        }
    }
}

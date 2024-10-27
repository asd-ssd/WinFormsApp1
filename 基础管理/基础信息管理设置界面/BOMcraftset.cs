using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;

namespace WinFormsApp1
{
    public partial class BOMcraftset : Form
    {
        public BOMcraftset()
        {
            InitializeComponent();
            LoadBOMs();
            LoadCrafts();
        }
        private void LoadBOMs()
        {
            // 查询所有用户并绑定到 ListBox
            var BOMs = SqlSugarHelper.SqlSugarClient.Queryable<BOM>().ToList();
            lstBOMs.DataSource = BOMs;
            lstBOMs.DisplayMember = "BOMName";
            lstBOMs.ValueMember = "BOMId"; // 物料编码作为唯一标识
        }

        private void LoadCrafts()
        {
            // 查询所有角色并绑定到 CheckedListBox
            var crafts = SqlSugarHelper.SqlSugarClient.Queryable<Craft>().ToList();
            clbCrafts.DataSource = crafts;
            clbCrafts.DisplayMember = "CraftName";
            clbCrafts.ValueMember = "CraftId"; // 工序号作为唯一标识
            lstBOMs.SelectedIndexChanged += lstBOMs_SelectedIndexChanged; // 绑定 ListBox 的选择事件
        }
        private void lstBOMs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 清除所有已选中的角色
            for (int i = 0; i < clbCrafts.Items.Count; i++)
            {
                clbCrafts.SetItemChecked(i, false);
            }

            // 获取选中的用户
            var selectedBOM = lstBOMs.SelectedItem as BOM;
            if (selectedBOM == null)
            {
                return;
            }

            // 查询该用户已有的角色
            var bomCrafts = SqlSugarHelper.SqlSugarClient.Queryable<BOMcraft>()
                .Where(ur => ur.BOMId == selectedBOM.BOMId)
                .ToList();

            // 根据查询结果，勾选用户已拥有的角色
            foreach (var bomCraft in bomCrafts)
            {
                // 找到对应角色在 CheckedListBox 中的位置，并选中该项
                for (int i = 0; i < clbCrafts.Items.Count; i++)
                {
                    var craft = clbCrafts.Items[i] as Craft;
                    if (craft != null && craft.CraftId == bomCraft.CraftId)
                    {
                        clbCrafts.SetItemChecked(i, true);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (lstBOMs.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择至少一个物料");
                return;
            }

            if (clbCrafts.CheckedItems.Count == 0)
            {
                MessageBox.Show("请选择至少一个工序");
                return;
            }

            try
            {
                // 遍历所有选中的用户
                foreach (var selectedBOM in lstBOMs.SelectedItems)
                {
                    var bomId = (selectedBOM as BOM).BOMId;

                    // 获取所有已有的角色
                    var existingBomcrafts = SqlSugarHelper.SqlSugarClient.Queryable<BOMcraft>()
                        .Where(ur => ur.BOMId == bomId)
                        .ToList();

                    // 遍历所有选中的角色，添加或更新
                    foreach (var checkedCraft in clbCrafts.CheckedItems)
                    {
                        var craftId = (checkedCraft as Craft).CraftId;

                        var existingBOMcraft = existingBomcrafts.FirstOrDefault(ur => ur.CraftId == craftId);
                        if (existingBOMcraft == null)
                        {
                            var newBOMcraft = new BOMcraft
                            {
                                BOMId = bomId,
                                CraftId = craftId
                            };
                            SqlSugarHelper.SqlSugarClient.Insertable(newBOMcraft).ExecuteCommand();
                            MessageBox.Show($"物料 {bomId} 已被赋予新工艺路线 {checkedCraft}");
                        }
                    }

                    // 删除未勾选的角色
                    foreach (var existingBOMcraft in existingBomcrafts)
                    {
                        if (!clbCrafts.CheckedItems.Contains(clbCrafts.Items.Cast<Craft>().FirstOrDefault(r => r.CraftId == existingBOMcraft.CraftId)))
                        {
                            SqlSugarHelper.SqlSugarClient.Deleteable<BOMcraft>()
                                .Where(ur => ur.BOMId == bomId && ur.CraftId == existingBOMcraft.CraftId)
                                .ExecuteCommand();
                            MessageBox.Show($"物料 {bomId} 工艺路线 {existingBOMcraft.CraftId} 已被移除");
                        }
                    }
                }

                MessageBox.Show("工艺路线已成功赋予或更新给选定物料");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"操作时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("当前修改仍未保存，是否退出？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

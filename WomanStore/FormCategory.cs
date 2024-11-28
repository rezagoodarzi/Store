using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WomanStore
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmCategoryInsert f = new FrmCategoryInsert();
            f.ShowDialog();
            updateInformation();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridshow.SelectedRows.Count > 0)
            {
                int categoryId = Convert.ToInt32(gridshow.SelectedRows[0].Cells["Id"].Value);
                string categoryName = gridshow.SelectedRows[0].Cells["Name"].Value.ToString();
                string categoryDescription = ""; 

                using (WemonDbEntities db = new WemonDbEntities())
                {
                    var category = db.Categories.Find(categoryId);
                    if (category != null)
                    {
                        categoryDescription = category.Description;
                    }
                }

                FrmCategoryUpdate updateForm = new FrmCategoryUpdate(categoryId, categoryName, categoryDescription);
                updateForm.ShowDialog();

                updateInformation();
            }
            else
            {
                MessageBox.Show("Please select a category to update.");
            }
            //FrmCategoryUpdate f = new FrmCategoryUpdate();
            //f.ShowDialog();
            //updateInformation();
        }
        private void customizeGrd()
        {
            gridshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridshow.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            gridshow.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridshow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        //private void FrmCategory_Load(object sender, EventArgs e)
        //{
        //    customizeGrd();

        //    updateInformation();
        //}
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            customizeGrd();
            //AddSelectButtonColumn();
            updateInformation();
        }
        private void AddSelectButtonColumn()
        {
            if (!gridshow.Columns.Contains("Select"))
            {
                DataGridViewButtonColumn selectColumn = new DataGridViewButtonColumn
                {
                    Name = "Select",
                    HeaderText = "Select",
                    Text = "Select",
                    UseColumnTextForButtonValue = true, // Show "Select" as button text
                    Width = 70
                };
                gridshow.Columns.Add(selectColumn);
            }
        }

        private void updateInformation()
        {
            WemonDbEntities db = new WemonDbEntities();
            var cat = db.Categories.ToList();
            var catshow = cat.Select(s => new { s.Id, s.Name })
                                 .ToList();

            gridshow.DataSource = catshow;

            gridshow.Columns["Id"].Visible = false;
            gridshow.Columns["Name"].HeaderText = "دسته";
        }

        private void gridshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void DeleteCategory(int id)
        {
            using (WemonDbEntities db = new WemonDbEntities())
            {
                // Get all subcategories related to the category
                var subcategories = db.SubCategories.Where(s => s.CategoryId == id).ToList();

                // Remove all subcategories first
                foreach (var subcategory in subcategories)
                {
                    db.SubCategories.Remove(subcategory);
                }

                var category = db.Categories.FirstOrDefault(c => c.Id == id);
                if (category != null)
                {
                    db.Categories.Remove(category);
                    db.SaveChanges();
                }
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridshow.SelectedRows.Count > 0)
            {
                int selectedRowIndex = gridshow.SelectedRows[0].Index;
                int categoryId = Convert.ToInt32(gridshow.Rows[selectedRowIndex].Cells["Id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this category and all its subcategories?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteCategory(categoryId);
                    updateInformation();
                    MessageBox.Show("Category and its subcategories deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}

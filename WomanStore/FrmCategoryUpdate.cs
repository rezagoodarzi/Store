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
    public partial class FrmCategoryUpdate : Form
    {
        public int CategoryId { get; set; } // Pass the ID of the selected category

        public FrmCategoryUpdate(int categoryId, string categoryName, string categoryDescription)
        {
            InitializeComponent();
            CategoryId = categoryId;

            // Pre-fill the text boxes with the current category data
            edtCategory.Text = categoryName;
            edtDescription.Text = categoryDescription;
        }

        private void FrmCategoryUpdate_Load(object sender, EventArgs e)
        {

        }

        private void edtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (WemonDbEntities db = new WemonDbEntities())
            {
                var category = db.Categories.Find(CategoryId);
                if (category != null)
                {
                    category.Name = edtCategory.Text;
                    category.Description = edtDescription.Text;

                    db.SaveChanges();
                    MessageBox.Show("Category updated successfully.");
                }
                else
                {
                    MessageBox.Show("Category not found.");
                }
            }

            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace WomanStore
{
    public partial class FrmCategoryInsert : Form
    {
        public FrmCategoryInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            WemonDbEntities db = new WemonDbEntities();

            Category category = new Category();
            category.Name = edtCategory.Text;
            category.Description = edtDescription.Text;

            db.Categories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Category added Successfully");
        }

        private void edtCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

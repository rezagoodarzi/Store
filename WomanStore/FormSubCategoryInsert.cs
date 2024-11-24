using System;
using System.Linq;
using System.Windows.Forms;

namespace WomanStore
{
    public partial class FrmSubCategoryInsert : Form
    {
        public FrmSubCategoryInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // id
            //MessageBox.Show(cmbCategory.SelectedValue.ToString());
            // text
            //MessageBox.Show(cmbCategory.Text.ToString());

            WemonDbEntities db = new WemonDbEntities();

            SubCategory subCategory = new SubCategory();
            subCategory.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            subCategory.Name = edtSubCategory.Text;
            subCategory.Description = edtDescription.Text;

            db.SubCategories.Add(subCategory);
            db.SaveChanges();
            MessageBox.Show("SubCategory added Successfully");
        }

        private void FrmSubCategoryInsert_Load(object sender, EventArgs e)
        {

            WemonDbEntities db = new WemonDbEntities();
            var categories = db.Categories.ToList();
            var caegoryShow = categories.Select(s => new { s.Id, s.Name })
                                 .ToList();

            cmbCategory.DataSource = caegoryShow;
            cmbCategory.DisplayMember = "Name";    // Display student names
            cmbCategory.ValueMember = "Id";

        }
    }
}

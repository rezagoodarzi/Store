using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WomanStore
{
    public partial class FrmProductTypeInsert : Form
    {
        public FrmProductTypeInsert()
        {
            InitializeComponent();
        }

        private void FrmProductTypeInsert_Load(object sender, EventArgs e)
        {

            WemonDbEntities db = new WemonDbEntities();
            var categories = db.Categories.ToList();
            var caegoryShow = categories.Select(s => new { s.Id, s.Name })
                                 .ToList();

            cmbCategory.DataSource = caegoryShow;
            cmbCategory.DisplayMember = "Name";    // Display student names
            cmbCategory.ValueMember = "Id";

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            WemonDbEntities db = new WemonDbEntities();
            var value = int.Parse(cmbCategory.SelectedValue.ToString());

            var subCategory = db.SubCategories
                .Where(s => s.Id == value)
                .ToList();
            var subCategoryShow = subCategory.Select(s => new { s.Id, s.Name })
                                 .ToList();

            cmbSubCategory.DataSource = subCategoryShow;
            cmbSubCategory.DisplayMember = "Name";    // Display student names
            cmbSubCategory.ValueMember = "Id";

        }
    }
}

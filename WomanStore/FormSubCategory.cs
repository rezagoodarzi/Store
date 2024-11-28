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
    public partial class FrmSubCategory : Form
    {
        public FrmSubCategory()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmSubCategoryInsert f = new FrmSubCategoryInsert();
            f.ShowDialog();
            updateInformation();
        }

        private void FrmSubCategory_Load(object sender, EventArgs e)
        {
            customizeGrd();

            updateInformation();
        }
        private void customizeGrd()
        {
            gridshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridshow.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            gridshow.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridshow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void updateInformation()
        {
            WemonDbEntities db = new WemonDbEntities();
            var SubCategory = db.SubCategories.ToList();
            var SubCategoryShow = SubCategory.Select(s => new { s.Id, s.Name })
                                 .ToList();

            gridshow.DataSource = SubCategoryShow;

            gridshow.Columns["Id"].Visible = false;
            gridshow.Columns["Name"].HeaderText = "زیر دسته";
        }

        private void gridshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

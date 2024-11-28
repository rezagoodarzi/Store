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
    public partial class FrmProductType : Form
    {
        public FrmProductType()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmProductTypeInsert f = new FrmProductTypeInsert();
            f.ShowDialog();
            updateInformation();

        }

        private void customizeGrd()
        {
            gridshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridshow.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            gridshow.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridshow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void FrmProductType_Load(object sender, EventArgs e)
        {
            customizeGrd();

            updateInformation();
        }
        private void updateInformation()
        {
            WemonDbEntities db = new WemonDbEntities();
            var ProductType = db.ProductTypes.ToList();
            var ProductTypeshow = ProductType.Select(s => new { s.Id, s.Name })
                                 .ToList();

            gridshow.DataSource = ProductTypeshow;

            gridshow.Columns["Id"].Visible = false;
            gridshow.Columns["Name"].HeaderText = "نوع محصول";
        }
        private void gridshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

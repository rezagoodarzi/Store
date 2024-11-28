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
    public partial class FrmMaterial : Form
    {
        public FrmMaterial()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmMaterialInsert f = new FrmMaterialInsert();
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
        private void FrmMaterial_Load(object sender, EventArgs e)
        {
            customizeGrd();

            updateInformation();
        }
        private void updateInformation()
        {
            WemonDbEntities db = new WemonDbEntities();
            var Material = db.Materials.ToList();
            var materialshow = Material.Select(s => new { s.Id, s.Name })
                                 .ToList();

            gridshow.DataSource = materialshow;

            gridshow.Columns["Id"].Visible = false;
            gridshow.Columns["Name"].HeaderText = "جنس";
        }
        private void gridshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

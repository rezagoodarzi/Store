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
           // updateInformation();

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmCategoryInsert f = new FrmCategoryInsert();
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
        //private void FrmCategory_Load(object sender, EventArgs e)
        //{
        //    customizeGrd();

        //    updateInformation();
        //}
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            customizeGrd();

            updateInformation();
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
    }
}

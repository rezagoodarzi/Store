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
    public partial class FrmSize : Form
    {
        public FrmSize()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmSizeInsert f = new FrmSizeInsert();
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
        private void FrmSize_Load(object sender, EventArgs e)
        {
            customizeGrd();

            updateInformation();
        }
        private void updateInformation()
        {
            WemonDbEntities db = new WemonDbEntities();
            var Size = db.Sizes.ToList();
            var SizeShow = Size.Select(s => new { s.Id, s.Name })
                                 .ToList();

            gridshow.DataSource = SizeShow;

            gridshow.Columns["Id"].Visible = false;
            gridshow.Columns["Name"].HeaderText = "اندازه";
        }

        private void gridshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

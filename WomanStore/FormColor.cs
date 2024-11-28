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
    public partial class FrmColor : Form
    {
        public FrmColor()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmColorInsert f = new FrmColorInsert();
            f.ShowDialog();
            updateInformation();
        }

        //private void CustomizeGridView()
        //{
        //    // Auto-size columns to fill the grid
        //    grdShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        //    // Set alternating row colors for better readability
        //    grdShow.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

        //    // Set header style
        //    grdShow.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        //    grdShow.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
        //    grdShow.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    grdShow.EnableHeadersVisualStyles = false;

        //    // Center-align column headers
        //    grdShow.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //    // Set row height
        //    grdShow.RowTemplate.Height = 30;

        //    // Set grid line color
        //    grdShow.GridColor = Color.LightBlue;

        //    // Set default cell style
        //    grdShow.DefaultCellStyle.Font = new Font("Arial", 10);
        //    grdShow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //}

        private void customizeGrd()
        {
            grdShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdShow.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            grdShow.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdShow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void FrmColor_Load(object sender, EventArgs e)
        {
            customizeGrd();

            updateInformation();
        }

        private void updateInformation()
        {
            WemonDbEntities db = new WemonDbEntities();
            var colors = db.Colors.ToList();
            var colorsShow = colors.Select(s => new { s.Id, s.Name })
                                 .ToList();

            grdShow.DataSource = colorsShow;

            grdShow.Columns["Id"].Visible = false;
            grdShow.Columns["Name"].HeaderText = "رنگ";
        }

        private void grdShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

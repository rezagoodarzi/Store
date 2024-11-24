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

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmSubCategoryInsert f = new FrmSubCategoryInsert();
            f.ShowDialog();
        }

        private void FrmSubCategory_Load(object sender, EventArgs e)
        {
        }
    }
}

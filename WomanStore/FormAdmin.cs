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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory f = new FrmCategory();
            f.ShowDialog();
        }

        private void btnSubCategory_Click(object sender, EventArgs e)
        {
            FrmSubCategory f = new FrmSubCategory();
            f.ShowDialog();
        }

        private void btnProductType_Click(object sender, EventArgs e)
        {
            FrmProductType f = new FrmProductType();
            f.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProduct f = new FrmProduct();
            f.ShowDialog();

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            FrmColor f = new FrmColor();
            f.ShowDialog();
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            FrmSize f = new FrmSize();
            f.ShowDialog();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            FrmMaterial f = new FrmMaterial();
            f.ShowDialog();
        }
    }
}

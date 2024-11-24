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
    public partial class FrmMaterialInsert : Form
    {
        public FrmMaterialInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            WemonDbEntities db = new WemonDbEntities();

            Material material = new Material();
            material.Name = edtMaterial.Text;

            db.Materials.Add(material);
            db.SaveChanges();
            MessageBox.Show("Material added Successfully");
        }
    }
}

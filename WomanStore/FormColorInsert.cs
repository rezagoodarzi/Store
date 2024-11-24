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
    public partial class FrmColorInsert : Form
    {
        public FrmColorInsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            WemonDbEntities db = new WemonDbEntities();

            Color color = new Color();
            color.Name = edtColor.Text;

            db.Colors.Add(color);
            db.SaveChanges();
            MessageBox.Show("Color added Successfully");
        }
    }
}

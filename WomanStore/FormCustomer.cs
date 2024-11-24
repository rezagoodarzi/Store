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
    public partial class FrmCustomerMain : Form
    {
        public FrmCustomerMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormCustomerLogin f = new FormCustomerLogin();
            f.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp f = new FormSignUp();
            f.ShowDialog();
        }
    }
}

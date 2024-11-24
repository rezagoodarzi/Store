using System;
using System.Windows.Forms;

namespace WomanStore
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (edtPassword.Text == edtPassword2.Text)
            {
                WemonDbEntities db = new WemonDbEntities();

                Customer customer = new Customer();
                customer.FirstName = edtFirstName.Text;
                customer.LastName = edtLastName.Text;
                customer.PhoneNumber = edtPhoneNumber.Text;
                customer.Email = edtEmail.Text;
                customer.Password = edtPassword.Text;
                customer.Address = edtAddress.Text;
                customer.CreateTime = "";
                customer.UpdateTime = "";

                db.Customers.Add(customer);
                db.SaveChanges();
                MessageBox.Show("You Signed Up Successfully");
            } else
            {
                MessageBox.Show("Password is not same as each other");
            }
        }
    }
}

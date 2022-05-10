
using System.Windows.Forms;
using System.Threading;
using System;

namespace lab1
{
    public partial class SignInForm : Form
    {
        RegistrationController reg = new RegistrationController();
        public SignInForm()
        {
            InitializeComponent();
            //this.database = database;
        }

        public void Open()
        {
            ShowDialog();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            ChoosingOptionForm StartForm = new ChoosingOptionForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if(NameEdit.Text == "" || SurnameEdit.Text == "" ||
                PatronymicEdit.Text == "" || LoginEdit.Text =="" ||
                PasswEdit.Text == "" || RepPasswEdit.Text == "" ||
                PhoneNumberEdit.Text == "" || EmailEdit.Text == "" ||
                PassportNumberEdit.Text == "" || IdNumbEdit.Text == "" ||
                CountryEdit.Text == "" || CompanyEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields.");
            }
            else if (PasswEdit.Text != RepPasswEdit.Text)
            {
                MessageBox.Show("Passwords don't match");
            }
            else
            {
                string id = Guid.NewGuid().ToString();
                reg.RegistrateClient(id, LoginEdit.Text, PasswEdit.Text, NameEdit.Text, SurnameEdit.Text, PatronymicEdit.Text,
                    PhoneNumberEdit.Text, EmailEdit.Text, PassportNumberEdit.Text, IdNumbEdit.Text, CountryEdit.Text, CompanyEdit.Text);
                MessageBox.Show("You successfully registrated");
                
            }

            
        }

        private void PhoneNumberEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void IdNumbEdit_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

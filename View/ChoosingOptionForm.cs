using System;
using System.Windows.Forms;
using System.Threading;



namespace lab1
{
    public partial class ChoosingOptionForm : Form
    {
        public ChoosingOptionForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }
        private void SignIn_Click(object sender, EventArgs e)
        {
            SignInForm StartForm = new SignInForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUpForm StartForm = new SignUpForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

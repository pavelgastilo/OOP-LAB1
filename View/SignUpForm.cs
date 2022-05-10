using System;
using System.Windows.Forms;
using System.Threading;

namespace lab1
{
    public partial class SignUpForm : Form
    {
        AuthController auth = new AuthController();
        ClientController actClient = new ClientController();
        OperatorController op = new OperatorController();
        ManagerController manager = new ManagerController();
        AnotherSpecialistController another = new AnotherSpecialistController();
        AdminController admin = new AdminController();
        public SignUpForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChoosingOptionForm StartForm = new ChoosingOptionForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginEdit.Text == "" || PasswordEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                if( auth.Auth(LoginEdit.Text, PasswordEdit.Text).UserID != new Client().UserID)
                {
                    MessageBox.Show($"Successful autn! {actClient.GetClient(LoginEdit.Text).UserID}");
                    ClientForm StartForm = new ClientForm(actClient);
                    Thread myThread1 = new Thread(StartForm.Open);
                    myThread1.Start();
                    this.Close();
                    this.Dispose();
                }
                else if(auth.AuthOp(LoginEdit.Text, PasswordEdit.Text).UserID != new Operator().UserID)
                {
                    MessageBox.Show($"Successful autn! {op.GetOperator(LoginEdit.Text).UserID}");
                    OperatorForm StartForm = new OperatorForm(op);
                    Thread myThread1 = new Thread(StartForm.Open);
                    myThread1.Start();
                    this.Close();
                    this.Dispose();
                }
                else if(auth.AuthMan(LoginEdit.Text, PasswordEdit.Text).UserID != new Manager().UserID)
                {
                    MessageBox.Show($"Successful autn! {manager.GetManager(LoginEdit.Text).UserID}");
                    ManagerForm StartForm = new ManagerForm(manager);
                    Thread myThread1 = new Thread(StartForm.Open);
                    myThread1.Start();
                    this.Close();
                    this.Dispose();
                }
                else if(auth.AuthAnSp(LoginEdit.Text, PasswordEdit.Text).UserID != new AnotherSpecialist().UserID)
                {
                    MessageBox.Show($"Successful autn! {another.GetSpecialist(LoginEdit.Text).UserID}");
                    AnotherSpecialistForm StartForm = new AnotherSpecialistForm(another);
                    Thread myThread1 = new Thread(StartForm.Open);
                    myThread1.Start();
                    this.Close();
                    this.Dispose();
                }
                else if(auth.AuthAdm(LoginEdit.Text, PasswordEdit.Text).UserID != new Admin().UserID)
                {
                    MessageBox.Show($"Successful autn! {admin.GetAdmin(LoginEdit.Text).UserID}");
                    BankForm StartForm = new BankForm(admin);
                    Thread myThread1 = new Thread(StartForm.Open);
                    myThread1.Start();
                    this.Close();
                    this.Dispose();
                }
                else MessageBox.Show("Login or password are wrong.");


            }
        }
    }
}

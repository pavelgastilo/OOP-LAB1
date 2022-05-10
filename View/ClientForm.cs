using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab1
{
    public partial class ClientForm : Form
    {
        ClientController actClient = null;
        public ClientForm(ClientController cl)
        {
            InitializeComponent();
            actClient = cl;
            actClient.GetAccounts(AccountsBox);
            actClient.GetBanks(BankBox);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void CreditButton_Click(object sender, EventArgs e)
        {
            actClient.GetCredits(StatusMemo);
        }

        private void InstallmentButton_Click(object sender, EventArgs e)
        {
            actClient.GetInstallments(StatusMemo);
        }

        private void OpenAccountButton_Click(object sender, EventArgs e)
        {
            if (SumEdit.Text == "" || BankBox.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in all the fields.");
            }
            else if ((Convert.ToDouble(SumEdit.Text)) > double.MaxValue) MessageBox.Show("Too big value.");
            else
            {
                actClient.CreateAccount(Convert.ToDouble(SumEdit.Text), BankBox.SelectedItem.ToString(), "-");
                AccountsBox.Items.Clear();
                actClient.GetAccounts(AccountsBox);
                SumEdit.Text = "";
            }
        }

        private void AccountsButton_Click(object sender, EventArgs e)
        {
            
            if (AccountsBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose the account number");
            }
            else
            {
                string number = AccountsBox.SelectedItem.ToString();
                AccountForm StartForm = new AccountForm(number, actClient.ActiveClient);
                Thread myThread1 = new Thread(StartForm.Open);
                myThread1.Start();
                //this.Close();
                //this.Dispose();
            }
        }

        private void TakeCreditButton_Click(object sender, EventArgs e)
        {
            CreditForm StartForm = new CreditForm(actClient);
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            //this.Close();
            //this.Dispose();
        }

        private void TakeInsButton_Click(object sender, EventArgs e)
        {
            InstallmentForm StartForm = new InstallmentForm(actClient);
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            //this.Close();
            //this.Dispose();
        }

        private void StatButton_Click(object sender, EventArgs e)
        {
            StatusMemo.AppendText($"Login: {actClient.ActiveClient.Login}\n" +
                $"Name: {actClient.ActiveClient.Name}\n" +
                $"Surname: {actClient.ActiveClient.Surname}\n" +
                $"Patronumic: {actClient.ActiveClient.Patronymic}\n" +
                $"Phone number: {actClient.ActiveClient.PhoneNumber}\n" +
                $"Email: {actClient.ActiveClient.Email}\n" +
                $"Passport: {actClient.ActiveClient.Passport}\n" +
                $"Passport id number: {actClient.ActiveClient.IdNumb}\n" +
                $"Country: {actClient.ActiveClient.Country}\n" +
                $"Company: {actClient.ActiveClient.Company}\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatusMemo.Clear();
            AccountsBox.Items.Clear();
            actClient.GetAccounts(AccountsBox);
            actClient.ActiveClient.UpdateInformation();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            SignUpForm StartForm = new SignUpForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void BankBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void salprgButton_Click(object sender, EventArgs e)
        {
            if ((Convert.ToDouble(salprgEdit.Text)) > double.MaxValue) MessageBox.Show("Too big value.");
            else
            {
                actClient.CreateSalaryProject(Convert.ToDouble(salprgEdit.Text));
                salprgEdit.Text = "";
            }
        }

        private void SumEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void salprgEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}

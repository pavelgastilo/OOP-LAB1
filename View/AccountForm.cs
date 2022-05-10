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
    public partial class AccountForm : Form
    {
        AccountController account = new AccountController();
        ClientController client = new ClientController();

        public AccountForm(string number, Client cl)
        {
            InitializeComponent();
            account.GetAccount(number);
            account.GetNumbers(NumberTransBox);
            client.ActiveClient = cl;
        }

        public void Open()
        {
            ShowDialog();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            AccountMemo.AppendText($"{account.ActiveAccount.Sum}");
            SavingMemo.AppendText($"{account.ActiveAccount.SavingSum}");
            AccumMemo.AppendText($"{account.ActiveAccount.AccumulationSum}");
        }

        private void SavingButton_Click(object sender, EventArgs e)
        {
            if (SavingEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                account.OnSaving(Convert.ToDouble(SavingEdit.Text));
                SavingEdit.Text = "";
                AccountMemo.Clear();
                SavingMemo.Clear();
                AccountMemo.AppendText($"{account.ActiveAccount.Sum}");
                SavingMemo.AppendText($"{account.ActiveAccount.SavingSum}");
            }

        }

        private void CashOutButton_Click(object sender, EventArgs e)
        {
            if (CashOutEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                if (Convert.ToDouble(CashOutEdit.Text) <= account.ActiveAccount.Sum)
                {
                    account.CashOut(Convert.ToDouble(CashOutEdit.Text));
                    CashOutEdit.Text = "";
                    AccountMemo.Clear();
                    AccountMemo.AppendText($"{account.ActiveAccount.Sum}" + "$");
                }
                else
                {
                    MessageBox.Show("Not enough money on your bank account");
                }
            }
        }

        private void TransferEdit_Click(object sender, EventArgs e)
        {
            if (TransferSumEdit.Text == "" || NumberTransBox.SelectedIndex == -1)
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                if (Convert.ToDouble(TransferSumEdit.Text) <= account.ActiveAccount.Sum)
                {
                    account.Transfer(NumberTransBox.SelectedItem.ToString(), Convert.ToDouble(TransferSumEdit.Text));
                    TransferEdit.Text = "";
                    AccountMemo.Clear();
                    AccountMemo.AppendText($"{account.ActiveAccount.Sum}");
                    MessageBox.Show($"Transfer from {account.ActiveAccount.AccountNumber} to {NumberTransBox.SelectedItem.ToString()} is done.");
                }
                else MessageBox.Show("Not enough money on your account");
            }
        }

        private void AccumulationButton_Click(object sender, EventArgs e)
        {
            if (AccumulationEdit.Text == "" || AccumulationPercentEdit.Text == "")
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                if (Convert.ToDouble(AccumulationPercentEdit.Text) <= 100)
                {
                    if (Convert.ToDouble(AccumulationEdit.Text) + Convert.ToDouble(AccumulationEdit.Text)*0.01* Convert.ToDouble(AccumulationPercentEdit.Text) <= account.ActiveAccount.Sum)
                    {
                        account.Accumulation(Convert.ToDouble(AccumulationEdit.Text), Convert.ToDouble(AccumulationPercentEdit.Text));
                        AccountMemo.Clear();
                        AccumMemo.Clear();
                        AccountMemo.AppendText($"{account.ActiveAccount.Sum}");
                        AccumMemo.AppendText($"{account.ActiveAccount.AccumulationSum}");
                        AccumulationEdit.Text = "";
                        AccumulationPercentEdit.Text = "";
                    }
                    else MessageBox.Show("Not enough money on your account");
                }
                else MessageBox.Show("Too big percent.");
            }
        }

        private void FreezingButton_Click(object sender, EventArgs e)
        {
            if(account.ActiveAccount.Active)
            {
                account.Freeze();
                FreezingButton.Text = "Unfreeze";
                Controls.Cast<Control>().ToList().ForEach((ctrl) => ctrl.Visible = false);
                FreezingButton.Visible = true;
                BackButton.Visible = true;
            }
            else
            {
                account.Unfreeze();
                FreezingButton.Text = "Freeze";
                Controls.Cast<Control>().ToList().ForEach((ctrl) => ctrl.Visible = true);
            }
            
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            account.Block();
            MessageBox.Show("The account was blocked.");
            this.Close();
            this.Dispose();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SavingEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CashOutEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void TransferSumEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void AccumulationEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void AccumulationPercentEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}

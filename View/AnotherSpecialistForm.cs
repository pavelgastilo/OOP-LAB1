using System;
using System.Threading;
using System.Windows.Forms;

namespace lab1
{
    public partial class AnotherSpecialistForm : Form
    {
        AnotherSpecialistController spec = new AnotherSpecialistController();
        public AnotherSpecialistForm(AnotherSpecialistController sp)
        {
            InitializeComponent();
            spec = sp;
            spec.GetAccounts(AccBox);
            spec.GetMyAccounts(MyAccsBox);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void SalPrjButton_Click(object sender, EventArgs e)
        {
            if (SalPrjEdit.Text == "") MessageBox.Show("Fill in the sum.");
            else
            {
                spec.TakeSalaryProject(Convert.ToDouble(SalPrjEdit.Text));
                SalPrjEdit.Text = "";
            }
        }

        private void MyAccsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            spec.GetAccount(MyAccsBox, richTextBox1);
        }

        private void AccBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            spec.GetAccount(AccBox, richTextBox1);
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (MyAccsBox.SelectedIndex == -1 || AccBox.SelectedIndex == -1) MessageBox.Show("Choose all the fields.");
            else
            {
                spec.Transfer(MyAccsBox.SelectedItem.ToString(), AccBox.SelectedItem.ToString(), Convert.ToDouble(TransferSumEdit.Text));
                TransferSumEdit.Text = "";
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            SignUpForm StartForm = new SignUpForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void SalPrjEdit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

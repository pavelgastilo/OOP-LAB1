using System;
using System.Threading;
using System.Windows.Forms;

namespace lab1
{
    public partial class ManagerForm : Form
    {
        ManagerController manager = new ManagerController();
        public ManagerForm(ManagerController man)
        {
            InitializeComponent();
            manager = man;
            manager.GetSalaryProjects(ProjB);
            manager.GetCredits(CredB);
            manager.GetInstallments(InstB);
        }

        public void Open()
        {
            ShowDialog();
        }

        private void ClearM_Click(object sender, EventArgs e)
        {
            Status.Clear();
        }

        private void AllCrBut_Click(object sender, EventArgs e)
        {
            manager.GetCredits(Status);
        }

        private void AllInsBut_Click(object sender, EventArgs e)
        {
            manager.GetInstallments(Status);
        }

        private void AllPrBut_Click(object sender, EventArgs e)
        {
            manager.GetSalaryProjects(Status);
        }

        private void ConfPrj_Click(object sender, EventArgs e)
        {
            if (ProjB.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.ConfirmSalaryProject(ProjB.SelectedItem.ToString());
        }

        private void DeclPrj_Click(object sender, EventArgs e)
        {
            if (ProjB.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.DeclineSalaryProject(ProjB.SelectedItem.ToString());
        }

        private void ShowPrj_Click(object sender, EventArgs e)
        {
            if (ProjB.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.GetSalaryProjects(Status, ProjB.SelectedItem.ToString());
        }

        private void ConfCr_Click(object sender, EventArgs e)
        {
            if (CredB.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.ConfirmCredit(CredB.SelectedItem.ToString());
        }

        private void DeclCr_Click(object sender, EventArgs e)
        {
            if (CredB.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.DeclineCredit(CredB.SelectedItem.ToString());
        }

        private void ShowCr_Click(object sender, EventArgs e)
        {
            if (CredB.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.GetCredits(Status, CredB.SelectedItem.ToString());
        }

        private void ConfInst_Click(object sender, EventArgs e)
        {
            if (InstB.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.ConfirmInstallment(InstB.SelectedItem.ToString());
        }

        private void DeclInst_Click(object sender, EventArgs e)
        {
            if (InstB.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.DeclineInstallment(InstB.SelectedItem.ToString());
        }

        private void ShowInst_Click(object sender, EventArgs e)
        {
            if (InstB.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else manager.GetInstallments(Status, InstB.SelectedItem.ToString());
        }

        private void LogoutB_Click(object sender, EventArgs e)
        {
            SignUpForm StartForm = new SignUpForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }
    }
}

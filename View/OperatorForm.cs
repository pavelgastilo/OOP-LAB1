using System;
using System.Windows.Forms;
using System.Threading;

namespace lab1
{
    public partial class OperatorForm : Form
    {
        OperatorController Operator = null;
        public OperatorForm(OperatorController op)
        {
            InitializeComponent();
            Operator = op;
            Operator.GetSalaryProjects(ProjectsBox);
        }

        public OperatorController OperatorController
        {
            get => default;
            set
            {
            }
        }

        public void Open()
        {
            ShowDialog();
        }

        private void AllprgButton_Click(object sender, EventArgs e)
        {
            Operator.GetSalaryProjects(StatusMemo);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            StatusMemo.Clear();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (ProjectsBox.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else Operator.ConfirmSalaryProject(ProjectsBox.SelectedItem.ToString());
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            if (ProjectsBox.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else Operator.DeclineSalaryProject(ProjectsBox.SelectedItem.ToString());
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (ProjectsBox.SelectedIndex == -1) MessageBox.Show("Choose the project.");
            else Operator.GetSalPrj(StatusMemo, ProjectsBox.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SignUpForm StartForm = new SignUpForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operator.GetLogs(StatusMemo);
        }
    }
}

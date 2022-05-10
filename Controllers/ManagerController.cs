using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class ManagerController
    {
        Database db = Program.database;
        public Manager manager = null;

        public Manager GetManager(string login)
        {
            manager = db.GetManager(login);
            return manager;
        }

        public void ConfirmCredit(string number)
        {
            //manager.ConfirmCredit(number);
            db.UpdateConfirmCredit(number);
            db.UpdateBase();
        }

        public void DeclineCredit(string number)
        {
            //manager.DeclineCredit(number);
            db.UpdateDeclineCredit(number);
            db.UpdateBase();
        }

        public void ConfirmInstallment(string number)
        {
            manager.ConfirmInstallment(number);
            db.UpdateConfirmInstallment(number);
            db.UpdateBase();
        }

        public void DeclineInstallment(string number)
        {
            //manager.DeclineInstallment(number);
            db.UpdateDeclineInstallment(number);
            db.UpdateBase();
        }

        public void ConfirmSalaryProject(string number)
        {
            manager.ConfirmSalaryProject(number);
            db.UpdateConfirmSalPrj(number);
            db.UpdateBase();
        }

        public void DeclineSalaryProject(string number)
        {

            db.UpdateDeclineSalPrj(number);
            //manager.DeclineSalaryProject(number);
            db.UpdateBase();
        }

        public void GetSalaryProjects(System.Windows.Forms.RichTextBox rich)
        {
            foreach (SalaryProject i in db.SalaryProjects)
            {
                rich.AppendText($"User ID: {i.UserID}\n" +
                    $"Salary project number: {i.SalaryProjectNumber}\n" +
                    $"Sum: {i.Sum}\n");
                if (!(i.Approved) && !(i.Cancelled)) rich.AppendText($"Approve: not approved\n\n");
                else if (i.Approved) rich.AppendText($"Approve: approved\n\n");
                else if (i.Cancelled) rich.AppendText($"Approve: declined\n\n");
            }
        }

        public void GetSalaryProjects(System.Windows.Forms.RichTextBox rich, string number)
        {
            foreach (SalaryProject i in db.SalaryProjects)
            {
                if (i.SalaryProjectNumber == number)
                {
                    rich.AppendText($"User ID: {i.UserID}\n" +
                    $"Salary project number: {i.SalaryProjectNumber}\n" +
                    $"Sum: {i.Sum}\n");
                    if (!(i.Approved) && !(i.Cancelled)) rich.AppendText($"Approve: not approved\n\n");
                    else if (i.Approved) rich.AppendText($"Approve: approved\n\n");
                    else if (i.Cancelled) rich.AppendText($"Approve: declined\n\n");
                }
            }
        }

        public void GetSalaryProjects(System.Windows.Forms.ComboBox rich)
        {
            foreach (SalaryProject i in db.SalaryProjects)
            {
                rich.Items.Add(i.SalaryProjectNumber);
            }
        }

        public void GetCredits(System.Windows.Forms.RichTextBox rich)
        {
            foreach (Credit i in db.Credits)
            {
                rich.AppendText($"User ID: {i.UserID}\n" +
                    $"Credit number: {i.CreditNumber}\n" +
                    $"Months: {i.Month}\n" +
                    $"Sum: {i.Sum}\n" +
                    $"Percent: {i.Percent}\n" +
                    $"Bank: {i.Bank}\n");
                if (!(i.Approved) && !(i.Cancelled)) rich.AppendText($"Approve: not approved\n\n");
                else if (i.Approved) rich.AppendText($"Approve: approved\n\n");
                else if (i.Cancelled) rich.AppendText($"Approve: declined\n\n");
            }
        }

        public void GetCredits(System.Windows.Forms.RichTextBox rich, string number)
        {
            foreach (Credit i in db.Credits)
            {
                if (i.CreditNumber == number)
                {
                    rich.AppendText($"User ID: {i.UserID}\n" +
                    $"Credit number: {i.CreditNumber}\n" +
                    $"Months: {i.Month}\n" +
                    $"Sum: {i.Sum}\n" +
                    $"Percent: {i.Percent}\n" +
                    $"Bank: {i.Bank}\n");
                    if (!(i.Approved) && !(i.Cancelled)) rich.AppendText($"Approve: not approved\n\n");
                    else if (i.Approved) rich.AppendText($"Approve: approved\n\n");
                    else if (i.Cancelled) rich.AppendText($"Approve: declined\n\n");
                }
            }
        }

        public void GetCredits(System.Windows.Forms.ComboBox rich)
        {
            foreach (Credit i in db.Credits)
            {
                rich.Items.Add(i.CreditNumber);
            }
        }

        public void GetInstallments(System.Windows.Forms.RichTextBox rich)
        {
            foreach (Installment i in db.Installments)
            {
                rich.AppendText($"User ID: {i.UserID}\n" +
                    $"Installment number: {i.InstallmentNumber}\n" +
                    $"Months: {i.Month}\n" +
                    $"Sum: {i.Sum}\n" +
                    $"Percent: {i.Percent}\n" +
                    $"Bank: {i.Bank}\n");
                if (!(i.Approved) && !(i.Cancelled)) rich.AppendText($"Approve: not approved\n\n");
                else if (i.Approved) rich.AppendText($"Approve: approved\n\n");
                else if (i.Cancelled) rich.AppendText($"Approve: declined\n\n");
            }
        }

        public void GetInstallments(System.Windows.Forms.RichTextBox rich, string number)
        {
            foreach (Installment i in db.Installments)
            {
                if (i.InstallmentNumber == number)
                {
                    rich.AppendText($"User ID: {i.UserID}\n" +
                    $"Installment number: {i.InstallmentNumber}\n" +
                    $"Months: {i.Month}\n" +
                    $"Sum: {i.Sum}\n" +
                    $"Percent: {i.Percent}\n" +
                    $"Bank: {i.Bank}\n");
                    if (!(i.Approved) && !(i.Cancelled)) rich.AppendText($"Approve: not approved\n\n");
                    else if (i.Approved) rich.AppendText($"Approve: approved\n\n");
                    else if (i.Cancelled) rich.AppendText($"Approve: declined\n\n");
                }
            }
        }

        public void GetInstallments(System.Windows.Forms.ComboBox rich)
        {
            foreach (Installment i in db.Installments)
            {
                rich.Items.Add(i.InstallmentNumber);
            }
        }
    }
}

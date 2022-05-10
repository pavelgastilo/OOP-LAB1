using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class ClientController
    {
        Database db = Program.database;
        public Client ActiveClient = null;

        public Client GetClient(string login)
        {
            ActiveClient = db.GetClient(login);
            return ActiveClient;
        }


        public void CreateAccount(double sum, string bankname, string companyname)
        {
            ActiveClient.BuildAccount(sum, bankname);
        }

        public void CreateCredit(double sum, string bankname, int months)
        {
            ActiveClient.TakeCredit(months, sum, bankname);
        }

        public void CreateInstallment(double sum, string bankname, int months)
        {
            ActiveClient.TakeInstallment(months, sum, bankname);
        }

        public void CreateSalaryProject(double sum)
        {
            ActiveClient.TakeSalaryProject(sum);
        }

        public void GetAccounts(System.Windows.Forms.ComboBox rich)
        {
            ActiveClient.UpdateInformation();
            var AccountNumber = from p in ActiveClient.Accounts select p.AccountNumber;
            foreach (var i in AccountNumber)
            {
                rich.Items.Add(i);
            }
        }

        public void GetCredits(System.Windows.Forms.RichTextBox rich)
        {
            ActiveClient.UpdateInformation();
            foreach(Credit i in ActiveClient.Credits)
            {
                rich.AppendText($"Credit number: {i.CreditNumber}\n" +
                    $"Bank: {i.Bank}\n" +
                    $"Sum: {i.Sum}\n" +
                    $"Percent: {i.Percent}\n" +
                    $"Months: {i.Month}\n");
                if (!(i.Approved) && !(i.Cancelled)) rich.AppendText("Approve: not approve\n\n");
                else if (i.Approved) rich.AppendText("Approve: approved\n\n");
                else if (i.Cancelled) rich.AppendText("Approve: declined\n\n");
            }
        }

        public void GetInstallments(System.Windows.Forms.RichTextBox rich)
        {
            ActiveClient.UpdateInformation();
            foreach (Installment i in ActiveClient.Installments)
            {
                rich.AppendText($"Installment number: {i.InstallmentNumber}\n" +
                    $"Bank: {i.Bank}\n" +
                    $"Sum: {i.Sum}\n" +
                    $"Percent: {i.Percent}\n" +
                    $"Months: {i.Month}\n");
                if ((!(i.Approved)) && (!(i.Cancelled))) rich.AppendText("Approve: not approve\n\n");
                else if (i.Approved) rich.AppendText("Approve: approved\n\n");
                else if (i.Cancelled) rich.AppendText("Approve: declined\n\n");
            }
        }

        public void GetBanks(System.Windows.Forms.ComboBox rich)
        {
            db.SetBanks(rich);
        }
    }
}

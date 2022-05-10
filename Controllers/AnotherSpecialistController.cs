using System;
using System.Data;
using GenericParsing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class AnotherSpecialistController
    {
        Database db = Program.database;
        public AnotherSpecialist ASpecialist = null;

        public AnotherSpecialist GetSpecialist(string login)
        {
            ASpecialist = db.GetAnotherSpecialist(login);
            return ASpecialist;
        }

        public void Transfer(string idSen, string idRec, double sum)
        {
            ASpecialist.TransferTo(idSen, idRec, sum);
        }

        public void TakeSalaryProject(double sum)
        {
            ASpecialist.TakeSalaryProject(sum);
        }

        public void GetAccounts(System.Windows.Forms.ComboBox box)
        {
            foreach(Account i in db.Accounts)
            {
                if (i.CompanyName != "" && i.CompanyName != "-" && i.CompanyName != this.ASpecialist.CompanyName) 
                    box.Items.Add(i.AccountNumber); 
            }
        }

        public void GetMyAccounts(System.Windows.Forms.ComboBox box)
        {
            ASpecialist.Update();
            foreach (Account i in ASpecialist.accs) box.Items.Add(i.AccountNumber);
        }

        public void GetAccount(System.Windows.Forms.ComboBox box, System.Windows.Forms.RichTextBox rich)
        {
            foreach(Account i in db.Accounts)
            {
                if(box.SelectedItem.ToString() == i.AccountNumber)
                {
                    rich.AppendText($"Account number: {i.AccountNumber}\n" +
                        $"User id: {i.UserID}\n" +
                        $"Bank: {i.BankName}\n" +
                        $"Company: {i.CompanyName}\n" +
                        $"Sum: {i.Sum}\n" +
                        $"Sum on saving: {i.SavingSum}\n" +
                        $"Sum on accumulation: {i.AccumulationSum}\n\n");
                }
            }
        }
    }
}

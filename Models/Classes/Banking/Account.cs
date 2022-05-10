using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Account : IAccount
    {
        Database db = Program.database;
        Transfer ATransfer = new Transfer();
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public string UserID { get; set; }
        public string BankName{ get; set; }
        public string CompanyName { get; set; }
        public double Sum { get; set; }
        public double SavingSum { get; set; }
        public double AccumulationSum { get; set; }
        public bool Active = true;
        
        public Account() { }

        public Account(string userId, double sum, string bankname, string companyName = default)
        {
            this.Id = Guid.NewGuid().ToString();
            this.AccountNumber = Guid.NewGuid().ToString();
            this.AccountNumber = this.AccountNumber.Substring(0, 8);
            this.UserID = userId;
            this.Sum = sum;
            this.SavingSum = 0;
            this.AccumulationSum = 0;
            this.BankName = bankname;
            this.CompanyName = companyName;
        }

        public Account GetAccount(string id, string accNum, string userId, double sum, double savsum, double accsum, string bankname, string companyName, bool active = true)
        {
            this.Id = id;
            this.AccountNumber = accNum;
            this.UserID = userId;
            this.Sum = sum;
            this.SavingSum = savsum;
            this.AccumulationSum = accsum;
            this.BankName = bankname;
            this.CompanyName = companyName;
            this.Active = active;

            return this;
        }

        public void SavingMoney(double sum)
        {
            if (sum <= this.Sum && Active)
            {
                this.SavingSum += sum;
                this.Sum -= sum;
            }
        }

        public void CashOut(double sum)
        {
            if (sum <= this.Sum && Active)
            {
                this.Sum -= sum;
            }
        }

        public void Transfer(string numberSender, string numberOfRecepient, double sum)
        {
            ATransfer.TransferTo(numberSender, numberOfRecepient, sum);
        }

        public void Accumulation(double sum, double percent)
        {
            if (sum <= this.Sum && Active)
            {
                this.AccumulationSum += sum + (sum * 0.01 * percent);
                this.Sum -= sum;
            }
        }

        public void BlockAccount()
        {
            db.RemoveAccount(this.AccountNumber);
            db.UpdateBase();
        }

        public void Freeze()
        {
            this.Active = false;
        }

        public void Unfreeze()
        {
            this.Active = true;
        }
    }
}

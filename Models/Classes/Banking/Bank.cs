using System;
using System.Collections.Generic;

namespace lab1
{
    public class Bank : IBank
    {
        Database db = Program.database;
        public string Name { get; set; }
        List<Account> Accounts = new List<Account>();
        List<Credit> Credits = new List<Credit>();
        List<Installment> Installments = new List<Installment>();
        List<Client> Clients = new List<Client>();

        public Bank() { }
        public Bank(string bankName) 
        {
            this.Name = bankName;
            this.UpdateInformation();
        }

        public Bank GetBank(string name)
        {
            this.Name = name;

            return this;
        }

        public void UpdateInformation()
        {
            foreach (Account i in db.Accounts) if (i.BankName == this.Name) Accounts.Add(i);
            foreach (Credit i in db.Credits) if (i.Bank == this.Name) Credits.Add(i);
            foreach (Client i in db.Clients) if (i.Banks.Contains(this.Name)) Clients.Add(i);
            foreach (Installment i in db.Installments) if (i.Bank == this.Name) Installments.Add(i);
        }
    }
}

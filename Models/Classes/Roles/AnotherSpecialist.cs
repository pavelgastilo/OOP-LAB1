using System;
using System.Data;
using System.Collections.Generic;


namespace lab1
{
    public class AnotherSpecialist : User
    {
        Database db = Program.database;
        SalaryProject salprj = new SalaryProject();
        Transfer STransfer = new Transfer();
        public List<Account> accs = new List<Account>();
        public string CompanyName;

        public AnotherSpecialist() { }
        public AnotherSpecialist(string login, string password)
        {
            this.UserID = Guid.NewGuid().ToString();
            this.Login = login;
            this.Password = password;
        }

        public AnotherSpecialist GetAnotherSpecialist(string id, string login, string password, string companyName)
        {
            this.UserID = id;
            this.Login = login;
            this.Password = password;
            this.CompanyName = companyName;

            return this;
        }

        public void Update()
        {
            foreach (Account i in db.Accounts) if (i.CompanyName == this.CompanyName) accs.Add(i);
        }

        public void TransferTo(string numberSender, string numberOfRecepient, double sum)
        {
            STransfer.TransferTo(numberSender, numberOfRecepient, sum);
        }

        public void TakeSalaryProject(double sum)//add bank and logs
        {
            salprj = new SalaryProject(this.UserID, sum);
            db.AddSalaryProect(salprj.Id, salprj.SalaryProjectNumber, salprj.UserID, salprj.Sum, salprj.Approved, salprj.Cancelled);
        }
    }
}

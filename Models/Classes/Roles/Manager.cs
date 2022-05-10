using System;
using System.Collections.Generic;
using System.Data;


namespace lab1
{
    public class Manager : Operator
    {
        Database db = Program.database;

        public Manager() { }
        public Manager(string login, string password)
        {
            this.UserID = Guid.NewGuid().ToString();
            this.Login = login;
            this.Password = password;
        }

        public Manager GetManager(string id, string login, string password)
        {
            this.UserID = id;
            this.Login = login;
            this.Password = password;

            return this;
        }

        public void ConfirmCredit(string creditNumber)
        {
            foreach (Credit i in db.Credits)
            {
                if (creditNumber == i.CreditNumber)
                {
                    i.Approved = true;
                }
            }
        }

        public void DeclineCredit(string number)
        {
            db.RemoveCredit(number);
        }

        public void ConfirmInstallment(string installmentNumber)
        {
            foreach (Installment i in db.Installments)
            {
                if (installmentNumber == i.InstallmentNumber)
                {
                    i.Approved = true;
                }
            }
        }

        public void DeclineInstallment(string number)
        {
            db.RemoveInstallment(number);
        }

        public void DeclineOperation() { }
    }
}

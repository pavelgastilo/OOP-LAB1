using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Credit : ICreditInstallment
    {
        public string Id { get; set; }
        public string CreditNumber { get; set; }
        public string UserID { get; set; }
        public int[] Months = { 3, 6, 12, 24, 36 };
        public double Sum { get; set; }
        double[] Percents = { 2.3, 3.7, 4.8, 7.3 };
        public int Month { get; set; }
        public double Percent { get; set; }
        public string Bank { get; set; }

        public bool Approved = false;
        public bool Cancelled = false;

        public Credit() { }

        public Credit(string userId, string bank, int months, double sum)
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreditNumber = Guid.NewGuid().ToString();
            this.CreditNumber = this.CreditNumber.Substring(0, 8);
            this.UserID = userId;
            this.Bank = bank;
            this.Month = months;
            this.Sum = sum;
            if (this.Sum <= 10000) this.Percent = Percents[0];
            else if (this.Sum <= 30000) this.Percent = Percents[1];
            else if (this.Sum <= 50000) this.Percent = Percents[2];
            else this.Percent = Percents[3];
        }

        public Credit GetCredit(string id, string creditNumber, string userId, string bank, int months, double sum, bool approved = false, bool cancelled = false)
        {
            this.Id = id;
            this.CreditNumber = creditNumber;
            this.UserID = userId;
            this.Bank = bank;
            this.Month = months;
            this.Sum = sum;
            this.Month = months;
            this.Approved = approved;
            this.Cancelled = cancelled;
            if (this.Sum <= 10000) this.Percent = Percents[0];
            else if (this.Sum <= 30000) this.Percent = Percents[1];
            else if (this.Sum <= 50000) this.Percent = Percents[2];
            else this.Percent = Percents[3];

            return this;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Installment : ICreditInstallment
    {
        public string Id { get; set; }
        public string InstallmentNumber { get; set; }
        public string UserID { get; set; }
        public int[] Months = { 3, 6, 12, 24, 36 };
        public double Sum { get; set; }
        double[] Percents = {0, 1.3, 2.4, 3.2, 4.1 };
        public int Month { get; set; }
        public double Percent { get; set; }
        public string Bank { get; set; }

        public bool Approved = false;
        public bool Cancelled = false;

        public Installment() { }
        public Installment(string userId, string bank, int months, double sum)
        {
            this.Id = Guid.NewGuid().ToString();
            this.InstallmentNumber = Guid.NewGuid().ToString();
            this.InstallmentNumber = this.InstallmentNumber.Substring(0, 8);
            this.UserID = userId;
            this.Month = months;
            this.Bank = bank;
            this.Sum = sum;
            if (this.Sum <= 5000) this.Percent = Percents[0];
            else if (this.Sum <= 15000) this.Percent = Percents[1];
            else if (this.Sum <= 30000) this.Percent = Percents[2];
            else if (this.Sum <= 50000) this.Percent = Percents[3];
            else this.Percent = Percents[4];
        }

        public Installment GetInstallment(string id, string installmentNumber, string userId, string bank, int months, double sum, bool apr = false, bool canc = false)
        {
            this.Id = id;
            this.InstallmentNumber = installmentNumber;
            this.UserID = userId;
            this.Bank = bank;
            this.Month = months;
            this.Sum = sum;
            this.Month = months;
            this.Approved = apr;
            this.Cancelled = canc;
            if (this.Sum <= 5000) this.Percent = Percents[0];
            else if (this.Sum <= 15000) this.Percent = Percents[1];
            else if (this.Sum <= 30000) this.Percent = Percents[2];
            else if (this.Sum <= 50000) this.Percent = Percents[3];
            else this.Percent = Percents[4];

            return this;
        }
    }
}

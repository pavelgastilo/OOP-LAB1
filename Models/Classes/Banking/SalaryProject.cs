using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class SalaryProject
    {
        Database db = Program.database;
        public string Id { get; set; }
        public string SalaryProjectNumber { get; set; }
        public string UserID { get; set; }
        public double Sum { get; set; }

        public bool Approved;
        public bool Cancelled;

        public SalaryProject() { }
        public SalaryProject(string userId, double sum)
        {
            this.Id = Guid.NewGuid().ToString();
            this.SalaryProjectNumber = Guid.NewGuid().ToString();
            this.SalaryProjectNumber = this.SalaryProjectNumber.Substring(0, 8);
            this.UserID = userId;
            this.Sum = sum;
        }

        public SalaryProject GetSalaryProject(string id, string salprjNumber, string userId, double sum, bool apprv = false, bool canc = false)
        {
            this.Id = id;
            this.SalaryProjectNumber = salprjNumber;
            this.UserID = userId;
            this.Sum = sum;
            this.Approved = apprv;
            this.Cancelled = canc;

            return this;
        }

    }
}

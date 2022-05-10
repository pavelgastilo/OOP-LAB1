using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class CreditInstallmentController
    {
        Database db = Program.database;
        Credit credit = new Credit();
        Installment installment = new Installment();

        public CreditInstallmentController(){ }

        public void GetMonths(System.Windows.Forms.ComboBox box)
        {
            foreach(int i in credit.Months)
            {
                box.Items.Add(i);
            }
        }
    }
}

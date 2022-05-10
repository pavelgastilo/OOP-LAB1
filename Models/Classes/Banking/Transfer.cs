using System;
using System.Data;
using GenericParsing;
using System.Collections.Generic;
using System.Windows.Forms;


namespace lab1
{
    public class Transfer : ITransfer
    {
        Database db = Program.database;

        public Transfer() { }

        public void TransferTo(string numberSender, string numberOfRecepient, double sum)
        {
            DataRow[] row = db.tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{numberSender}'");
            if (sum <= Convert.ToDouble(row[0]["Sum"]))
            {
                row[0]["Sum"] = Convert.ToDouble(row[0]["Sum"]) - sum;
                row = db.tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{numberOfRecepient}'");
                row[0]["Sum"] = Convert.ToDouble(row[0]["Sum"]) + sum;
                db.UpdateBase();
            }
            else MessageBox.Show("Too big sum for transfer.");
            
        }

    }
}

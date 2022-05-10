using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class OperatorController
    {
        Database db = Program.database;
        public Operator _operator = null;

        public Operator Operator
        {
            get => default;
            set
            {
            }
        }

        public Operator GetOperator(string login)
        {
            _operator = db.GetOperator(login);
            _operator.Update();
            return _operator;
        }

        public void GetLogs(System.Windows.Forms.RichTextBox rich)
        {
            _operator.GetStatistics();
            foreach (string i in _operator.acclogs) rich.AppendText($"{i}\n");
        }

        public void ConfirmSalaryProject(string number)
        {
            _operator.ConfirmSalaryProject(number);
            db.UpdateConfirmSalPrj(number);
            db.UpdateBase();
        }

        public void DeclineSalaryProject(string number)
        {
            db.UpdateDeclineSalPrj(number);
            //_operator.DeclineSalaryProject(number);
            db.UpdateBase();
        }

        public void GetSalaryProjects(System.Windows.Forms.RichTextBox rich)
        {
            foreach(SalaryProject i in db.SalaryProjects)
            {
                rich.AppendText($"User ID: {i.UserID}\n" +
                    $"Salary project number: {i.SalaryProjectNumber}\n" +
                    $"Sum: {i.Sum}\n");
                if (!(i.Approved) && !(i.Cancelled)) rich.AppendText($"Approve: not approved\n\n");
                else if (i.Approved) rich.AppendText($"Approve: approved\n\n");
                else if (i.Cancelled) rich.AppendText($"Approve: declined\n\n");
            }
        }

        public void GetSalaryProjects(System.Windows.Forms.ComboBox rich)
        {
            foreach (SalaryProject i in db.SalaryProjects)
            {
                rich.Items.Add(i.SalaryProjectNumber);
            }
        }

        public void GetSalPrj(System.Windows.Forms.RichTextBox rich, string number)
        {
            foreach (SalaryProject i in db.SalaryProjects)
            {
                if(i.SalaryProjectNumber == number)
                {
                    rich.AppendText($"User ID: {i.UserID}\n" +
                    $"Salary project number: {i.SalaryProjectNumber}\n" +
                    $"Sum: {i.Sum}\n");
                    if (!(i.Approved) && !(i.Cancelled)) rich.AppendText($"Approve: not approved\n\n");
                    else if (i.Approved) rich.AppendText($"Approve: approved\n\n");
                    else if (i.Cancelled) rich.AppendText($"Approve: declined\n\n");
                }
                
            }
        }
    }
}

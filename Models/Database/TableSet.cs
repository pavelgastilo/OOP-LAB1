using System.Data;

namespace lab1
{
    public class TableSet
    {
        public DataSet Data = new DataSet();

        public void SetColumn(string type, string variable, DataTable table, DataColumn column, bool unique = false)
        {
            column = new DataColumn();
            column.DataType = System.Type.GetType($"System.{type}");
            column.ColumnName = $"{variable}";
            column.ReadOnly = false;
            column.Unique = unique;
            table.Columns.Add(column);
        }
        public void CreateClientTable()
        {
            DataTable table = new DataTable("Clients");
            DataColumn column = new DataColumn();

            SetColumn("String", "UserID", table, column, true);
            SetColumn("String", "Login", table, column, true);
            SetColumn("String", "Password", table, column);
            SetColumn("String", "Name", table, column);
            SetColumn("String", "SecondName", table, column);
            SetColumn("String", "Patronymic", table, column);
            SetColumn("String", "PhoneNumber", table, column);
            SetColumn("String", "Email", table, column);
            SetColumn("String", "Passport", table, column, true);
            SetColumn("String", "IdNumb", table, column);
            SetColumn("String", "Country", table, column);
            SetColumn("String", "Company", table, column);
            SetColumn("Boolean", "Approved", table, column);
            SetColumn("Boolean", "Cancelled", table, column);

            Data.Tables.Add(table);
        }

        public void CreateOperatorTable()
        {
            DataTable table = new DataTable("Operators");
            DataColumn column = new DataColumn();

            SetColumn("String", "UserID", table, column, true);
            SetColumn("String", "Login", table, column, true);
            SetColumn("String", "Password", table, column);

            Data.Tables.Add(table);
        }

        public void CreateManagerTable()
        {
            DataTable table = new DataTable("Managers");
            DataColumn column = new DataColumn();

            SetColumn("String", "UserID", table, column, true);
            SetColumn("String", "Login", table, column, true);
            SetColumn("String", "Password", table, column);

            Data.Tables.Add(table);
        }

        public void CreateAdminTable()
        {
            DataTable table = new DataTable("Admins");
            DataColumn column = new DataColumn();

            SetColumn("String", "UserID", table, column, true);
            SetColumn("String", "Login", table, column, true);
            SetColumn("String", "Password", table, column);

            Data.Tables.Add(table);
        }

        public void CreateAnotherSpecialistTable()
        {
            DataTable table = new DataTable("AnotherSpecialists");
            DataColumn column = new DataColumn();

            SetColumn("String", "UserID", table, column, true);
            SetColumn("String", "Login", table, column, true);
            SetColumn("String", "Password", table, column);
            SetColumn("String", "CompanyName", table, column);

            Data.Tables.Add(table);
        }

        public void CreateAccountTable()
        {
            DataTable table = new DataTable("Accounts");
            DataColumn column = new DataColumn();

                 
            SetColumn("String", "Id", table, column, true);
            SetColumn("String", "AccountNumber", table, column, true);
            SetColumn("String", "UserID", table, column);
            SetColumn("String", "BankName", table, column);
            SetColumn("String", "CompanyName", table, column);
            SetColumn("Double", "Sum", table, column);
            SetColumn("Double", "SavingSum", table, column);
            SetColumn("Double", "AccumulationSum", table, column);
            SetColumn("Boolean", "Active", table, column);
            


            Data.Tables.Add(table);
        }

        public void CreateBankTable()
        {
            DataTable table = new DataTable("Banks");
            DataColumn column = new DataColumn();

            SetColumn("String", "Name", table, column, true);

            Data.Tables.Add(table);
        }

        public void CreateCreditTable()
        {
            DataTable table = new DataTable("Credits");
            DataColumn column = new DataColumn();
            
            SetColumn("String", "Id", table, column, true);
            SetColumn("String", "CreditNumber", table, column, true);
            SetColumn("String", "UserID", table, column);
            SetColumn("Int16", "Months", table, column);
            SetColumn("Double", "Sum", table, column);
            SetColumn("Double", "Percent", table, column);
            SetColumn("String", "Bank", table, column);
            SetColumn("Boolean", "Approved", table, column);
            SetColumn("Boolean", "Cancelled", table, column);

            Data.Tables.Add(table);
        }

        public void CreateInstallmentTable()
        {
            DataTable table = new DataTable("Installments");
            DataColumn column = new DataColumn();

            SetColumn("String", "Id", table, column, true);
            SetColumn("String", "InstallmentNumber", table, column, true);
            SetColumn("String", "UserID", table, column);
            SetColumn("Int16", "Months", table, column);
            SetColumn("Double", "Sum", table, column);
            SetColumn("Double", "Percents", table, column);
            SetColumn("String", "Bank", table, column);
            SetColumn("Boolean", "Approved", table, column);
            SetColumn("Boolean", "Cancelled", table, column);


            Data.Tables.Add(table);
        }

        public void CreateSalaryProjectTable()
        {
            DataTable table = new DataTable("SalaryProjects");
            DataColumn column = new DataColumn();

            SetColumn("String", "Id", table, column, true);
            SetColumn("String", "SalaryProjectNumber", table, column, true);
            SetColumn("String", "UserID", table, column);
            SetColumn("Double", "Sum", table, column);
            SetColumn("Boolean", "Approved", table, column);
            SetColumn("Boolean", "Cancelled", table, column);

            Data.Tables.Add(table);
        }

        public void CreateCompanyTable()
        {
            DataTable table = new DataTable("Companies");
            DataColumn column = new DataColumn();

            SetColumn("String", "CompanyId", table, column, true);
            SetColumn("String", "Type", table, column);
            SetColumn("String", "Name", table, column);
            SetColumn("String", "PAN", table, column, true);
            SetColumn("String", "BIC", table, column, true);
            SetColumn("String", "Adress", table, column);

            Data.Tables.Add(table);
        }

       
    }
}

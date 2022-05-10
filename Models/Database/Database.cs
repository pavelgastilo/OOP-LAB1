using System;
using System.Data;
using GenericParsing;
using System.Collections.Generic;
using System.IO;

namespace lab1
{
    public class Database
    {
        public TableSet tableSet = new TableSet();

        public List<Bank> Banks = new List<Bank>();
        public List<Account> Accounts = new List<Account>();
        public List<Credit> Credits = new List<Credit>();
        public List<Installment> Installments = new List<Installment>();
        public List<Client> Clients = new List<Client>();
        public List<SalaryProject> SalaryProjects = new List<SalaryProject>();
        public List<Company> Companies = new List<Company>();
        public List<Operator> Operators = new List<Operator>();
        public List<Manager> Managers = new List<Manager>();
        public List<Admin> Admins = new List<Admin>();
        public List<AnotherSpecialist> AnotherSpecialists = new List<AnotherSpecialist>();

        public Database() 
        {
            GetData();
        }

        public void GetData()
        {
            tableSet.CreateClientTable();
            tableSet.CreateAccountTable();
            tableSet.CreateBankTable();
            tableSet.CreateCreditTable();
            tableSet.CreateInstallmentTable();
            tableSet.CreateSalaryProjectTable();
            tableSet.CreateCompanyTable();
            tableSet.CreateAdminTable();
            tableSet.CreateAnotherSpecialistTable();
            tableSet.CreateManagerTable();
            tableSet.CreateOperatorTable();
            using (GenericParser parser = new GenericParser())
            {
                

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';
                
                parser.SetDataSource("Accounts.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["Accounts"].Rows.Add(new object[] { parser["Id"], parser["AccountNumber"], 
                        parser["UserID"], parser["BankName"], parser["CompanyName"], parser["Sum"], parser["SavingSum"], parser["AccumulationSum"], parser["Active"] });
                    Accounts.Add(GetAccount(parser["AccountNumber"]));
                }
                parser.SetDataSource("Credits.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["Credits"].Rows.Add(new object[] { parser["Id"], parser["CreditNumber"],
                        parser["UserID"], parser["Months"], parser["Sum"], parser["Percents"],parser["Bank"], parser["Approved"], parser["Cancelled"] });
                    Credits.Add(GetCredit(parser["CreditNumber"]));
                }
                parser.SetDataSource("Installments.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["Installments"].Rows.Add(new object[] { parser["Id"], parser["InstallmentNumber"],
                        parser["UserID"], parser["Months"], parser["Sum"], parser["Percents"],parser["Bank"], parser["Approved"], parser["Cancelled"] });
                    Installments.Add(GetInstallment(parser["InstallmentNumber"]));
                }
                parser.SetDataSource("Banks.txt");
                while(parser.Read())
                {
                    tableSet.Data.Tables["Banks"].Rows.Add(new object[] { parser["Name"] });
                    Banks.Add(GetBank(parser["name"]));
                }
                parser.SetDataSource("SalaryProjects.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["SalaryProjects"].Rows.Add(new object[] { parser["Id"], parser["SalaryProjectNumber"],
                        parser["UserID"], parser["Sum"], parser["Approved"], parser["Cancelled"] });
                    SalaryProjects.Add(GetSalaryProject(parser["SalaryProjectNumber"]));
                }
                parser.SetDataSource("Companies.txt");
                {
                    tableSet.Data.Tables["Companies"].Rows.Add(new object[] { parser["CompanyId"], parser["Type"],
                        parser["Name"], parser["PAN"], parser["BIC"], parser["Adress"] });
                    Companies.Add(GetCompany(parser["Name"]));
                }
                parser.SetDataSource("Clients.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["Clients"].Rows.Add(new object[] { parser["UserID"], parser["Login"],
                        parser["Password"], parser["Name"], parser["SecondName"],
                        parser["Patronymic"], parser["PhoneNumber"], parser["Email"],
                        parser["Passport"], parser["IdNumb"], parser["Country"], parser["Company"], parser["Approved"], parser["Cancelled"] });

                    Clients.Add(GetClient(parser["Login"]));
                }
                parser.SetDataSource("Operators.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["Operators"].Rows.Add(new object[] { parser["UserID"], parser["Login"],
                        parser["Password"]});

                    Operators.Add(GetOperator(parser["Login"]));
                }
                parser.SetDataSource("Managers.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["Managers"].Rows.Add(new object[] { parser["UserID"], parser["Login"],
                        parser["Password"]});

                    Managers.Add(GetManager(parser["Login"]));
                }
                parser.SetDataSource("Admins.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["Admins"].Rows.Add(new object[] { parser["UserID"], parser["Login"],
                        parser["Password"]});

                    Admins.Add(GetAdmin(parser["Login"]));
                }
                parser.SetDataSource("AnotherSpecialists.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["AnotherSpecialists"].Rows.Add(new object[] { parser["UserID"], parser["Login"],
                        parser["Password"], parser["CompanyName"]});

                    AnotherSpecialists.Add(GetAnotherSpecialist(parser["Login"]));
                }
            }

        }
        public void UpdateBase()
        {
            Accounts = new List<Account>();
            Credits = new List<Credit>();
            Installments = new List<Installment>();
            SalaryProjects = new List<SalaryProject>();
            DataRow[] row = tableSet.Data.Tables["Accounts"].Select();
            for(int i = 0; i < row.Length; i++)
            {
                Accounts.Add(GetAccount(row[i]["AccountNumber"].ToString()));
            }
            row = tableSet.Data.Tables["Credits"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                Credits.Add(GetCredit(row[i]["CreditNumber"].ToString()));
            }
            row = tableSet.Data.Tables["Installments"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                Installments.Add(GetInstallment(row[i]["InstallmentNumber"].ToString()));
            }
            row = tableSet.Data.Tables["SalaryProjects"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                SalaryProjects.Add(GetSalaryProject(row[i]["SalaryProjectNumber"].ToString()));
            }
        }
        public void AddClient(string userId, string login, string password, string firstName, string secondName, string patronymic, string phoneNumber, string email, string passport, string idNumb, string country, string company, bool apprv = true, bool cancl = false)
        {
            tableSet.Data.Tables["Clients"].Rows.Add(new object[] 
            {
                userId,
                login, 
                password, 
                firstName, 
                secondName, 
                patronymic, 
                phoneNumber, 
                email, 
                passport, 
                idNumb, 
                country, 
                company,
                apprv,
                cancl
            });
            Clients.Add(new Client().GetClient(
                userId,
                login,
                password,
                firstName,
                secondName,
                patronymic,
                phoneNumber,
                email,
                passport,
                idNumb,
                country,
                company,
                apprv,
                cancl
                ));
            File.AppendAllText("AllLogs.txt", $"The client {userId} was added.\n");
        }

        public void AddAccount(string id, string accNum, string userId, string bankname,string companyName, double sum, double savsum, double accsum, bool active = true)
        {
            tableSet.Data.Tables["Accounts"].Rows.Add(new object[]
            {
                id,
                accNum,
                userId,
                bankname,
                companyName,
                sum,
                savsum,
                accsum,
                active
            });

            Accounts.Add(new Account().GetAccount
            (
                id,
                accNum,
                userId,
                sum,
                savsum,
                accsum,
                bankname,
                companyName,
                active
            ));
            File.AppendAllText("AllLogs.txt", $"The account {accNum} was created.\n");
            File.AppendAllText("AccountLogs.txt", $"The account {accNum} was created.\n");
        }

        public void AddBank (string name)
        {
            tableSet.Data.Tables["Banks"].Rows.Add(new object[]
                {
                name
            });
            Banks.Add(new Bank().GetBank
                (
                name
                ));
        }

        public void AddCompany(string id, string type, string name, string PAN, string BIN, string Adress)
        {
            tableSet.Data.Tables["Companies"].Rows.Add(new object[]
                {
                 id,
                 type, 
                 name, 
                 PAN, 
                 BIN,
                 Adress
            });
            Companies.Add(new Company().GetCompany(
                id,
                type,
                name,
                PAN,
                BIN,
                Adress
                ));
        }

        public void AddCredit(string id, string crNum, string userId, int month, double sum, double percent,string bankname, bool approved = false, bool cancelled = false)  
        {
            tableSet.Data.Tables["Credits"].Rows.Add(new object[]
                {
                id,
                crNum,
                userId,
                month,
                sum,
                percent,
                bankname,
                approved,
                cancelled
            });
            Credits.Add(new Credit().GetCredit(
                id,
                crNum,
                userId,
                bankname,
                month,
                sum
                ));
            File.AppendAllText("AllLogs.txt", $"The credit {crNum} was added.\n");
        }

        public void AddInstallmet(string id, string instNum, string userId, int month, double sum, double percent,string bankname, bool approved = false, bool cancelled = false)
        {
            tableSet.Data.Tables["Installments"].Rows.Add(new object[]
                {
                id,
                instNum,
                userId,
                month,
                sum,
                percent,
                bankname,
                approved,
                cancelled
            });
            Installments.Add(new Installment().GetInstallment(
                id,
                instNum,
                userId,
                bankname,
                month,
                sum
                ));
            File.AppendAllText("AllLogs.txt", $"The installment {instNum} was added.\n");
        }

        public void AddSalaryProect(string id, string salNum, string userId, double sum, bool approved = false, bool cancelled = false)
        {
            tableSet.Data.Tables["SalaryProjects"].Rows.Add(new object[]
                {
                id,
                salNum,
                userId,
                sum,
                approved,
                cancelled
            });
            SalaryProjects.Add(new SalaryProject().GetSalaryProject(
                id,
                salNum,
                userId,
                sum
                ));
            File.AppendAllText("AllLogs.txt", $"The salary project {salNum} was added.\n");
        }


        public Client FindByLoginAndPassword(string login, string password)
        {
            Client FClient = new Client();
            DataRow[] row = tableSet.Data.Tables["Clients"].Select(" login = '" + login + "' AND Password = '" + password + "'");

            if (row.Length != 0)
            {
                FClient.GetClient(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"]),
                   Convert.ToString(row[0]["Name"]),
                   Convert.ToString(row[0]["SecondName"]),
                   Convert.ToString(row[0]["Patronymic"]),
                   Convert.ToString(row[0]["PhoneNumber"]),
                   Convert.ToString(row[0]["Email"]),
                   Convert.ToString(row[0]["Passport"]),
                   Convert.ToString(row[0]["IdNumb"]),
                   Convert.ToString(row[0]["Country"]),
                   Convert.ToString(row[0]["Company"])
                );
            }
            return FClient;
        }

        public Client GetClient(string login)
        {
            Client FClient = new Client();
            DataRow[] row = tableSet.Data.Tables["Clients"].Select($" login = '{login}'");

            if (row.Length != 0)
            {
                FClient.GetClient(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"]),
                   Convert.ToString(row[0]["Name"]),
                   Convert.ToString(row[0]["Secondname"]),
                   Convert.ToString(row[0]["Patronymic"]),
                   Convert.ToString(row[0]["PhoneNumber"]),
                   Convert.ToString(row[0]["Email"]),
                   Convert.ToString(row[0]["Passport"]),
                   Convert.ToString(row[0]["IdNumb"]),
                   Convert.ToString(row[0]["Country"]),
                   Convert.ToString(row[0]["Company"])
                );
            }
            return FClient;
        }

        public Operator GetOperator(string login)
        {
            Operator New = new Operator();
            DataRow[] row = tableSet.Data.Tables["Operators"].Select($" login = '{login}'");

            if (row.Length != 0)
            {
                New.GetOperator(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"])
                );
            }
            return New;
        }

        public Operator GetOperator(string login, string password)
        {
            Operator New = new Operator();
            DataRow[] row = tableSet.Data.Tables["Operators"].Select($" login = '{login}' AND Password = '{password}'");

            if (row.Length != 0)
            {
                New.GetOperator(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"])
                );
            }
            return New;
        }

        public Manager GetManager(string login)
        {
            Manager New = new Manager();
            DataRow[] row = tableSet.Data.Tables["Managers"].Select($" login = '{login}'");

            if (row.Length != 0)
            {
                New.GetManager(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"])
                );
            }
            return New;
        }

        public Manager GetManager(string login,string password)
        {
            Manager New = new Manager();
            DataRow[] row = tableSet.Data.Tables["Managers"].Select($" login = '{login}' AND Password = '{password}'");

            if (row.Length != 0)
            {
                New.GetManager(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"])
                );
            }
            return New;
        }

        public Admin GetAdmin(string login)
        {
            Admin New = new Admin();
            DataRow[] row = tableSet.Data.Tables["Admins"].Select($" login = '{login}'");

            if (row.Length != 0)
            {
                New.GetAdmin(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"])
                );
            }
            return New;
        }

        public Admin GetAdmin(string login, string password)
        {
            Admin New = new Admin();
            DataRow[] row = tableSet.Data.Tables["Admins"].Select($" login = '{login}' AND Password = '{password}'");

            if (row.Length != 0)
            {
                New.GetAdmin(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"])
                );
            }
            return New;
        }

        public AnotherSpecialist GetAnotherSpecialist(string login)
        {
            AnotherSpecialist New = new AnotherSpecialist();
            DataRow[] row = tableSet.Data.Tables["AnotherSpecialists"].Select($" login = '{login}'");

            if (row.Length != 0)
            {
                New.GetAnotherSpecialist(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"]),
                   Convert.ToString(row[0]["CompanyName"])
                );
            }
            return New;
        }

        public AnotherSpecialist GetAnotherSpecialist(string login,string password)
        {
            AnotherSpecialist New = new AnotherSpecialist();
            DataRow[] row = tableSet.Data.Tables["AnotherSpecialists"].Select($" login = '{login}' AND Password = '{password}'");

            if (row.Length != 0)
            {
                New.GetAnotherSpecialist(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"]),
                   Convert.ToString(row[0]["CompanyName"])
                );
            }
            return New;
        }

        public Company GetCompany(string companyName)
        {
            Company New = new Company();
            DataRow[] row = tableSet.Data.Tables["Companies"].Select($"Name = '{companyName}'");
            if (row.Length != 0)
            {
                New.GetCompany(
                    Convert.ToString(row[0]["CompanyId"]),
                    Convert.ToString(row[0]["Type"]),
                    Convert.ToString(row[0]["Name"]),
                    Convert.ToString(row[0]["PAN"]),
                    Convert.ToString(row[0]["BIC"]),
                    Convert.ToString(row[0]["Adress"])
                    );
            }
            return New;
        }

        public Account GetAccount(string accountNumber)
        {
            Account New = new Account();
            DataRow[] row = tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{accountNumber}'");
            if (row.Length != 0)
            {
                New.GetAccount(
                    Convert.ToString(row[0]["Id"]),
                    Convert.ToString(row[0]["AccountNumber"]),
                    Convert.ToString(row[0]["UserID"]),
                    Convert.ToDouble(row[0]["Sum"]),
                    Convert.ToDouble(row[0]["SavingSum"]),
                    Convert.ToDouble(row[0]["AccumulationSum"]),
                    Convert.ToString(row[0]["BankName"]),
                    Convert.ToString(row[0]["CompanyName"]),
                    Convert.ToBoolean(row[0]["Active"])
                    );
            }
            return New;
        }

        public Credit GetCredit(string creditNumber)
        {
            Credit New = new Credit();
            DataRow[] row = tableSet.Data.Tables["Credits"].Select($"CreditNumber = '{creditNumber}'");
            if (row.Length != 0)
            {
                New.GetCredit(
                    Convert.ToString(row[0]["Id"]),
                    Convert.ToString(row[0]["CreditNumber"]),
                    Convert.ToString(row[0]["UserID"]),
                    Convert.ToString(row[0]["Bank"]),
                    Convert.ToInt16(row[0]["Months"]),
                    Convert.ToDouble(row[0]["Sum"]),
                    Convert.ToBoolean(row[0]["Approved"]),
                    Convert.ToBoolean(row[0]["Cancelled"])
                    );
            }
            return New;
        }

        public Installment GetInstallment(string installmentNumber)
        {
            Installment New = new Installment();
            DataRow[] row = tableSet.Data.Tables["Installments"].Select($"InstallmentNumber = '{installmentNumber}'");
            if (row.Length != 0)
            {
                New.GetInstallment(
                    Convert.ToString(row[0]["Id"]),
                    Convert.ToString(row[0]["InstallmentNumber"]),
                    Convert.ToString(row[0]["UserID"]),
                    Convert.ToString(row[0]["Bank"]),
                    Convert.ToInt16(row[0]["Months"]),
                    Convert.ToDouble(row[0]["Sum"]),
                    Convert.ToBoolean(row[0]["Approved"]),
                    Convert.ToBoolean(row[0]["Cancelled"])
                    );
            }
            return New;
        }

        public SalaryProject GetSalaryProject(string salprjNumber)
        {
            SalaryProject New = new SalaryProject();
            DataRow[] row = tableSet.Data.Tables["SalaryProjects"].Select($"SalaryProjectNumber = '{salprjNumber}'");
            if (row.Length != 0)
            {
                New.GetSalaryProject(
                    Convert.ToString(row[0]["Id"]),
                    Convert.ToString(row[0]["SalaryProjectNumber"]),
                    Convert.ToString(row[0]["UserID"]),
                    Convert.ToDouble(row[0]["Sum"]),
                    Convert.ToBoolean(row[0]["Approved"]),
                    Convert.ToBoolean(row[0]["Cancelled"])
                    );
            }
            return New;
        }

        public void RemoveAccount(string accountNumber)
        {
            DataRow[] row = tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{accountNumber}'");
            Account del = GetAccount(accountNumber);
            row[0].Delete();
            File.AppendAllText("AllLogs.txt", $"The account {del.AccountNumber} was deleted.\n");
            File.AppendAllText("AccountLogs.txt", $"The account {del.AccountNumber} was deleted.\n");
            tableSet.Data.Tables["Accounts"].AcceptChanges();
            Accounts.Remove(del);
           
        }

        public void RemoveCredit(string creditNumber)
        {
            DataRow[] row = tableSet.Data.Tables["Credits"].Select($"CreditNumber = '{creditNumber}'");
            Credit del = GetCredit(creditNumber);
            row[0].Delete();
            File.AppendAllText("AllLogs.txt", $"The credit {del.CreditNumber} was deleted.\n");
            tableSet.Data.Tables["Credits"].AcceptChanges();
            Credits.Remove(del);
        }

        public void RemoveInstallment(string installmentNumber)
        {
            DataRow[] row = tableSet.Data.Tables["Installments"].Select($"InstallmentNumber = '{installmentNumber}'");
            Installment del = GetInstallment(installmentNumber);
            row[0].Delete();
            File.AppendAllText("AllLogs.txt", $"The installmet {del.InstallmentNumber} was deleted.\n");
            tableSet.Data.Tables["Installments"].AcceptChanges();
            Installments.Remove(del);
        }

        public void RemoveSalaryProject(string salprjNimber)
        {
            DataRow[] row = tableSet.Data.Tables["SalaryProjects"].Select($"SalaryProjectNumber = '{salprjNimber}'");
            SalaryProject del = GetSalaryProject(salprjNimber);
            row[0].Delete();
            File.AppendAllText("AllLogs.txt", $"The salary project {del.SalaryProjectNumber} was deleted.\n");
            tableSet.Data.Tables["SalaryProjects"].AcceptChanges();
            SalaryProjects.Remove(del);
        }

        public void SetBanks(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = tableSet.Data.Tables["Banks"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                comboBox.Items.Add(row[i]["Name"]);
            }
        }

        public Bank GetBank(string name)
        {
            Bank bank = new Bank();

            DataRow[] row = tableSet.Data.Tables["Banks"].Select($"Name = '{name}'");
            if(row.Length != 0)
            {
                bank.GetBank(
                    Convert.ToString(row[0]["Name"])
                    );
            }
            return bank;
        }

        public void UpdateOnSaving(string number, double sum)
        {
            DataRow[] row = tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{number}'");
            row[0]["Sum"] = Convert.ToDouble(row[0]["Sum"]) - sum;
            row[0]["SavingSum"] = Convert.ToDouble(row[0]["SavingSum"]) + sum;
            row[0].AcceptChanges();
            File.AppendAllText("AllLogs.txt", $"The account {number} updated saving sum.\n");
            File.AppendAllText("AccountLogs.txt", $"The account {number} updated saving sum.\n");
        }

        public void UpdateAccum(string number, double sum, double percent)
        {
            DataRow[] row = tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{number}'");
            row[0]["Sum"] = Convert.ToDouble(row[0]["Sum"]) - sum;
            row[0]["AccumulationSum"] = Convert.ToDouble(row[0]["AccumulationSum"]) + sum + sum*0.01*percent;
            row[0].AcceptChanges();
            File.AppendAllText("AllLogs.txt", $"The account {number} updated accumulation sum.\n");
            File.AppendAllText("AccountLogs.txt", $"The account {number} updated accumulation sum.\n");
        }

        public void UpdateCashOut(string number, double sum)
        {
            DataRow[] row = tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{number}'");
            row[0]["Sum"] = Convert.ToDouble(row[0]["Sum"]) - sum;
            row[0].AcceptChanges();
            File.AppendAllText("AllLogs.txt", $"The account {number} cashed out some money.\n");
            File.AppendAllText("AccountLogs.txt", $"The account {number} cashed out some money.\n");
        }

        public void UpdateFreeze(string number)
        {
            DataRow[] row = tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{number}'");
            row[0]["Active"] = false;
            File.AppendAllText("AllLogs.txt", $"The account {number} was freezed.\n");
            File.AppendAllText("AccountLogs.txt", $"The account {number} was freezed.\n");
        }

        public void UpdateUnfreeze(string number)
        {
            DataRow[] row = tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{number}'");
            row[0]["Active"] = true;
            File.AppendAllText("AllLogs.txt", $"The account {number} was unfreezed.\n");
            File.AppendAllText("AccountLogs.txt", $"The account {number} was unfreezed.\n");
        }

        public void UpdateConfirmSalPrj(string number)
        {
            DataRow[] row = tableSet.Data.Tables["SalaryProjects"].Select($"SalaryProjectNumber = '{number}'");
            row[0]["Approved"] = true;
            row[0]["Cancelled"] = false;
            File.AppendAllText("AllLogs.txt", $"The salary project {number} was confirmed.\n");
        }

        public void UpdateDeclineSalPrj(string number)
        {
            DataRow[] row = tableSet.Data.Tables["SalaryProjects"].Select($"SalaryProjectNumber = '{number}'");
            row[0]["Approved"] = false;
            row[0]["Cancelled"] = true;
            File.AppendAllText("AllLogs.txt", $"The salary project {number} was declined.\n");
        }

        public void UpdateConfirmCredit(string number)
        {
            DataRow[] row = tableSet.Data.Tables["Credits"].Select($"CreditNumber = '{number}'");
            row[0]["Approved"] = true;
            row[0]["Cancelled"] = false;
            File.AppendAllText("AllLogs.txt", $"The credit {number} was confirmed.\n");
        }

        public void UpdateDeclineCredit(string number)
        {
            DataRow[] row = tableSet.Data.Tables["Credits"].Select($"CreditNumber = '{number}'");
            row[0]["Approved"] = false;
            row[0]["Cancelled"] = true;
            File.AppendAllText("AllLogs.txt", $"The credit {number} was declined.\n");
        }

        public void UpdateConfirmInstallment(string number)
        {
            DataRow[] row = tableSet.Data.Tables["Installments"].Select($"InstallmentNumber = '{number}'");
            row[0]["Approved"] = true;
            row[0]["Cancelled"] = false;
            File.AppendAllText("AllLogs.txt", $"The installment {number} was confirmed.\n");
        }

        public void UpdateDeclineInstallment(string number)
        {
            DataRow[] row = tableSet.Data.Tables["Installments"].Select($"InstallmentNumber = '{number}'");
            row[0]["Approved"] = false;
            row[0]["Cancelled"] = true;
            File.AppendAllText("AllLogs.txt", $"The installment {number} was declined.\n");
        }

        /*public List<Account> GetAccounts()
        {
            List<Account> list = new List<Account>();
            DataRow[] row = tableSet.Data.Tables["Accounts"].Select();
            for(int i = 0; i < row.Length; i++)
            {
                list.Add(new Account().GetAccount(
                    Convert.ToString(row[i]["Id"]),
                    Convert.ToString(row[i]["AccountNumber"]),
                    Convert.ToString(row[i]["UserID"]),
                    Convert.ToDouble(row[i]["Sum"]),
                    Convert.ToDouble(row[i]["SavingSum"]),
                    Convert.ToDouble(row[i]["AccumulationSum"]),
                    Convert.ToString(row[i]["BankName"]),
                    Convert.ToString(row[i]["CompanyName"]),
                    Convert.ToBoolean(row[i]["Active"])
                    ));
            }
            return list;
        }*/
    }
}

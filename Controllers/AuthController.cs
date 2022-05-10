using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class AuthController
    {
        Database db = Program.database;
        public AuthController() { }

        public Client Auth(string login, string password)
        {
            return db.FindByLoginAndPassword(login, password);
        }

        public Operator AuthOp(string login, string password)
        {
            return db.GetOperator(login, password);
        }

        public Manager AuthMan(string login, string password)
        {
            return db.GetManager(login, password);
        }

        public Admin AuthAdm(string login, string password)
        {
            return db.GetAdmin(login, password);
        }

        public AnotherSpecialist AuthAnSp(string login, string password)
        {
            return db.GetAnotherSpecialist(login, password);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab1
{
    public class Admin : Manager, IAdmin
    {
        public List<string> logs = new List<string>();

        public Admin() { }

        public Admin(string login, string password)
        {
            this.UserID = Guid.NewGuid().ToString();
            this.Login = login;
            this.Password = password;
        }

        public Admin GetAdmin(string id, string login, string password)
        {
            this.UserID = id;
            this.Login = login;
            this.Password = password;

            return this;
        }

        public void CheckAllLogs()
        {
            foreach (string i in File.ReadAllLines("AllLogs.txt")) logs.Add(i);
        }

        public void DeclineAllActions()
        {

        }
    }
}

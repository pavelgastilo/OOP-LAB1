using System.Data;

namespace lab1
{
    public class RegistrationController
    {
        Database db = Program.database;

        public RegistrationController() {}

        public void RegistrateClient(string id, string login, string password, string firstName, string secondName, string patronymic, string phoneNumber, string email, string passport, string idNumb, string country, string company)
        {
            db.AddClient(
                id,
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
                company);
        }
    }
}

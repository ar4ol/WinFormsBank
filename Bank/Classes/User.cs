using System;
using System.IO;

namespace Bank
{
    //Клас Користувач
    class User
    {
        public string id; //номер особового рахунку
        public string login; //логін
        public string password; //пароль
        public string name; //прізвище
        public string firstName; //ім’я
        public string birthday; //дата народження
        public string passNumber; //номер паспорту
        public string keyWord; //ключове слово
        public Account account; //аккаунт користувача
                                //конструктор з номером особового рахунку
        public User(string id)
        {
            this.id = id;
            account = new Account(id);
        }
        //оновлення значень полів цього классу
        public void Update()
        {
            account = new Account(id);
            StreamReader sr = new StreamReader(
                "C:\\Users\\Artem\\Desktop" +
                "\\Bank\\Bank\\DB\\" + id + ".txt");
            string s = sr.ReadLine();
            string[] data = s.Split(new char[] { ' ' });
            login = data[0];
            password = data[1];
            name = data[2];
            firstName = data[3];
            birthday = data[4];
            passNumber = data[5];
            keyWord = data[6];
            if (data[7] == "Кредитная")
            {
                account.category = data[7] + " " + data[8];
                account.ammount = data[9];
                account.openCreditOrEnroll_Date = data[10];
                account.procentOrAmount_Enroll = data[11];
                account.dayStart = data[12];
                account.yearStart = data[13];
            }
            else
            {
                account.category = data[7];
                account.ammount = data[8];
                account.openCreditOrEnroll_Date = data[9];
                account.procentOrAmount_Enroll = data[10];
                account.dayStart = data[11];
                account.yearStart = data[12];
            }
            sr.Close();
        }
        //запис у файл всієї інформації про користувача
        public void ReWrite()
        {
            StreamWriter sw1 = new StreamWriter(
               "C:\\Users\\Artem\\Desktop" +
                "\\Bank\\Bank\\DB\\" + id + ".txt", false);
            sw1.Write(userData());
            sw1.Close();
        }
        //метод який повертає усю інф. про користувача  
        public string userData()
        {
            return $"{login} {password} {name}" +
                $" {firstName} {birthday}" +
                $" {passNumber} {keyWord}" +
                $" {account.category}" +
                $" {account.ammount} " +
                $"{account.openCreditOrEnroll_Date}" +
                $" {account.procentOrAmount_Enroll}" +
                $" {account.dayStart}" +
                $" {account.yearStart}";
        }
    }
}



using System;
using System.IO;

namespace Bank
{
    //класс Аккаунт
    class Account
    {
        public string id; //номер особового рахунку
        public string category; //тип рахунку
        public string ammount; //залишок на рахунку
                               //Для депозиту – дата нарахування відсотків
                               //Для кредиту – дата відкриття кредиту 
        public string openCreditOrEnroll_Date;
        //Для депозиту – залишок після нарахування 			//відсотків
        //Для кредиту – кількість нарохованих відсотків 		//по кредиту 
        public string procentOrAmount_Enroll;
        public string dayStart; //день відкриття рах.
        public string yearStart; //рік відкриття рах.
                                 //конструктор який приймає номер рахунку
        public Account(string id)
        {
            this.id = id;
        }
    }
}


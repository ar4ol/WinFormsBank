using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new authorizationForm());
        }
    }

    public class stringDate
    {
        public static string date()
        {
            int day = System.DateTime.Now.Day;
            int month = System.DateTime.Now.Month;
            string Day = day + "";
            string Month = month + "";
            if (day < 10)
                Day = "0" + day;
            if (month < 10)
                Month = "0" + month;
            return $"{Day}.{Month}.{System.DateTime.Now.Year}";
        }
    }
}

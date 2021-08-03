using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Bank
{
    public partial class accountForm : Form
    {
        private Point mouseLocation;
        private User user;
        public accountForm()
        {
            InitializeComponent();
        }
               
        public accountForm(string id)
        {
            InitializeComponent();
            User user = new User(id);
            user.Update();
            this.user = user;
            checkDeposit();
            checkCredit();
            fillForm();
        }          
                
        private void addButton_Click(object sender, EventArgs e)
        {
            if(addValidate()) addMoney();       
        }       
    
        private void removeButton_Click(object sender, EventArgs e)
        {
            if(removeValidate()) removeMoney();
        }
        
       
        private void moneyAddBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) 
                || char.IsLetter(e.KeyChar) 
                || e.KeyChar == (char)Keys.Back)
                return;
            e.Handled = true;
        }

        private void moneyRemoveBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) 
                || char.IsLetter(e.KeyChar) 
                || e.KeyChar == (char)Keys.Back)
                return;
            e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(36, 47, 61);
            button4.ForeColor = Color.FromArgb(74, 88, 101);
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.FromArgb(255, 11, 17);
            button4.ForeColor = Color.White;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(74, 88, 101);
        }

        private void accountForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void accountForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        //перевірка чи можна поповнити рахунок
        private bool addValidate()
        {
            if (moneyAddBox.Text.Length >= 7 || moneyAddBox.Text == "0")
            {
                moneyAddBox.Text = "";
                MessageBox.Show("Возможная сумма пополнения за раз от 1 до 999999.");
                return false;
            }

            if (textBox2.Text != user.password)
            {
                textBox2.Text = "";
                MessageBox.Show("Неправильный пароль!");
                return false;
            }
            return true;
        }

        //перевірка на необхідність нарахування відсотків по депозиту
        private void checkDeposit()
        {
            if (user.account.category == "Депозит(20%)")
            {
                try
                {
                    int year = int.Parse(user.account.yearStart);
                    int day = int.Parse(user.account.dayStart);
                    if (year < DateTime.Now.Year && day <= DateTime.Now.DayOfYear)
                    {
                        user.account.category = "Закрыт.";
                        user.account.ammount = user.account.procentOrAmount_Enroll;
                        user.account.openCreditOrEnroll_Date = "отсутствует";
                        user.account.procentOrAmount_Enroll = "отсутствует";
                        user.account.dayStart = "отсутствует";
                        user.account.yearStart = "отсутствует";
                        user.ReWrite();

                    }
                }
                catch { }
            }
        }

        //перевірка на необхідність нарахування відсотків по кредиту
        private void checkCredit()
        {
            if (user.account.category == "Кредитная карта(25%)")
            {
                int moneyNow = 0;
                string[] rowsCount = File.ReadAllLines("C:\\Users\\" +
                "Artem\\Desktop\\Bank\\Bank\\DB\\" + user.account.id + ".txt");
                try
                {
                    moneyNow = Convert.ToInt32(user.account.ammount);
                }
                catch { }
                if (moneyNow < 0)
                {
                    int procentNow = 
                        Convert.ToInt32(user.account.procentOrAmount_Enroll);
                    int yearNow = Convert.ToInt32(DateTime.Now.Year);
                    int previousYear = Convert.ToInt32(user.account.yearStart);
                    int dayOfYearNow = Convert.ToInt32(DateTime.Now.DayOfYear);
                    int previousDayOfYear = Convert.ToInt32(user.account.dayStart);
                    int dayPassed = 
                        (dayOfYearNow + 
                        (365 * (yearNow - previousYear))
                        - previousDayOfYear);
                    double procentEnroll = 
                        Math.Round((-moneyNow) * 0.25 / 360 * dayPassed);
                    user.account.dayStart = dayOfYearNow + "";
                    user.account.yearStart = yearNow + "";
                    user.account.procentOrAmount_Enroll = (procentNow + procentEnroll) + "";
                    user.account.ammount = (moneyNow - procentEnroll) + "";
                    rowsCount[0] = user.userData();
                    File.WriteAllLines("C:\\Users\\" +
                    "Artem\\Desktop\\Bank\\Bank\\DB\\" + user.account.id + ".txt", rowsCount);
                    label2.Text = "Дата открытия кредита:";
                    label4.Text = "Проценты по кредиту:";
                }
            }
        }

        //заповнення форми
        private void fillForm()
        {
            string[] fral = File.ReadAllLines("C:\\Users\\" +
                "Artem\\Desktop\\Bank\\Bank\\DB\\" + user.account.id + ".txt");
            if (fral.Length == 1)
            {
                dataGridView1.Visible = false;
                label5.Text = "Для отображения операций необходимо пополнить счет!";
                label5.Location = new Point(55, 235);
                dataGridView1.Visible = false;
            }
            else
            {
                StreamReader sr = new StreamReader("C:\\Users\\" +
                "Artem\\Desktop\\Bank\\Bank\\DB\\" + user.account.id + ".txt");
                string lineOperation = sr.ReadLine();
                string lineLastOperation = "";
                string[] lastOperation;
                while (lineOperation != null)
                {
                    lineLastOperation = lineOperation;
                    lineOperation = sr.ReadLine();
                }
                lastOperation = lineLastOperation.Split(new char[] { ' ' });
                if (lastOperation.Length == 4)
                {
                    dataGridView1.Rows.Add(lastOperation[0], lastOperation[1], (lastOperation[2] + " " + lastOperation[3]));
                }
                sr.Close();
            }
            idBox.Text = user.id;
            categoryBox.Text = user.account.category;
            ammountBox.Text = user.account.ammount;
            enrollmentBox.Text = user.account.openCreditOrEnroll_Date;
            ammountAfterEnroll.Text = user.account.procentOrAmount_Enroll;
        }

        //поповнення рахунку
        private void addMoney()
        {
            string[] rowsCount = File.ReadAllLines("C:\\Users\\" +
                "Artem\\Desktop\\Bank\\Bank\\DB\\" + user.account.id + ".txt");
            int moneyNow = Convert.ToInt32(user.account.ammount);
            int moneyAdded = Convert.ToInt32(moneyAddBox.Text);
            int moneyNowAndAdded = moneyNow + moneyAdded;
            int dayOfYearNow = Convert.ToInt32(DateTime.Now.DayOfYear);
            int yearNow = Convert.ToInt32(DateTime.Now.Year);
            if (user.account.category == "Кредитная карта(25%)")
            {
                
                if (moneyNowAndAdded >= 0)
                {
                    user.account.openCreditOrEnroll_Date = "отсутствует";
                    user.account.procentOrAmount_Enroll = "отсутствует";
                }
                else
                {
                    user.account.dayStart = DateTime.Now.DayOfYear + "";
                    user.account.yearStart = DateTime.Now.Year + "";
                    if (moneyNow >= 0)
                    {
                        user.account.procentOrAmount_Enroll = "0";
                    }
                }
                user.account.ammount = Convert.ToString(moneyNowAndAdded);

            }
            else
            {
                user.account.category = "Депозит(20%)";
                user.account.ammount = moneyNowAndAdded + "";
                if (rowsCount.Length == 1)
                {
                    user.account.openCreditOrEnroll_Date = NextYearDate();
                    double enrollAmmount = 
                        Math.Round(Convert.ToDouble(user.account.ammount) * 1.2);
                    user.account.procentOrAmount_Enroll = enrollAmmount + "";
                    user.account.dayStart = DateTime.Now.DayOfYear + "";
                    user.account.yearStart = DateTime.Now.Year + "";
                }
                else
                {
                    
                    int previousDayOfYear = Convert.ToInt32(user.account.dayStart);
                    int previousYear = Convert.ToInt32(user.account.yearStart);
                    int dayPassed;
                    if (yearNow - previousYear == 1 
                        && dayOfYearNow < previousDayOfYear)
                        dayPassed = (dayOfYearNow + 365) - previousDayOfYear;
                    else
                        dayPassed = dayOfYearNow - previousDayOfYear;
                    double moneyToEnroll = 
                        Math.Round((moneyNow * 0.2 / 365 * dayPassed) + moneyNowAndAdded
                        + (moneyNowAndAdded * 0.2 / 365 * (365 - dayPassed)));
                    user.account.procentOrAmount_Enroll = moneyToEnroll + "";
                }

            }

            rowsCount[0] = user.userData();

            File.WriteAllLines("C:\\Users\\" +
                "Artem\\Desktop\\Bank\\Bank\\DB\\" + user.account.id + ".txt", rowsCount);

            StreamWriter sr = new StreamWriter("C:\\Users\\" +
                "Artem\\Desktop\\Bank\\Bank\\DB\\" + user.account.id + ".txt", true);

            sr.Write(moneyAddBox.Text + " зачисление " + (DateTime.Now + "").Remove(16));
            sr.Close();

            MessageBox.Show("Счет пополнен!");
            accountForm acc = new accountForm(user.account.id);
            acc.Show();
            this.Hide();
        }

        //зняття коштів з рахунку
        private void removeMoney()
        {
            string[] rowsCount = File.ReadAllLines("C:\\Users\\" +
                "Artem\\Desktop\\Bank\\Bank\\DB\\" + user.account.id + ".txt");
            int moneyNow = Convert.ToInt32(user.account.ammount);
            int tryMoneyRemove = Convert.ToInt32(moneyRemoveBox.Text);
            int futureMoney = moneyNow - tryMoneyRemove;
            int yearNow = Convert.ToInt32(DateTime.Now.Year);
            int dayOfYearNow = Convert.ToInt32(DateTime.Now.DayOfYear);
            if (user.account.category == "Депозит(20%)")
            {
                int moneyToEnrollNow = Convert.ToInt32(user.account.procentOrAmount_Enroll);                
                user.account.ammount = futureMoney + "";
                if (rowsCount.Length != 1 && futureMoney >= 0)
                {
                    int previousDayOfYear = Convert.ToInt32(user.account.dayStart);                    
                    int previousYear = Convert.ToInt32(user.account.yearStart);
                    int dayPassed;
                    if (yearNow - previousYear == 1 && dayOfYearNow < previousDayOfYear)
                        dayPassed = (dayOfYearNow + 365) - previousDayOfYear;
                    else
                        dayPassed = dayOfYearNow - previousDayOfYear;
                    double moneyToEnroll = Math.Round(moneyToEnrollNow -
                        (tryMoneyRemove +
                        (tryMoneyRemove * 0.2 / 365 * (365 - dayPassed))));
                    user.account.procentOrAmount_Enroll = moneyToEnroll + "";
                    rowsCount[0] = user.userData();

                    File.WriteAllLines("C:\\Users\\" +
                    "Artem\\Desktop\\Bank\\Bank\\DB\\" + user.account.id + ".txt", rowsCount);

                    StreamWriter sr = new StreamWriter("C:\\Users\\" +
                    "Artem\\Desktop\\Bank\\Bank\\DB\\" + user.account.id + ".txt", true);
                    sr.Write(moneyRemoveBox.Text + " снятие " + (DateTime.Now + "").Remove(16));
                    sr.Close();

                    MessageBox.Show("Деньги сняты!");
                    accountForm acc = new accountForm(user.account.id);
                    acc.Show();
                    this.Hide();
                }
                else
                {
                    moneyRemoveBox.Text = "";
                    MessageBox.Show("Не хватает денег!");
                    return;
                }
            }

            else if (user.account.category == "Кредитная карта(25%)")
            {
                
                if (futureMoney >= -5000 && futureMoney < 0)
                {
                    
                    user.account.ammount = futureMoney + "";
                    user.account.openCreditOrEnroll_Date = (DateTime.Now + "").Remove(10);
                    if (moneyNow >= 0)
                    {
                        user.account.procentOrAmount_Enroll = "0";
                    }
                    user.account.dayStart = dayOfYearNow + "";
                    user.account.yearStart = yearNow + "";
                    rowsCount[0] = user.userData();
                    File.WriteAllLines("C:\\Users\\" +
                        "Artem\\Desktop\\Bank\\Bank\\DB\\" 
                        + user.account.id + ".txt", rowsCount);

                    StreamWriter sr = new StreamWriter("C:\\Users\\" +
                        "Artem\\Desktop\\Bank\\Bank\\DB\\" + user.account.id + ".txt", true);
                    sr.Write(moneyRemoveBox.Text + " снятие " + (DateTime.Now + "").Remove(16));
                    sr.Close();

                    MessageBox.Show("Деньги сняты!");
                    accountForm acc = new accountForm(user.account.id);
                    acc.Show();
                    this.Hide();
                }
                else if (futureMoney >= 0)
                {
                    user.account.ammount = Convert.ToString(futureMoney);
                    rowsCount[0] = user.userData();
                    File.WriteAllLines("C:\\Users\\" +
                        "Artem\\Desktop\\Bank\\Bank\\DB\\" 
                        + user.account.id + ".txt", rowsCount);

                    StreamWriter sr = new StreamWriter("C:\\Users\\" +
                       "Artem\\Desktop\\Bank\\Bank\\DB\\" 
                       + user.account.id + ".txt", true);
                    sr.Write(moneyRemoveBox.Text + " снятие " 
                        + (DateTime.Now + "").Remove(16));
                    sr.Close();

                    MessageBox.Show("Деньги сняты!");
                    accountForm acc = new accountForm(user.account.id);
                    acc.Show();
                    this.Hide();
                }
                else
                {
                    moneyRemoveBox.Text = "";
                    MessageBox.Show("Максимальная сумма по кредиту: 5000!");
                }

            }
            else
            {
                if (futureMoney >= 0)
                {
                    user.account.ammount = Convert.ToString(futureMoney);
                    rowsCount[0] = user.userData();
                    File.WriteAllLines("C:\\Users\\" +
                        "Artem\\Desktop\\Bank\\Bank\\DB\\" 
                        + user.account.id + ".txt", rowsCount);
                    MessageBox.Show("Деньги сняты!");
                    accountForm acc = new accountForm(user.account.id);
                    acc.Show();
                    this.Hide();
                }
                else
                {
                    moneyRemoveBox.Text = "";
                    MessageBox.Show("Не хватает денег!");
                    return;
                }
            }
        }

        //перевірка чи можливо зняти кошти
        private bool removeValidate()
        {
            if (moneyRemoveBox.Text.Length >= 7)
            {
                moneyRemoveBox.Text = "";
                MessageBox.Show("Максимальная сумма снятия за раз - 999999.");
                return false;
            }
            if (moneyRemoveBox.Text == "0")
            {
                moneyRemoveBox.Text = "";
                MessageBox.Show("Минимальная сумма снятия за раз - 1.");
                return false;
            }

            if (textBox3.Text != user.password)
            {
                MessageBox.Show("Неправильный пароль!");
                textBox3.Text = "";
                return false;
            }
            return true;
        }

        //повертає дату яка буде через рік
        public string NextYearDate()
        {
            int dayInt;
            string dayString = "";
            int monthInt;
            string monthString = "";
            int yearInt;
            string yearString;
            dayInt = Convert.ToInt32(DateTime.Now.Day);
            monthInt = Convert.ToInt32(DateTime.Now.Month);
            yearInt = Convert.ToInt32(DateTime.Now.Year);
            yearInt += 1;
            yearString = Convert.ToString(yearInt);
            if (dayInt < 10)
                dayString = "0" + Convert.ToString(dayInt);
            if (monthInt < 10)
                monthString = "0" + Convert.ToString(monthInt);
            if (dayString == "")
                dayString = Convert.ToString(dayInt);
            if (monthString == "")
                monthString = Convert.ToString(monthInt);
            return dayString + "." + monthString + "." + yearString;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorizationForm authorization = new authorizationForm();
            authorization.Show();
            this.Hide();
        }
    }       
}

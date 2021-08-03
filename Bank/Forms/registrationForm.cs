using System;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bank
{
    public partial class registrationForm : Form
    {
        string type = "none";
        private Point mouseLocation;
        public registrationForm()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(DateTime.Now).Remove(10);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void registerButton_Click(object sender, EventArgs e)
        {
            if(Validate()) createAccount();
        }

        private void KeyPressLetter(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;
            e.Handled = true;
        }
        
        private void KeyPressLetterDigit(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) 
                || e.KeyChar == (char)Keys.Back)
                return;
            e.Handled = true;
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressLetter(e);
        }

        private void firstNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressLetter(e);
        }
        
        private void passportNumbBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back 
                || char.IsLetter(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void loginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressLetterDigit(e);
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressLetterDigit(e);
        }

        private void passwordBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressLetterDigit(e);
        }

        private void keyWordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressLetter(e);
        }

        private void ddBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void registrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void registrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
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

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Text;
        }
        
        private void credButton_Click(object sender, EventArgs e)
        {
            type = "Кредитная карта(25%)";
            depLabel.ForeColor = Color.White;
            credLabel.ForeColor = Color.FromArgb(99, 245, 106);
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void depButton_Click(object sender, EventArgs e)
        {
            type = "Депозит(20%)";
            credLabel.ForeColor = Color.White;
            depLabel.ForeColor = Color.FromArgb(99, 245, 106);
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }


        //перевірка на коректність вхідних даних
        private bool Validate()
        {
            string patternLog = "^[A-Za-z0-9]{4,16}$";
            string patternPass = "^[A-Яа-яA-Za-z0-9]{4,16}$";
            string patternName = "^[А-Я][а-я]{1,15}$";
            string patternKeyWord = "^[А-Яа-я]{4,16}$";
            string patternPass1 = "^[0-9]{9}$";
            string patternPass2 = "^[А-Яа-я][А-Яа-я][0-9]{6}$";
            int day = Convert.ToInt32(dateTimePicker1.Text.Substring(0, 2));
            int mon = Convert.ToInt32(dateTimePicker1.Text.Substring(3, 2));
            int year = Convert.ToInt32(dateTimePicker1.Text.Substring(6, 4));
            if (type == "none")
            {
                MessageBox.Show("Выберите тип счета!");
                return false;
            }
            if (!Regex.IsMatch(nameBox.Text, patternName, RegexOptions.None))
            {
                nameBox.Text = "";
                MessageBox.Show("Имя должно начинаться с большой буквы и быть" +
                    " длинной 2-16 букв.\n\n Разрешены только буквы кириллицы!");
                return false;
            }
            if (!Regex.IsMatch(firstNameBox.Text, patternName, RegexOptions.None))
            {
                firstNameBox.Text = "";
                MessageBox.Show("Фамилия должна начинаться с большой буквы и быть" +
                    " длинной 2-16 букв.\n\n Разрешены только буквы кириллицы!");
                return false;
            }
            if (year > DateTime.Now.Year - 18)
            {
                dateTimePicker1.Text = $"{DateTime.Now.Day}.{DateTime.Now.Month}" +
                    $".{DateTime.Now.Year}";
                MessageBox.Show("Вам еще не исполнилось 18 лет!");
                return false;
            }
            if (year == DateTime.Now.Year - 18 && mon > DateTime.Now.Month)
            {
                dateTimePicker1.Text = $"{DateTime.Now.Day}.{DateTime.Now.Month}" +
                    $".{DateTime.Now.Year}";
                MessageBox.Show("Вам еще не исполнилось 18 лет!");
                return false;
            }
            if (year == DateTime.Now.Year - 18 && mon == DateTime.Now.Month 
                && day > DateTime.Now.Day)
            {
                dateTimePicker1.Text = $"{DateTime.Now.Day}.{DateTime.Now.Month}" +
                    $".{DateTime.Now.Year}";
                MessageBox.Show("Вам еще не исполнилось 18 лет!");
                return false;
            }
            if (!Regex.IsMatch(passportNumbBox.Text,
                patternPass1,
                RegexOptions.None)
               && !Regex.IsMatch(passportNumbBox.Text,
               patternPass2,
               RegexOptions.None))
            {
                passportNumbBox.Text = "";
                MessageBox.Show("Не корректный номер паспорта!\n\n" +
                    "Примеры пасспорта: \"012345678\" , \"МК012345\"");
                return false;
            }
            if (passportNumbBox.Text == "000000000"
                || passportNumbBox.Text.Contains("000000") 
                && passportNumbBox.Text.Length == 8)
            {
                passportNumbBox.Text = "";
                MessageBox.Show("Не корректный номер паспорта!\n");
                return false;
            }
            if (!Regex.IsMatch(loginBox.Text, patternLog, RegexOptions.None))
            {
                loginBox.Text = "";
                MessageBox.Show("Логин должен быть длинной  4-16 букв.\n\n" +
                    " Разрешены только буквы латиницы и цифры!");
                return false;
            }
            StreamReader sr = new StreamReader("C:\\Users\\Artem" +
                "\\Desktop\\Bank\\Bank\\DB\\count.txt");
            int count = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            StreamReader sr2 = new StreamReader("C:\\Users\\Artem" +
                "\\Desktop\\Bank\\Bank\\DB\\DBall.txt");
            sr2.ReadLine();
            string STR;
            string[] strArr;
            for (int i = 0; i < count; i++)
            {
                STR = sr2.ReadLine();
                strArr = STR.Split(' ');
                if (strArr[1] == loginBox.Text)
                {
                    sr2.Close();
                    loginBox.Text = "";
                    MessageBox.Show("Пользователь с таким логином" +
                        " уже существует!");
                    return false;
                }
            }
            sr2.Close();
            if (!Regex.IsMatch(passwordBox.Text, patternPass, RegexOptions.None))
            {
                passwordBox.Text = "";
                MessageBox.Show("Пароль должен быть длинной " +
                    "от 4 до 16 символов.\n\n" +
                    " Разрешены только буквы и цифры!");
                return false;
            }

            if (passwordBox.Text != passwordBox2.Text)
            {
                passwordBox.Text = "";
                passwordBox2.Text = "";
                MessageBox.Show("Пароли не совпадают!");
                return false;
            }

            if (!Regex.IsMatch(keyWordBox.Text, patternKeyWord, RegexOptions.None))
            {
                keyWordBox.Text = "";
                MessageBox.Show("Ключевое слово должно быть длиной" +
                    " от 4 до 16 символов.\n\n" +
                    " Разрешены только буквы кириллицы!");
                return false;
            }
            return true;
        }


        //створення нового аккаунта
        private void createAccount()
        {
            StreamReader sr3 = new StreamReader("C:\\Users\\Artem\\Desktop" +
                "\\Bank\\Bank\\DB\\count.txt");
            string id = Convert.ToString(Convert.ToInt32(sr3.ReadLine()) + 1);
            sr3.Close();
            StreamWriter sw = new StreamWriter("C:\\Users\\Artem\\Desktop" +
                "\\Bank\\Bank\\DB\\count.txt", false);
            sw.WriteLine(id);
            sw.Close();

            User user = new User(id);
            user.login = loginBox.Text;
            user.password = passwordBox.Text;
            user.name = nameBox.Text;
            user.firstName = firstNameBox.Text;
            user.birthday = dateTimePicker1.Text;
            user.passNumber = passportNumbBox.Text;
            user.keyWord = keyWordBox.Text;
            user.account.category = type;
            user.account.ammount = "0";
            user.account.openCreditOrEnroll_Date = "отсутствует";
            user.account.procentOrAmount_Enroll = "отсутствует";
            user.account.dayStart = "отсутствует";
            user.account.yearStart = "отсутствует";
            user.ReWrite();

            StreamWriter sw2 = new StreamWriter("C:\\Users\\Artem\\Desktop" +
                "\\Bank\\Bank\\DB\\DBall.txt", true);
            sw2.WriteLine();
            sw2.Write($"{id} {user.login} {user.password} {user.keyWord}");
            sw2.Close();

            accountForm account = new accountForm(user.id);
            account.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorizationForm authorization = new authorizationForm();
            authorization.Show();
            this.Hide();
        }
    }
}

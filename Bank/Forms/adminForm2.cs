using System;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bank
{
    public partial class adminForm2 : Form
    {
        Point mouseLocation;
        User user;
        public adminForm2()
        {
            InitializeComponent();
        }        

        public adminForm2(string id)
        {
            InitializeComponent();
            User user = new User(id);
            user.Update();
            this.user = user;
            fillForm();
        }

        private void adminForm2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void adminForm2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Validate()) changeData();
            adminForm2 admin2 = new adminForm2(user.account.id);
            admin2.Show();
            this.Hide();
        }

        private void ammountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
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

        private void ddBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Text;
        }

        //заповнення форми
        private void fillForm()
        {
            idBox.Text = user.id;
            textBox1.Text = user.birthday;
            nameBox.Text = user.name;
            firstNameBox.Text = user.firstName;
            dateTimePicker1.Text = user.birthday;
            passNumbBox.Text = user.passNumber;
            categoryBox.Text = user.account.category;
            ammountBox.Text = user.account.ammount;
            enrollmentBox.Text = user.account.openCreditOrEnroll_Date;
            ammountAfterEnroll.Text = user.account.procentOrAmount_Enroll;
            if (user.account.category == "Кредитная карта(25%)")
            {
                label2.Text = "Дата открытия кредита:";
                label8.Text = "Проценты по кредиту:";
            }
            string[] operations;
            string[] rows;
            operations = File.ReadAllLines("C:\\Users\\Artem\\Desktop" +
                "\\Bank\\Bank\\DB\\" + user.account.id + ".txt");
            for (int i = operations.Length - 1; i > 0; i--)
            {
                rows = operations[i].Split(new char[] { ' ' });
                dataGridView1.Rows.Add(
                    rows[0],
                    rows[1],
                    (rows[2] + " " + rows[3]));
            }
        }

        //перевірка чи можна змінити дані користувача на введені
        private bool Validate()
        {
            string patternName = "^[А-Я][а-я]{1,15}$";
            string patternPass1 = "^[0-9]{9}$";
            string patternPass2 = "^[А-Яа-я][А-Яа-я][0-9]{6}$";
            int day = Convert.ToInt32(dateTimePicker1.Text.Substring(0, 2));
            int mon = Convert.ToInt32(dateTimePicker1.Text.Substring(3, 2));
            int year = Convert.ToInt32(dateTimePicker1.Text.Substring(6, 4));
            if (!Regex.IsMatch(nameBox.Text, patternName, RegexOptions.None))
            {
                nameBox.Text = "";
                MessageBox.Show("Имя должно начинаться с большой буквы и быть" +
                    " длинной 2-16 букв.\n\n" +
                    " Разрешены только буквы кириллицы!");
                return false;
            }
            if (!Regex.IsMatch(firstNameBox.Text, patternName, RegexOptions.None))
            {
                firstNameBox.Text = "";
                MessageBox.Show("Фамилия должна начинаться с большой буквы и быть" +
                    " длинной 2-16 букв.\n\n" +
                    " Разрешены только буквы кириллицы!");
                return false;
            }
            if (!Regex.IsMatch(passNumbBox.Text, patternPass1, RegexOptions.None)
               && !Regex.IsMatch(passNumbBox.Text, patternPass2, RegexOptions.None))
            {
                passNumbBox.Text = "";
                MessageBox.Show("Не корректный номер паспорта!\n\n" +
                    "Примеры пасспорта: \"012345678\" , \"МК012345\"");
                return false;
            }
            if (passNumbBox.Text == "000000000"
                || passNumbBox.Text.Contains("000000") && passNumbBox.Text.Length == 8)
            {
                passNumbBox.Text = "";
                MessageBox.Show("Не корректный номер паспорта!\n");
                return false;
            }
            if (year > DateTime.Now.Year - 18)
            {
                dateTimePicker1.Text = $"{DateTime.Now.Day}." +
                    $"{DateTime.Now.Month}.{DateTime.Now.Year}";
                MessageBox.Show("Пользователю должно быть более 18 лет!");
                return false;
            }
            if (year == DateTime.Now.Year - 18 && mon > DateTime.Now.Month)
            {
                dateTimePicker1.Text = $"{DateTime.Now.Day}." +
                    $"{DateTime.Now.Month}.{DateTime.Now.Year}";
                MessageBox.Show("Пользователю должно быть более 18 лет!");
                return false;
            }
            if (year == DateTime.Now.Year - 18 
                && mon == DateTime.Now.Month 
                && day > DateTime.Now.Day)
            {
                dateTimePicker1.Text = $"{DateTime.Now.Day}" +
                    $".{DateTime.Now.Month}.{DateTime.Now.Year}";
                MessageBox.Show("Пользователю должно быть более 18 лет!");
                return false;
            }
            return true;
        }

        //зміна даних
        private void changeData()
        {
            string[] data = File.ReadAllLines("C:\\Users\\Artem\\Desktop\\Bank" +
                "\\Bank\\DB\\" + user.account.id + ".txt");
            user.name = nameBox.Text;
            user.firstName = firstNameBox.Text;
            user.passNumber = passNumbBox.Text;
            user.birthday = dateTimePicker1.Text.Substring(0, 10);
            data[0] = user.userData();
            File.WriteAllLines("C:\\Users\\Artem\\Desktop\\Bank" +
                "\\Bank\\DB\\" + user.account.id + ".txt", data);
            MessageBox.Show("Информация сохранена!");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminForm adm = new adminForm();
            adm.Show();
            this.Hide();
        }
    }
}

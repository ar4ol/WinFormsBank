using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Bank
{
    public partial class authorizationForm : Form
    {
        public Point mouseLocation;

        public authorizationForm()
        {
            InitializeComponent();
        }
                
        private void loginButton_Click(object sender, EventArgs e)
        {
            Validate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrationForm registration = new registrationForm();
            registration.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         
        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) 
                || e.KeyChar == (char)Keys.Back)
                return;
            e.Handled = true;
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) 
                || e.KeyChar == (char)Keys.Back)
                return;
            e.Handled = true;
        }

       

        private void button4_MouseHover(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.FromArgb(255, 11, 17);
            button4.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(36,47,61);
            button4.ForeColor = Color.FromArgb(74, 88, 101);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(74, 88, 101);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }        

        private void authorizationForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void authorizationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        //перевірка на коректність вхідних даних
        public void Validate()
        {
            if (passwordTextBox.Text.Length >= 16 
                || loginTextBox.Text.Length >= 16)
            {
                passwordTextBox.Text = "";
                loginTextBox.Text = "";
                MessageBox.Show("Неправильный логин или пароль!");
                return;
            }
            bool any = false;
            string line;
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string[] data;
            StreamReader sr = new StreamReader("C:\\Users\\Artem" +
                "\\Desktop\\Bank\\Bank\\DB\\DBall.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                data = line.Split(new char[] { ' ' });
                if (data[1] == login && data[2] == password)
                {
                    if (data[0] == "admin")
                    {
                        any = true;
                        adminForm admin = new adminForm();
                        admin.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        any = true;
                        accountForm account = new accountForm(data[0]);
                        account.Show();
                        this.Hide();
                    }
                }
                line = sr.ReadLine();
            }
            if (!any)
            {
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
                MessageBox.Show("Неправильный логин или пароль!");
            }
            sr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            forgotPassForm forg = new forgotPassForm();
            forg.Show();
            this.Hide();
        }
    }
}

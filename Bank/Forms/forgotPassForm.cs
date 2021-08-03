using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Bank
{
    public partial class forgotPassForm : Form
    {
        private Point mouseLocation;
        public forgotPassForm()
        {
            InitializeComponent();
        }
               
        private void restoreButton_Click(object sender, EventArgs e)
        {
            Validate();
        }
        
        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) 
                || e.KeyChar == (char)Keys.Back)
                return;
            e.Handled = true;
        }

        private void keyWordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;
            e.Handled = true;
        }


        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(74, 88, 101);
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.ForeColor = Color.White;
            button4.BackColor = Color.FromArgb(255, 11, 17);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(36, 47, 61);
            button4.ForeColor = Color.FromArgb(74, 88, 101);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void forgotPassForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void forgotPassForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        //перевірка на коректність вхідних даних
        private void Validate()
        {
            if (keyWordTextBox.Text.Length >= 16 
                || loginTextBox.Text.Length >= 16)
            {
                keyWordTextBox.Text = "";
                loginTextBox.Text = "";
                MessageBox.Show("Неправильный логин или пароль!");
                return;
            }
            bool any = false;
            string line;
            string login = loginTextBox.Text;
            string keyWord = keyWordTextBox.Text;
            string[] data;
            StreamReader sr = new StreamReader("C:\\Users\\Artem\\Desktop" +
                "\\Bank\\Bank\\DB\\DBall.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                data = line.Split(new char[] { ' ' });
                if (data[1] == login && data[3] == keyWord)
                {
                    any = true;
                    MessageBox.Show($"Ваш пароль: {data[2]}");
                    authorizationForm auth = new authorizationForm();
                    auth.Show();
                    this.Hide();
                }
                line = sr.ReadLine();
            }
            if (!any)
            {
                loginTextBox.Text = "";
                keyWordTextBox.Text = "";
                MessageBox.Show("Неправильный логин или ключевое слово!");
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorizationForm auth = new authorizationForm();
            auth.Show();
            this.Hide();
        }
    }
}

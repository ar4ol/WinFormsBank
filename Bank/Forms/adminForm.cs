using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Bank
{
    public partial class adminForm : Form
    {
        Point mouseLocation;
        int countUsers;
                
        public adminForm()
        {
            InitializeComponent();
            fillTable();
        }

        private void adminForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void adminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void searchIdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;
            e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (e.ColumnIndex == 3 && e.RowIndex == dataGridView1.Rows[i].Index)
                {
                    adminForm2 af2 = new adminForm2(Convert.ToString((++i)));
                    af2.Show();
                    this.Hide();
                }
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

        //заповнення форми
        private void fillTable()
        {
            StreamReader sr = new StreamReader("C:\\Users\\" +
                "Artem\\Desktop\\Bank\\Bank\\DB\\count.txt");
            countUsers = Convert.ToInt32(sr.ReadLine());
            sr.Close();
            for (int i = 1; i <= countUsers; i++)
            {
                string[] rows;
                StreamReader sr2 = new StreamReader("C:\\Users\\" +
                "Artem\\Desktop\\Bank\\Bank\\DB\\" + i + ".txt");
                rows = sr2.ReadLine().Split(new char[] { ' ' });
                dataGridView1.Rows.Add(rows[2], rows[3], rows[4]);
                sr2.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            authorizationForm authorization = new authorizationForm();
            authorization.Show();
            this.Hide();
        }
    }
}

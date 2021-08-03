namespace Bank
{
    partial class accountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accountForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Сумма = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тип = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammountAfterEnroll = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enrollmentBox = new System.Windows.Forms.TextBox();
            this.ammountBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addMoneyButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.moneyAddBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.removeMoneyButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.moneyRemoveBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.idBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.ammountAfterEnroll);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.enrollmentBox);
            this.tabPage1.Controls.Add(this.ammountBox);
            this.tabPage1.Controls.Add(this.categoryBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счет";
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.White;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idBox.ForeColor = System.Drawing.Color.Black;
            this.idBox.Location = new System.Drawing.Point(367, 30);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(369, 30);
            this.idBox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Счет:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(235, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Последняя транзакция:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Сумма,
            this.Тип,
            this.Дата});
            this.dataGridView1.Location = new System.Drawing.Point(36, 298);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(690, 53);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.TabStop = false;
            // 
            // Сумма
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Сумма.DefaultCellStyle = dataGridViewCellStyle2;
            this.Сумма.HeaderText = "Сумма";
            this.Сумма.MinimumWidth = 6;
            this.Сумма.Name = "Сумма";
            this.Сумма.ReadOnly = true;
            this.Сумма.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Тип
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Тип.DefaultCellStyle = dataGridViewCellStyle3;
            this.Тип.HeaderText = "Тип";
            this.Тип.MinimumWidth = 6;
            this.Тип.Name = "Тип";
            this.Тип.ReadOnly = true;
            this.Тип.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Дата
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Дата.DefaultCellStyle = dataGridViewCellStyle4;
            this.Дата.HeaderText = "Дата";
            this.Дата.MinimumWidth = 6;
            this.Дата.Name = "Дата";
            this.Дата.ReadOnly = true;
            this.Дата.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ammountAfterEnroll
            // 
            this.ammountAfterEnroll.BackColor = System.Drawing.Color.White;
            this.ammountAfterEnroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ammountAfterEnroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.ammountAfterEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ammountAfterEnroll.ForeColor = System.Drawing.Color.Black;
            this.ammountAfterEnroll.Location = new System.Drawing.Point(367, 212);
            this.ammountAfterEnroll.Name = "ammountAfterEnroll";
            this.ammountAfterEnroll.ReadOnly = true;
            this.ammountAfterEnroll.Size = new System.Drawing.Size(369, 30);
            this.ammountAfterEnroll.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Баланс после начисления:";
            // 
            // enrollmentBox
            // 
            this.enrollmentBox.BackColor = System.Drawing.Color.White;
            this.enrollmentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enrollmentBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.enrollmentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enrollmentBox.ForeColor = System.Drawing.Color.Black;
            this.enrollmentBox.Location = new System.Drawing.Point(367, 167);
            this.enrollmentBox.Name = "enrollmentBox";
            this.enrollmentBox.ReadOnly = true;
            this.enrollmentBox.Size = new System.Drawing.Size(369, 30);
            this.enrollmentBox.TabIndex = 16;
            // 
            // ammountBox
            // 
            this.ammountBox.BackColor = System.Drawing.Color.White;
            this.ammountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ammountBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ammountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ammountBox.ForeColor = System.Drawing.Color.Black;
            this.ammountBox.Location = new System.Drawing.Point(367, 122);
            this.ammountBox.Name = "ammountBox";
            this.ammountBox.ReadOnly = true;
            this.ammountBox.Size = new System.Drawing.Size(369, 30);
            this.ammountBox.TabIndex = 15;
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.Color.White;
            this.categoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryBox.ForeColor = System.Drawing.Color.Black;
            this.categoryBox.Location = new System.Drawing.Point(367, 77);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.ReadOnly = true;
            this.categoryBox.Size = new System.Drawing.Size(369, 30);
            this.categoryBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Тип:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Начисление процентов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Баланс:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.addMoneyButton);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.moneyAddBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пополнение";
            // 
            // addMoneyButton
            // 
            this.addMoneyButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addMoneyButton.FlatAppearance.BorderSize = 0;
            this.addMoneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMoneyButton.ForeColor = System.Drawing.Color.Black;
            this.addMoneyButton.Location = new System.Drawing.Point(210, 256);
            this.addMoneyButton.Name = "addMoneyButton";
            this.addMoneyButton.Size = new System.Drawing.Size(311, 53);
            this.addMoneyButton.TabIndex = 4;
            this.addMoneyButton.Text = "Пополнить";
            this.addMoneyButton.UseVisualStyleBackColor = false;
            this.addMoneyButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(362, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(361, 34);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(32, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Пароль:";
            // 
            // moneyAddBox
            // 
            this.moneyAddBox.BackColor = System.Drawing.Color.White;
            this.moneyAddBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyAddBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyAddBox.ForeColor = System.Drawing.Color.Black;
            this.moneyAddBox.Location = new System.Drawing.Point(362, 86);
            this.moneyAddBox.Name = "moneyAddBox";
            this.moneyAddBox.Size = new System.Drawing.Size(361, 34);
            this.moneyAddBox.TabIndex = 1;
            this.moneyAddBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moneyAddBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Сумма:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.removeMoneyButton);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.moneyRemoveBox);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(754, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Снятие";
            // 
            // removeMoneyButton
            // 
            this.removeMoneyButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.removeMoneyButton.FlatAppearance.BorderSize = 0;
            this.removeMoneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeMoneyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeMoneyButton.ForeColor = System.Drawing.Color.Black;
            this.removeMoneyButton.Location = new System.Drawing.Point(219, 254);
            this.removeMoneyButton.Name = "removeMoneyButton";
            this.removeMoneyButton.Size = new System.Drawing.Size(311, 55);
            this.removeMoneyButton.TabIndex = 9;
            this.removeMoneyButton.Text = "Снять";
            this.removeMoneyButton.UseVisualStyleBackColor = false;
            this.removeMoneyButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(313, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(361, 34);
            this.textBox3.TabIndex = 8;
            this.textBox3.UseSystemPasswordChar = true;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(31, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Пароль:";
            // 
            // moneyRemoveBox
            // 
            this.moneyRemoveBox.BackColor = System.Drawing.Color.White;
            this.moneyRemoveBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyRemoveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyRemoveBox.ForeColor = System.Drawing.Color.Black;
            this.moneyRemoveBox.Location = new System.Drawing.Point(313, 80);
            this.moneyRemoveBox.Name = "moneyRemoveBox";
            this.moneyRemoveBox.Size = new System.Drawing.Size(361, 34);
            this.moneyRemoveBox.TabIndex = 6;
            this.moneyRemoveBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moneyRemoveBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Сумма:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(724, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 30);
            this.button4.TabIndex = 32;
            this.button4.Text = "Х";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(689, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 30);
            this.button3.TabIndex = 31;
            this.button3.Text = "_";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(762, 30);
            this.button5.TabIndex = 30;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(18, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 52);
            this.button1.TabIndex = 38;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "accountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банк";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.accountForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.accountForm_MouseMove);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox ammountAfterEnroll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enrollmentBox;
        private System.Windows.Forms.TextBox ammountBox;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMoneyButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox moneyAddBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button removeMoneyButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox moneyRemoveBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сумма;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата;
        private System.Windows.Forms.Button button1;
    }
}
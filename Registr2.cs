using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OP
{
    public partial class Registr2 : Form
    {
        public Registr2()
        {
            InitializeComponent();
        }

        private void buttonRegist_Click(object sender, EventArgs e)
        {
            Registr RegistrForm = new Registr();
            RegistrForm.Show();
            this.Hide();
        }
        Point lastpoint;

        private void closeButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Registr2_MouceDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Registr2_MouceMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void closeButton2_click(object sender, EventArgs e)
        {
            closeButton2.BackColor = Color.Red;
        }

        private void closeButton2_MouceUp(object sender, MouseEventArgs e)
        {
            closeButton2.BackColor = SystemColors.Control;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (name_box.Text == "") {
                MessageBox.Show("Введіть логін");
                return;
            }
            else if (password_box.Text == "")
            {
                MessageBox.Show("Введіть пароль");
                return;
            }
            else if (email_box.Text == "")
            {
                MessageBox.Show("Введіть пошту");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`login`, `password`, `email`) VALUES (@login, @pass, @email)");
            command.Connection = db.getConnection();
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = name_box.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password_box.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email_box.Text;
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт створено");
            }
            else
                MessageBox.Show("Аккаунт не створено створено");
            db.closeConnection();

            Registr registr = new Registr();
            registr.Show();
            this.Hide();
        }
        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @login", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = name_box;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


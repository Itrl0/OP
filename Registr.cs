using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;

namespace OP
{
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void Registr_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        Point lastpoint;
        private void Registr_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseDown(object sender, MouseEventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        private void closeButton_MouseUp(object sender, MouseEventArgs e)
        {
            closeButton.BackColor = SystemColors.Control;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            string username = email_box.Text;
            string password = password_box.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @login AND `password` = @pass", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                kitchen kitchen = new kitchen();
                kitchen.Show();
                this.Hide();
                
            }
            else {
                MessageBox.Show("No");
            } 


            
        }

        private void buttonRegist_Click(object sender, EventArgs e)
        {
            Registr2 Registr2Form = new Registr2();
            Registr2Form.Show();
            this.Hide();
        }

        private void Registr_Load(object sender, EventArgs e)
        {

        }
    }
}


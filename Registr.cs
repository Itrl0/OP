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
            this.Close();
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
            kitchen kitchenForm = new kitchen(); // створюємо форму Kitchen
            kitchenForm.Show();                 // показуємо її
            this.Hide();
        }
    }
}

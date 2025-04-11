using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}


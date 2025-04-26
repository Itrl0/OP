using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP
{
    public partial class kitchen : Form
    {
        public kitchen()
        {
            InitializeComponent();
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

        private void fridge_Click(object sender, EventArgs e)
        {
            fridgeOpen fridgeOpenForm = new fridgeOpen(); 
            fridgeOpenForm.Show();                 
            this.Hide();
        }

        private void recipe_Click(object sender, EventArgs e)
        {
            menu menuForm = new menu(); 
            menuForm.Show();                
            this.Hide();
        }


        private void kitchenn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        Point lastpoint;

        private void kitchenn_MouseDown(object sender, MouseEventArgs e)
        {

            {
                lastpoint = new Point(e.X, e.Y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            shelf shelfForm = new shelf(); 
            shelfForm.Show();                 
            this.Hide();
        }
    }
}

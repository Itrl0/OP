﻿using System;
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
    public partial class recipe : Form
    {
        public recipe()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            kitchen kitchenForm = new kitchen(); // створюємо форму Kitchen
            kitchenForm.Show();                 // показуємо її
            this.Hide();
        }

        private void back_MouseDown(object sender, MouseEventArgs e)
        {
            back.BackColor = Color.Red;
        }

        private void back_MouseUp(object sender, MouseEventArgs e)
        {
            back.BackColor = SystemColors.Control;
        }

        private void recipe_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        Point lastpoint;
        private void recipe_MouseDown(object sender, MouseEventArgs e)
        {
            {
                lastpoint = new Point(e.X, e.Y);
            }
           
        }
    }
}

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
    public partial class recipe33 : Form
    {
        public recipe33()
        {
            InitializeComponent();
        }




        private void back_Click(object sender, EventArgs e)
        {
            recipe2 recipe2Form = new recipe2(); // створюємо форму Kitchen
            recipe2Form.Show();                 // показуємо її
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recipe55 recipe55Form = new recipe55(); // створюємо форму Kitchen
            recipe55Form.Show();                 // показуємо її
            this.Hide();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {
            recipe55 recipe55Form = new recipe55(); // створюємо форму Kitchen
            recipe55Form.Show();                 // показуємо її
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu menuForm = new menu();
            menuForm.Show();
            this.Hide();
        }
    }
}

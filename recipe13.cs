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
    public partial class recipe13 : Form
    {
        public recipe13()
        {
            InitializeComponent();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {
            recipe14 recipe14Form = new recipe14(); // створюємо форму Kitchen
            recipe14Form.Show();                 // показуємо її
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            recipe12 recipe12Form = new recipe12(); // створюємо форму Kitchen
            recipe12Form.Show();                 // показуємо її
            this.Hide();
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

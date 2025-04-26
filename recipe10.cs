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
    public partial class recipe10 : Form
    {
        public recipe10()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            recipe9 recipe9Form = new recipe9(); // створюємо форму Kitchen
            recipe9Form.Show();                 // показуємо її
            this.Hide();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {
            recipe11 recipe11Form = new recipe11(); // створюємо форму Kitchen
            recipe11Form.Show();                 // показуємо її
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

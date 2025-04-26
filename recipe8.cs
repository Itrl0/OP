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
    public partial class recipe8 : Form
    {
        public recipe8()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            recipe7 recipe7Form = new recipe7(); // створюємо форму Kitchen
            recipe7Form.Show();                 // показуємо її
            this.Hide();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {
            recipe9 recipe9Form = new recipe9(); // створюємо форму Kitchen
            recipe9Form.Show();                 // показуємо її
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

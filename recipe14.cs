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
    public partial class recipe14 : Form
    {
        public recipe14()
        {
            InitializeComponent();
        }



        private void back_Click(object sender, EventArgs e)
        {
            recipe13 recipe13Form = new recipe13(); // створюємо форму Kitchen
            recipe13Form.Show();                 // показуємо її
            this.Hide();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {
            recipe15 recipe15Form = new recipe15(); // створюємо форму Kitchen
            recipe15Form.Show();                 // показуємо її
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

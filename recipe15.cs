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
    public partial class recipe15 : Form
    {
        public recipe15()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void back_Click(object sender, EventArgs e)
        {
            recipe14 recipe14Form = new recipe14(); // створюємо форму Kitchen
            recipe14Form.Show();                 // показуємо її
            this.Hide();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {
            recipe16 recipe16Form = new recipe16(); // створюємо форму Kitchen
            recipe16Form.Show();                 // показуємо її
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

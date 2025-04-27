using OP.RecipeClasses;
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
    public partial class recipe18 : Form
    {
        public recipe18()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {

            recipe17 recipe17Form = new recipe17();
            recipe17Form.Show();
            this.Hide();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {

            recipe19 recipe19Form = new recipe19();
            recipe19Form.Show();
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

        private void cook_Click(object sender, EventArgs e)
        {

        }
    }
}

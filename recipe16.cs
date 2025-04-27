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
    public partial class recipe16 : Form
    {
        public recipe16()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            recipe15 recipe15Form = new recipe15(); // створюємо форму Kitchen
            recipe15Form.Show();                 // показуємо її
            this.Hide();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {
            recipe17 recipe17Form = new recipe17(); // створюємо форму Kitchen
            recipe17Form.Show();                 // показуємо її
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
            string jsonFilePath = "products.json";
            var sirnykyRecipe = new Soup(jsonFilePath);
            sirnykyRecipe.Cook();
        }
    }
}

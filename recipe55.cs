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
    public partial class recipe55 : Form
    {
        public recipe55()
        {
            InitializeComponent();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {

            recipe6 recipe6Form = new recipe6(); // створюємо форму Kitchen
            recipe6Form.Show();                 // показуємо її
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {

            recipe33 recipe33Form = new recipe33(); // створюємо форму Kitchen
            recipe33Form.Show();                 // показуємо її
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
            var sirnykyRecipe = new PoridgeWithMashrooms(jsonFilePath);
            sirnykyRecipe.Cook();
        }
    }
}

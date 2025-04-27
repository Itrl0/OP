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
    public partial class recipe21 : Form
    {
        public recipe21()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            recipe20 recipe20Form = new recipe20();
            recipe20Form.Show();
            this.Hide();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {
            recipe22 recipe22Form = new recipe22();
            recipe22Form.Show();
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
            var sirnykyRecipe = new BeatedMeat(jsonFilePath);
            sirnykyRecipe.Cook();
        }
    }
}

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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        
        private void back_Click(object sender, EventArgs e)
        {
            


            kitchen kitchenForm = new kitchen();
            kitchenForm.Show();
            this.Hide();

           
        }

        private void allrecipes_Click(object sender, EventArgs e)
        {
            recipe recipeForm = new recipe();
            recipeForm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe recipeForm = new recipe();
            recipeForm.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe16 recipe16Form = new recipe16();
            recipe16Form.Show();
            this.Hide();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe6 recipe6Form = new recipe6();
            recipe6Form.Show();
            this.Hide();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe7 recipe7Form = new recipe7();
            recipe7Form.Show();
            this.Hide();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe8 recipe8Form = new recipe8();
            recipe8Form.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe9 recipe9Form = new recipe9();
            recipe9Form.Show();
            this.Hide();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe55 recipe55Form = new recipe55();
            recipe55Form.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe19 recipe19Form = new recipe19();
            recipe19Form.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe21 recipe21Form = new recipe21();
            recipe21Form.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe22 recipe22Form = new recipe22();
            recipe22Form.Show();
            this.Hide();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe24 recipe24Form = new recipe24();
            recipe24Form.Show();
            this.Hide();
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe20 recipe20Form = new recipe20();
            recipe20Form.Show();
            this.Hide();
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe23 recipe23Form = new recipe23();
            recipe23Form.Show();
            this.Hide();
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe33 recipe33Form = new recipe33();
            recipe33Form.Show();
            this.Hide();
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe13 recipe13Form = new recipe13();
            recipe13Form.Show();
            this.Hide();
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe17 recipe17Form = new recipe17();
            recipe17Form.Show();
            this.Hide();
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe10 recipe10Form = new recipe10();
            recipe10Form.Show();
            this.Hide();
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe2 recipe2Form = new recipe2();
            recipe2Form.Show();
            this.Hide();
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe14 recipe14Form = new recipe14();
            recipe14Form.Show();
            this.Hide();
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe18 recipe18Form = new recipe18();
            recipe18Form.Show();
            this.Hide();
        }

        private void linkLabel28_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe26 recipe26Form = new recipe26();
            recipe26Form.Show();
            this.Hide();
        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe12 recipe12Form = new recipe12();
            recipe12Form.Show();
            this.Hide();
        }

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe15 recipe15Form = new recipe15();
            recipe15Form.Show();
            this.Hide();
        }

        private void linkLabel26_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe27 recipe27Form = new recipe27();
            recipe27Form.Show();
            this.Hide();
        }

        private void linkLabel27_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe28 recipe28Form = new recipe28();
            recipe28Form.Show();
            this.Hide();
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe25 recipe25Form = new recipe25();
            recipe25Form.Show();
            this.Hide();
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recipe11 recipe11Form = new recipe11();
            recipe11Form.Show();
            this.Hide();
        }
    }
}

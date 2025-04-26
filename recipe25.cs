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
    public partial class recipe25 : Form
    {
        public recipe25()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            recipe24 recipe24Form = new recipe24();
            recipe24Form.Show();
            this.Hide();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {
            recipe26 recipe26Form = new recipe26();
            recipe26Form.Show();
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

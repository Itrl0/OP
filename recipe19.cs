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
    public partial class recipe19 : Form
    {
        public recipe19()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            recipe18 recipe18Form = new recipe18();
            recipe18Form.Show();
            this.Hide();
        }

        private void next_Page_Click(object sender, EventArgs e)
        {
            recipe20 recipe20Form = new recipe20();
            recipe20Form.Show();
            this.Hide();
        }

        private void recipe19_Load(object sender, EventArgs e)
        {

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

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
    public partial class shelf : Form
    {
        public shelf()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            kitchen kitchenForm = new kitchen();
            kitchenForm.Show();
            this.Hide();
        }
    }
}

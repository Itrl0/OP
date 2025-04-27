using OP.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OP
{
    public partial class fridgeOpen : Form
    {
        private ProductRepository _repository;
        public fridgeOpen()
        {
            InitializeComponent();

            var storage = new JsonStorage<Product>("products.json");
            _repository = new ProductRepository(storage);
        }

        private void back_Click(object sender, EventArgs e)
        {
            kitchen kitchenForm = new kitchen();
            kitchenForm.Show();
            this.Hide();
        }

        private void back_MouseDown(object sender, MouseEventArgs e)
        {
            back.BackColor = Color.Red;
        }

        private void back_MouseUp(object sender, MouseEventArgs e)
        {
            back.BackColor = SystemColors.Control;
        }
        Point lastpoint;
        private void fridgeOpen_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void fridgeOpen_MouseDown(object sender, MouseEventArgs e)
        {
            {
                lastpoint = new Point(e.X, e.Y);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            if (!int.TryParse(textBoxQuantity.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Введіть коректну кількість.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введіть назву продукту.");
                return;
            }

            
            var existingProducts = _repository.GetAll();

            
            var existingProduct = existingProducts.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (existingProduct != null)
            {
                // Якщо вже є — додаємо кількість
                existingProduct.Quantity += quantity;
                _repository.Update(existingProduct); 
            }
            else
            {
                
                var newProduct = new Product(name, quantity);
                _repository.Add(newProduct);
            }

            
            textBoxName.Clear();
            textBoxQuantity.Clear();
        }
    }
}

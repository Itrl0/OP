using OP.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class shelf : Form
    {
        private ProductRepository _repository;
        private Dictionary<string, TextBox> _productTextBoxMap;
        public shelf()
        {
            InitializeComponent();
            var storage = new JsonStorage<Product>("products.json");
            _repository = new ProductRepository(storage);

            _productTextBoxMap = new Dictionary<string, TextBox>(StringComparer.OrdinalIgnoreCase)
            {
                {"Паніровка", textBox24},
                {"Борошно", textBox6},
                { "Олія", textBox22 },
                { "Макарони", textBox21 },
                { "Сіль", textBox23 },
                { "Цукор", textBox27 },
                { "Спеції", textBox1 },
                { "Гречана крупа", textBox2 },
                { "Рис", textBox3 },
                { "Сухарики", textBox4 }
            };


            LoadProductQuantities();
        }
        private void LoadProductQuantities()
        {
            var products = _repository.GetAll();

            foreach (var product in products)
            {
                if (_productTextBoxMap.TryGetValue(product.Name, out var textBox))
                {
                    textBox.Text = product.Quantity.ToString();
                }
            }
        }
        private void IncrementProductQuantity(string productName, TextBox quantitytextbox)
        {
            var products = _repository.GetAll();
            var product = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {

                product.Quantity += 1;
                _repository.Update(product);
            }
            else
            {

                var newProduct = new Product(productName, 1);
                _repository.Add(newProduct);
                product = newProduct;
            }
            quantitytextbox.Text = product.Quantity.ToString();
        }

        private void ReduceProductQuantity(string productName, TextBox quantitytextbox)
        {
            var products = _repository.GetAll();
            var product = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {

                product.Quantity -= 1;
                _repository.Update(product);
            }
            else
            {

                var newProduct = new Product(productName, 1);
                _repository.Add(newProduct);
                product = newProduct;
            }
            quantitytextbox.Text = product.Quantity.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            kitchen kitchenForm = new kitchen();
            kitchenForm.Show();
            this.Hide();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Паніровка", textBox24);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Макарони", textBox21);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Борошно", textBox6);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Олія", textBox22);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Сіль", textBox23);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Цукор", textBox27);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Спеції", textBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Гречана крупа", textBox2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Рис", textBox3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IncrementProductQuantity("Сухарики", textBox4);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Паніровка", textBox24);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Макарони", textBox21);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Борошно", textBox6);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Олія", textBox22);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Сіль", textBox23);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Цукор", textBox27);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Спеції", textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Гречана крупа", textBox2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Рис", textBox3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReduceProductQuantity("Сухарики", textBox4);
        }
    }
}
